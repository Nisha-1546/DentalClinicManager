using DentalApp.core.Contracts;
using DentalApp.core.Models;
using DentalApp.core.Utilities;
using DentalClinicManager.Forms;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DentalClinicManager.Views
{
    public partial class PatientView : UserControl
    {
        private readonly IPatientService _patientService;
        private BindingSource _bindingSource = new BindingSource();
        private List<Patient> _patients = [];
        private string _sortProperty = nameof(Patient.Id);
        private ListSortDirection _sortDirection = ListSortDirection.Ascending;

        public PatientView(IPatientService service)
        {
            InitializeComponent();

            _patientService = service;
            dgvPatients.AutoGenerateColumns = false;

            dgvPatients.DataSource = _bindingSource;
            cmbFilter.SelectedIndex = 0;

            _ = LoadPatientsAsync();
        }
        private void lblCount_Click(object sender, EventArgs e) { }

       
        private async Task LoadPatientsAsync()
        {
            SetLoading(true);
            try
            {
                _patients = await _patientService.GetAllAsync();
                ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load patients.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetLoading(false);
            }
        }


        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using var form = new PatientForm(
                _patientService,
                PatientFormModeEnum.Add
            );

            if (form.ShowDialog() == DialogResult.OK)
            {
                _ = LoadPatientsAsync();
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
                    _ = LoadPatientsAsync();
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
                    _ = LoadPatientsAsync();
                }
            }
        }

       
        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            _ = LoadPatientsAsync();
        }

       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dgvPatients_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var propertyName = dgvPatients.Columns[e.ColumnIndex].DataPropertyName;
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
            var filter = cmbFilter.SelectedItem?.ToString() ?? "All";
            IEnumerable<Patient> patients = _patients;

            if (!string.IsNullOrWhiteSpace(query))
            {
                patients = filter switch
                {
                    "Name" => patients.Where(p => Contains(p.Name, query)),
                    "Phone" => patients.Where(p => Contains(p.Phone, query)),
                    "Email" => patients.Where(p => Contains(p.Email, query)),
                    _ => patients.Where(p =>
                        Contains(p.Name, query) ||
                        Contains(p.Phone, query) ||
                        Contains(p.Email, query) ||
                        Contains(p.Address, query))
                };
            }

            var sortedPatients = SortPatients(patients);
            _bindingSource.DataSource = sortedPatients;

            lblCount.Text = string.IsNullOrWhiteSpace(query) && filter == "All"
                ? $"Total: {sortedPatients.Count}"
                : $"Showing: {sortedPatients.Count}";
        }

        private List<Patient> SortPatients(IEnumerable<Patient> patients)
        {
            return (_sortProperty, _sortDirection) switch
            {
                (nameof(Patient.Name), ListSortDirection.Ascending) => patients.OrderBy(p => p.Name).ToList(),
                (nameof(Patient.Name), ListSortDirection.Descending) => patients.OrderByDescending(p => p.Name).ToList(),
                (nameof(Patient.Phone), ListSortDirection.Ascending) => patients.OrderBy(p => p.Phone).ToList(),
                (nameof(Patient.Phone), ListSortDirection.Descending) => patients.OrderByDescending(p => p.Phone).ToList(),
                (nameof(Patient.Email), ListSortDirection.Ascending) => patients.OrderBy(p => p.Email).ToList(),
                (nameof(Patient.Email), ListSortDirection.Descending) => patients.OrderByDescending(p => p.Email).ToList(),
                (nameof(Patient.Address), ListSortDirection.Ascending) => patients.OrderBy(p => p.Address).ToList(),
                (nameof(Patient.Address), ListSortDirection.Descending) => patients.OrderByDescending(p => p.Address).ToList(),
                (nameof(Patient.CreatedAt), ListSortDirection.Ascending) => patients.OrderBy(p => p.CreatedAt).ToList(),
                (nameof(Patient.CreatedAt), ListSortDirection.Descending) => patients.OrderByDescending(p => p.CreatedAt).ToList(),
                (_, ListSortDirection.Descending) => patients.OrderByDescending(p => p.Id).ToList(),
                _ => patients.OrderBy(p => p.Id).ToList()
            };
        }

        private void SetLoading(bool isLoading)
        {
            tsPatient.Enabled = !isLoading;
            txtSearch.Enabled = !isLoading;
            cmbFilter.Enabled = !isLoading;
            dgvPatients.Enabled = !isLoading;
            lblCount.Text = isLoading ? "Loading..." : lblCount.Text;
        }

        private static bool Contains(string? value, string query) =>
            value?.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0;
    }
}
