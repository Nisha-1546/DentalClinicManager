using DentalApp.core.Contracts;
using System.Windows.Forms.DataVisualization.Charting;

namespace DentalClinicManager.Views
{
    public partial class DashboardView : UserControl
    {
        private readonly IDashboardService _dashboardService;

        public DashboardView(IDashboardService service)
        {
            InitializeComponent();
            _dashboardService = service;
            LoadDashboard();
        }

      
        private void LoadDashboard()
        {
            LoadStatCards();
            LoadBarChart();
        }

        
        private void LoadStatCards()
        {
            lblTotalValue.Text = _dashboardService.GetTotalCount().ToString();
            lblMonthValue.Text = _dashboardService.GetCountThisMonth().ToString();
            lblWeekValue.Text = _dashboardService.GetCountThisWeek().ToString();
            lblTodayValue.Text = _dashboardService.GetCountToday().ToString();
        }

      
        private void LoadBarChart()
        {
            var data = _dashboardService.GetMonthlyCount(6);

            chartPatients.Series.Clear();
            chartPatients.ChartAreas[0].BackColor = System.Drawing.Color.White;
            chartPatients.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartPatients.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(220, 230, 240);
            chartPatients.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            chartPatients.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            chartPatients.ChartAreas[0].AxisY.Minimum = 0;
            chartPatients.ChartAreas[0].AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;

            var series = new Series("Patients")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.FromArgb(41, 98, 146),
                IsValueShownAsLabel = true,
                Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold),
                LabelForeColor = System.Drawing.Color.FromArgb(27, 58, 87),
                BorderWidth = 0,
            };

            foreach (var kvp in data)
            {
                series.Points.AddXY(kvp.Key, kvp.Value);
            }

            
            if (data.Count == 0)
                series.Points.AddXY("No Data", 0);

            chartPatients.Series.Add(series);
            chartPatients.Titles.Clear();
            chartPatients.BackColor = System.Drawing.Color.White;
            chartPatients.BorderlineColor = System.Drawing.Color.FromArgb(220, 230, 240);
        }
    }
}