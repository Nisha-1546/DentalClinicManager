using DentalApp.core.Contracts;
using DentalApp.core.Models;
using DentalApp.core.Utilities;

namespace DentalClinicManager.Forms
{
    public partial class AppointmentForm : Form
    {
        private readonly IAppointmentService _service;
        private readonly IPatientService _patientService;
        private readonly AppointmentFormModeEnum _mode;
        private Appointment _appointment;

        public AppointmentForm(
            IAppointmentService service,
            IPatientService patientService,
            AppointmentFormModeEnum mode,
            Appointment? appointment = null)
        {
            InitializeComponent();

            _service = service;
            _patientService = patientService;
            _mode = mode;
            _appointment = appointment ?? new Appointment();

            LoadPatients();
            PopulateFields();
            SetupMode();
        }

        private void LoadPatients()
        {
            var patients = _patientService.GetAll();
            cmbPatient.DataSource = patients;
            cmbPatient.DisplayMember = "Name";
            cmbPatient.ValueMember = "Id";
        }

        private void PopulateFields()
        {
            if (_appointment.PatientId > 0)
                cmbPatient.SelectedValue = _appointment.PatientId;

            txtDoctor.Text = _appointment.Doctor;
            dtpDate.Value = _appointment.AppDate == default ? DateTime.Today : _appointment.AppDate;
            dtpTime.Value = DateTime.Today.Add(_appointment.AppTime == default ? TimeSpan.FromHours(9) : _appointment.AppTime);
            txtTreatment.Text = _appointment.Treatment;
            numCost.Value = _appointment.Cost;
            cmbStatus.SelectedItem = _appointment.Status;
            txtNotes.Text = _appointment.Notes ?? string.Empty;
        }

      
        private void SetupMode()
        {
            switch (_mode)
            {
                case AppointmentFormModeEnum.Add:
                    this.Text = "Add Appointment";
                    cmbStatus.SelectedItem = "Scheduled";
                    break;

                case AppointmentFormModeEnum.Edit:
                    this.Text = "Edit Appointment";
                    break;

                case AppointmentFormModeEnum.View:
                    this.Text = "View Appointment";
                    cmbPatient.Enabled = false;
                    txtDoctor.ReadOnly = true;
                    dtpDate.Enabled = false;
                    dtpTime.Enabled = false;
                    txtTreatment.ReadOnly = true;
                    numCost.Enabled = false;
                    cmbStatus.Enabled = false;
                    txtNotes.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var selected = cmbPatient.SelectedItem as DentalApp.core.Models.Patient;

                _appointment.PatientId = selected?.Id ?? 0;
                _appointment.PatientName = selected?.Name ?? string.Empty;
                _appointment.Doctor = txtDoctor.Text.Trim();
                _appointment.AppDate = dtpDate.Value.Date;
                _appointment.AppTime = dtpTime.Value.TimeOfDay;
                _appointment.Treatment = txtTreatment.Text.Trim();
                _appointment.Cost = numCost.Value;
                _appointment.Status = cmbStatus.SelectedItem?.ToString() ?? "Scheduled";
                _appointment.Notes = string.IsNullOrWhiteSpace(txtNotes.Text) ? null : txtNotes.Text.Trim();

                if (_appointment.Cost <= 0)
                {
                    MessageBox.Show(
                        "Please enter a valid cost greater than 0.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                var validation = _service.Validate(_appointment);

                if (!validation.IsValid)
                {
                    MessageBox.Show(
                        string.Join(Environment.NewLine, validation.Errors),
                        "Validation Errors",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (_mode == AppointmentFormModeEnum.Add)
                    _service.Add(_appointment);
                else if (_mode == AppointmentFormModeEnum.Edit)
                    _service.Update(_appointment);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}