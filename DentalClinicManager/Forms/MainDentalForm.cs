using DentalApp.core.Contracts;
using DentalApp.core.Services;
using DentalClinicManager.Views;
using System.Configuration;

namespace DentalClinicManager.Forms
{
    public partial class MainDentalForm : Form
    {
        private readonly IPatientService _patientService;
        private readonly IDashboardService _dashboardService;
        private readonly IAppointmentService _appointmentService;
        private readonly IBillingService _billingService;

        private readonly Dictionary<Type, UserControl> _views = [];

        public MainDentalForm()
        {
            InitializeComponent();

            string conn = ConfigurationManager
                .ConnectionStrings["DentalClinicDB"].ConnectionString;

            _patientService = new DBPatientService(conn);
            _dashboardService = new DBDashboardService(conn);
            _appointmentService = new DBAppointmentService(conn);
            _billingService = new DBBillingService(conn);

            ShowView(() => new DashboardView(_dashboardService));
        }

        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);

            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }

            pnlMainContent.Controls.Clear();
            pnlMainContent.Controls.Add(view);
            view.BringToFront();

            lblstatus.Text = $"Section: {typeof(T).Name.Replace("View", "")}  |  {DateTime.Now:dd MMM yyyy  HH:mm}";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            _views.Remove(typeof(DashboardView));
            ShowView(() => new DashboardView(_dashboardService));
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            ShowView(() => new PatientView(_patientService));
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
          
            _views.Remove(typeof(AppointmentView));
            ShowView(() => new AppointmentView(_appointmentService, _patientService, _billingService));
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            
            _views.Remove(typeof(BillingView));
            ShowView(() => new BillingView(_billingService));
        }
    }
}