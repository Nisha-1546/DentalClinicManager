using DentalApp.core.Contracts;
using DentalApp.core.Models;
using System.ComponentModel;

namespace DentalClinicManager.Views
{
    public partial class BillingView : UserControl
    {
        private readonly IBillingService _billingService;
        private BindingSource _bindingSource = new BindingSource();

        public BillingView(IBillingService billingService)
        {
            InitializeComponent();

            _billingService = billingService;
            dgvBills.EnableHeadersVisualStyles = false;

            dgvBills.AutoGenerateColumns = false;
            dgvBills.DataSource = _bindingSource;

            LoadBills();
        }

        
        private void LoadBills()
        {
            var bills = _billingService.GetAll();
            _bindingSource.DataSource = bills;
            lblCount.Text = $"Total: {bills.Count}";
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
            var bills = _billingService.Search(txtSearch.Text);
            _bindingSource.DataSource = bills;
            lblCount.Text = $"Showing: {bills.Count}";
        }

        private void lblCount_Click(object sender, EventArgs e) { }
    }
}