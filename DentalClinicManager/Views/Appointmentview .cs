using DentalApp.core.Contracts;
using DentalApp.core.Models;
using DentalApp.core.Utilities;
using DentalClinicManager.Forms;
using System.ComponentModel;

namespace DentalClinicManager.Views
{
    public partial class AppointmentView : UserControl
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IPatientService _patientService;
        private readonly IBillingService _billingService;
        private BindingSource _bindingSource = new BindingSource();

        public AppointmentView(IAppointmentService appointmentService, IPatientService patientService, IBillingService billingService)
        {
            InitializeComponent();

            _appointmentService = appointmentService;
            _patientService = patientService;
            _billingService = billingService;

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.DataSource = _bindingSource;

            LoadAppointments();
        }

       
        private void LoadAppointments()
        {
            var appointments = _appointmentService.GetAll();
            _bindingSource.DataSource = appointments;
            lblCount.Text = $"Total: {appointments.Count}";
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
            var appointments = _appointmentService.Search(txtSearch.Text);
            _bindingSource.DataSource = appointments;
            lblCount.Text = $"Showing: {appointments.Count}";
        }

        private void lblCount_Click(object sender, EventArgs e) { }
    }
}