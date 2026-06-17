using DentalApp.core.Contracts;
using DentalApp.core.Models;
using System.ComponentModel;
using System.Linq;

namespace DentalClinicManager.Views
{
    public partial class BillingView : UserControl
    {
        private readonly IBillingService _billingService;
        private BindingSource _bindingSource = new BindingSource();
        private List<Bill> _bills = [];
        private string _sortProperty = nameof(Bill.BillDate);
        private ListSortDirection _sortDirection = ListSortDirection.Descending;

        public BillingView(IBillingService billingService)
        {
            InitializeComponent();

            _billingService = billingService;
            dgvBills.EnableHeadersVisualStyles = false;

            dgvBills.AutoGenerateColumns = false;
            dgvBills.DataSource = _bindingSource;
            cmbStatusFilter.SelectedIndex = 0;

            LoadBills();
        }

        private void LoadBills()
        {
            _bills = _billingService.GetAll();
            ApplyFilters();
        }

        private void tsbPaid_Click(object sender, EventArgs e)
        {
            var selected = _bindingSource.Current as Bill;
            if (selected == null) return;

            _billingService.UpdateStatus(selected.Id, "Paid");
            LoadBills();
        }

        private void tsbUnpaid_Click(object sender, EventArgs e)
        {
            var selected = _bindingSource.Current as Bill;
            if (selected == null) return;

            _billingService.UpdateStatus(selected.Id, "Unpaid");
            LoadBills();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            var selected = _bindingSource.Current as Bill;
            if (selected == null) return;

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this bill?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                _billingService.Delete(selected.Id);
                LoadBills();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            LoadBills();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dgvBills_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var propertyName = dgvBills.Columns[e.ColumnIndex].DataPropertyName;
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
            IEnumerable<Bill> bills = _bills;

            if (!string.Equals(status, "All", StringComparison.OrdinalIgnoreCase))
                bills = bills.Where(b => string.Equals(b.Status, status, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrWhiteSpace(query))
            {
                bills = bills.Where(b =>
                    Contains(b.PatientName, query) ||
                    Contains(b.Treatment, query) ||
                    Contains(b.Doctor, query) ||
                    Contains(b.Status, query));
            }

            var sortedBills = SortBills(bills);
            _bindingSource.DataSource = sortedBills;
            lblCount.Text = string.IsNullOrWhiteSpace(query) && status == "All"
                ? $"Total: {sortedBills.Count}"
                : $"Showing: {sortedBills.Count}";
        }

        private List<Bill> SortBills(IEnumerable<Bill> bills)
        {
            return (_sortProperty, _sortDirection) switch
            {
                (nameof(Bill.AppointmentId), ListSortDirection.Ascending) => bills.OrderBy(b => b.AppointmentId).ToList(),
                (nameof(Bill.AppointmentId), ListSortDirection.Descending) => bills.OrderByDescending(b => b.AppointmentId).ToList(),
                (nameof(Bill.PatientName), ListSortDirection.Ascending) => bills.OrderBy(b => b.PatientName).ToList(),
                (nameof(Bill.PatientName), ListSortDirection.Descending) => bills.OrderByDescending(b => b.PatientName).ToList(),
                (nameof(Bill.Treatment), ListSortDirection.Ascending) => bills.OrderBy(b => b.Treatment).ToList(),
                (nameof(Bill.Treatment), ListSortDirection.Descending) => bills.OrderByDescending(b => b.Treatment).ToList(),
                (nameof(Bill.Doctor), ListSortDirection.Ascending) => bills.OrderBy(b => b.Doctor).ToList(),
                (nameof(Bill.Doctor), ListSortDirection.Descending) => bills.OrderByDescending(b => b.Doctor).ToList(),
                (nameof(Bill.Amount), ListSortDirection.Ascending) => bills.OrderBy(b => b.Amount).ToList(),
                (nameof(Bill.Amount), ListSortDirection.Descending) => bills.OrderByDescending(b => b.Amount).ToList(),
                (nameof(Bill.Status), ListSortDirection.Ascending) => bills.OrderBy(b => b.Status).ToList(),
                (nameof(Bill.Status), ListSortDirection.Descending) => bills.OrderByDescending(b => b.Status).ToList(),
                (nameof(Bill.BillDate), ListSortDirection.Ascending) => bills.OrderBy(b => b.BillDate).ToList(),
                (nameof(Bill.BillDate), ListSortDirection.Descending) => bills.OrderByDescending(b => b.BillDate).ToList(),
                (_, ListSortDirection.Descending) => bills.OrderByDescending(b => b.Id).ToList(),
                _ => bills.OrderBy(b => b.Id).ToList()
            };
        }

        private void lblCount_Click(object sender, EventArgs e) { }

        private static bool Contains(string? value, string query) =>
            value?.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0;
    }
}
