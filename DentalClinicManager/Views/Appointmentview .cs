using DentalApp.core.Contracts;
using DentalApp.core.Models;
using DentalApp.core.Utilities;
using DentalClinicManager.Forms;
using System.ComponentModel;
using System.Linq;

namespace DentalClinicManager.Views
{
    public partial class AppointmentView : UserControl
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IPatientService _patientService;
        private readonly IBillingService _billingService;
        private BindingSource _bindingSource = new BindingSource();
        private List<Appointment> _appointments = [];
        private string _sortProperty = nameof(Appointment.AppDate);
        private ListSortDirection _sortDirection = ListSortDirection.Descending;

        public AppointmentView(IAppointmentService appointmentService, IPatientService patientService, IBillingService billingService)
        {
            InitializeComponent();

            _appointmentService = appointmentService;
            _patientService = patientService;
            _billingService = billingService;

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.DataSource = _bindingSource;
            cmbStatusFilter.SelectedIndex = 0;

            LoadAppointments();
        }

       
        private void LoadAppointments()
        {
            _appointments = _appointmentService.GetAll();
            ApplyFilters();
        }

        
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using var form = new AppointmentForm(
                _appointmentService,
                _patientService,
                AppointmentFormModeEnum.Add
            );

            if (form.ShowDialog() == DialogResult.OK)
                LoadAppointments();
        }

        
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var selected = _bindingSource.Current as Appointment;
            if (selected == null) return;

            using var form = new AppointmentForm(
                _appointmentService,
                _patientService,
                AppointmentFormModeEnum.Edit,
                selected
            );

            if (form.ShowDialog() == DialogResult.OK)
                LoadAppointments();
        }

     
        private void tsbView_Click(object sender, EventArgs e)
        {
            var selected = _bindingSource.Current as Appointment;
            if (selected == null) return;

            using var form = new AppointmentForm(
                _appointmentService,
                _patientService,
                AppointmentFormModeEnum.View,
                selected
            );

            form.ShowDialog();
        }

        
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var selected = _bindingSource.Current as Appointment;
            if (selected == null) return;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                _appointmentService.Delete(selected.Id);
                LoadAppointments();
            }
        }

      
        private void tsbComplete_Click(object sender, EventArgs e)
        {
            var selected = _bindingSource.Current as Appointment;
            if (selected == null) return;

            try
            {
                _appointmentService.UpdateStatus(selected.Id, "Completed");

                var existing = _billingService.GetByAppointmentId(selected.Id);
                if (existing == null)
                {
                    var bill = new Bill
                    {
                        AppointmentId = selected.Id,
                        PatientId = selected.PatientId,
                        PatientName = selected.PatientName,
                        Treatment = selected.Treatment,
                        Doctor = selected.Doctor,
                        Amount = selected.Cost,
                        Status = "Unpaid",
                        BillDate = DateTime.Now
                    };

                    _billingService.Add(bill);

                    MessageBox.Show(
                        $"Bill generated!\nPatient: {bill.PatientName}\nAmount: Rs {bill.Amount:N0}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Bill already exists for this appointment.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ERROR:\n" + ex.Message + "\n\n" + ex.InnerException?.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            var selected = _bindingSource.Current as Appointment;
            if (selected == null) return;

            _appointmentService.UpdateStatus(selected.Id, "Cancelled");
            LoadAppointments();
        }

        
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

      
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dgvAppointments_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var propertyName = dgvAppointments.Columns[e.ColumnIndex].DataPropertyName;
            if (string.IsNullOrWhiteSpace(propertyName)) return;

            if (_sortProperty == propertyName)
            {
                _sortDirection = _sortDirection == ListSortDirection.Ascending
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }
            else
            {
                _sortProperty = propertyName;
                _sortDirection = ListSortDirection.Ascending;
            }

            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var query = txtSearch.Text.Trim();
            var status = cmbStatusFilter.SelectedItem?.ToString() ?? "All";
            IEnumerable<Appointment> appointments = _appointments;

            if (!string.Equals(status, "All", StringComparison.OrdinalIgnoreCase))
                appointments = appointments.Where(a => string.Equals(a.Status, status, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(query))
            {
                appointments = appointments.Where(a =>
                    Contains(a.PatientName, query) ||
                    Contains(a.Doctor, query) ||
                    Contains(a.Treatment, query) ||
                    Contains(a.Status, query));
            }

            var sortedAppointments = SortAppointments(appointments);
            _bindingSource.DataSource = sortedAppointments;
            lblCount.Text = string.IsNullOrWhiteSpace(query) && status == "All"
                ? $"Total: {sortedAppointments.Count}"
                : $"Showing: {sortedAppointments.Count}";
        }

        private List<Appointment> SortAppointments(IEnumerable<Appointment> appointments)
        {
            return (_sortProperty, _sortDirection) switch
            {
                (nameof(Appointment.PatientName), ListSortDirection.Ascending) => appointments.OrderBy(a => a.PatientName).ToList(),
                (nameof(Appointment.PatientName), ListSortDirection.Descending) => appointments.OrderByDescending(a => a.PatientName).ToList(),
                (nameof(Appointment.Doctor), ListSortDirection.Ascending) => appointments.OrderBy(a => a.Doctor).ToList(),
                (nameof(Appointment.Doctor), ListSortDirection.Descending) => appointments.OrderByDescending(a => a.Doctor).ToList(),
                (nameof(Appointment.AppDate), ListSortDirection.Ascending) => appointments.OrderBy(a => a.AppDate).ThenBy(a => a.AppTime).ToList(),
                (nameof(Appointment.AppDate), ListSortDirection.Descending) => appointments.OrderByDescending(a => a.AppDate).ThenByDescending(a => a.AppTime).ToList(),
                (nameof(Appointment.AppTime), ListSortDirection.Ascending) => appointments.OrderBy(a => a.AppTime).ToList(),
                (nameof(Appointment.AppTime), ListSortDirection.Descending) => appointments.OrderByDescending(a => a.AppTime).ToList(),
                (nameof(Appointment.Treatment), ListSortDirection.Ascending) => appointments.OrderBy(a => a.Treatment).ToList(),
                (nameof(Appointment.Treatment), ListSortDirection.Descending) => appointments.OrderByDescending(a => a.Treatment).ToList(),
                (nameof(Appointment.Cost), ListSortDirection.Ascending) => appointments.OrderBy(a => a.Cost).ToList(),
                (nameof(Appointment.Cost), ListSortDirection.Descending) => appointments.OrderByDescending(a => a.Cost).ToList(),
                (nameof(Appointment.Status), ListSortDirection.Ascending) => appointments.OrderBy(a => a.Status).ToList(),
                (nameof(Appointment.Status), ListSortDirection.Descending) => appointments.OrderByDescending(a => a.Status).ToList(),
                (_, ListSortDirection.Descending) => appointments.OrderByDescending(a => a.Id).ToList(),
                _ => appointments.OrderBy(a => a.Id).ToList()
            };
        }

        private void lblCount_Click(object sender, EventArgs e) { }

        private static bool Contains(string? value, string query) =>
            value?.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0;
    }
}
