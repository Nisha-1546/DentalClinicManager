using System;
using System.Windows.Forms;
using DentalApp.core.Models;
using DentalApp.core.Contracts;
using DentalApp.core.Utilities;

namespace DentalClinicManager.Forms
{
    public partial class PatientForm : Form
    {
        private readonly IPatientService _service;
        private readonly PatientFormModeEnum _mode;
        private Patient _patient;

        public PatientForm(IPatientService service, PatientFormModeEnum mode, Patient? patient = null)
        {
            InitializeComponent();

            _service = service;
            _mode = mode;
            _patient = patient ?? new Patient();

            PopulateFields();
            SetupMode();
        }

        
        private void PopulateFields()
        {
            txtName.Text = _patient.Name;
            txtPhone.Text = _patient.Phone;
            txtEmail.Text = _patient.Email;
            txtAddress.Text = _patient.Address;
        }

        private void SetupMode()
        {
            switch (_mode)
            {
                case PatientFormModeEnum.Add:
                    this.Text = "Add Patient";
                    break;

                case PatientFormModeEnum.Edit:
                    this.Text = "Edit Patient";
                    break;

                case PatientFormModeEnum.View:
                    this.Text = "View Patient";

                    txtName.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtAddress.ReadOnly = true;

                    btnSave.Visible = false;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                _patient.Name = txtName.Text.Trim();
                _patient.Phone = txtPhone.Text.Trim();
                _patient.Email = txtEmail.Text.Trim();
                _patient.Address = txtAddress.Text.Trim();

            
                var validation = _service.Validate(_patient);

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

                if (_mode == PatientFormModeEnum.Add)
                    _service.Add(_patient);
                else if (_mode == PatientFormModeEnum.Edit)
                    _service.Update(_patient);

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