using DentalApp.core.Contracts;
using DentalApp.core.Models;
using DentalApp.core.Utilities;
using DentalClinicManager.Forms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DentalClinicManager.Views
{
    public partial class PatientView : UserControl
    {
        private readonly IPatientService _patientService;
        private BindingSource _bindingSource = new BindingSource();

        public PatientView(IPatientService service)
        {
            InitializeComponent();

            _patientService = service;
            dgvPatients.AutoGenerateColumns = false;

            dgvPatients.DataSource = _bindingSource;

            LoadPatients();
        }
        private void lblCount_Click(object sender, EventArgs e) { }

       
        private void LoadPatients()
        {
            var patients = _patientService.GetAll();

            _bindingSource.DataSource = patients;

            lblCount.Text = $"Total: {patients.Count}";
        }


        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using var form = new PatientForm(
                _patientService,
                PatientFormModeEnum.Add
            );

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadPatients();
            }
        }

     
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            var selectedPatient = _bindingSource.Current as Patient;

            if (selectedPatient != null)
            {
                using var form = new PatientForm(
                    _patientService,
                    PatientFormModeEnum.Edit,
                    selectedPatient
                );

                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadPatients();
                }
            }
        }

    
        private void tsbView_Click(object sender, EventArgs e)
        {
            var selectedPatient = _bindingSource.Current as Patient;

            if (selectedPatient != null)
            {
                using var form = new PatientForm(
                    _patientService,
                    PatientFormModeEnum.View,
                    selectedPatient
                );

                form.ShowDialog();
            }
        }

      
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var selectedPatient = _bindingSource.Current as Patient;

            if (selectedPatient != null)
            {
                var confirm = MessageBox.Show(
                    "Are you sure you want to delete this patient?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    _patientService.Delete(selectedPatient.Id);
                    LoadPatients();
                }
            }
        }

       
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            LoadPatients();
        }

       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            var patients = _patientService.Search(txtSearch.Text);

            _bindingSource.DataSource = patients;

            lblCount.Text = $"Showing: {patients.Count}";
        }
    }
}