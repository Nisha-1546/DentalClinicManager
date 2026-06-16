using System.Windows.Forms.DataVisualization.Charting;


namespace DentalClinicManager.Views
{
    partial class DashboardView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            pnlTop = new System.Windows.Forms.Panel();
            lblDashTitle = new System.Windows.Forms.Label();

            // Stat card panels
            pnlTotal = new System.Windows.Forms.Panel();
            lblTotalTitle = new System.Windows.Forms.Label();
            lblTotalValue = new System.Windows.Forms.Label();
            lblTotalIcon = new System.Windows.Forms.Label();

            pnlMonth = new System.Windows.Forms.Panel();
            lblMonthTitle = new System.Windows.Forms.Label();
            lblMonthValue = new System.Windows.Forms.Label();
            lblMonthIcon = new System.Windows.Forms.Label();

            pnlWeek = new System.Windows.Forms.Panel();
            lblWeekTitle = new System.Windows.Forms.Label();
            lblWeekValue = new System.Windows.Forms.Label();
            lblWeekIcon = new System.Windows.Forms.Label();

            pnlToday = new System.Windows.Forms.Panel();
            lblTodayTitle = new System.Windows.Forms.Label();
            lblTodayValue = new System.Windows.Forms.Label();
            lblTodayIcon = new System.Windows.Forms.Label();

            flpCards = new System.Windows.Forms.FlowLayoutPanel();
            pnlChart = new System.Windows.Forms.Panel();
            lblChartTitle = new System.Windows.Forms.Label();
            chartPatients = new Chart();
            chartArea1 = new ChartArea();

            pnlTop.SuspendLayout();
            flpCards.SuspendLayout();
            pnlTotal.SuspendLayout();
            pnlMonth.SuspendLayout();
            pnlWeek.SuspendLayout();
            pnlToday.SuspendLayout();
            pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPatients).BeginInit();
            SuspendLayout();

            // ── UserControl ───────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            Size = new System.Drawing.Size(860, 580);
            Name = "DashboardView";
            Controls.Add(pnlChart);
            Controls.Add(flpCards);
            Controls.Add(pnlTop);

            // ── pnlTop (header) ───────────────────────────────────────
            pnlTop.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTop.Height = 52;
            pnlTop.Name = "pnlTop";
            pnlTop.Controls.Add(lblDashTitle);

            lblDashTitle.AutoSize = false;
            lblDashTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDashTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDashTitle.ForeColor = System.Drawing.Color.White;
            lblDashTitle.Name = "lblDashTitle";
            lblDashTitle.Text = "  Dashboard — Patient Overview";
            lblDashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── flpCards (stat cards row) ─────────────────────────────
            flpCards.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            flpCards.Dock = System.Windows.Forms.DockStyle.Top;
            flpCards.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flpCards.Height = 130;
            flpCards.Name = "flpCards";
            flpCards.Padding = new System.Windows.Forms.Padding(16, 14, 16, 0);
            flpCards.WrapContents = false;
            flpCards.Controls.Add(pnlTotal);
            flpCards.Controls.Add(pnlMonth);
            flpCards.Controls.Add(pnlWeek);
            flpCards.Controls.Add(pnlToday);

            // ── Helper: BuildCard ─────────────────────────────────────
            void BuildCard(System.Windows.Forms.Panel card,
                           System.Windows.Forms.Label icon,
                           System.Windows.Forms.Label title,
                           System.Windows.Forms.Label value,
                           string iconText, string titleText,
                           System.Drawing.Color accent)
            {
                card.BackColor = System.Drawing.Color.White;
                card.Size = new System.Drawing.Size(178, 96);
                card.Margin = new System.Windows.Forms.Padding(0, 0, 14, 0);
                card.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
                card.Controls.Add(icon);
                card.Controls.Add(title);
                card.Controls.Add(value);

                icon.AutoSize = true;
                icon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                icon.ForeColor = accent;
                icon.Location = new System.Drawing.Point(130, 28);
                icon.Text = iconText;

                title.AutoSize = true;
                title.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                title.ForeColor = System.Drawing.Color.FromArgb(100, 100, 110);
                title.Location = new System.Drawing.Point(14, 14);
                title.Text = titleText;

                value.AutoSize = false;
                value.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
                value.ForeColor = accent;
                value.Location = new System.Drawing.Point(14, 34);
                value.Size = new System.Drawing.Size(110, 46);
                value.Text = "0";
            }

            BuildCard(pnlTotal, lblTotalIcon, lblTotalTitle, lblTotalValue,
                      "👥", "Total Patients",
                      System.Drawing.Color.FromArgb(27, 58, 87));

            BuildCard(pnlMonth, lblMonthIcon, lblMonthTitle, lblMonthValue,
                      "📅", "This Month",
                      System.Drawing.Color.FromArgb(41, 98, 146));

            BuildCard(pnlWeek, lblWeekIcon, lblWeekTitle, lblWeekValue,
                      "📆", "This Week",
                      System.Drawing.Color.FromArgb(22, 130, 110));

            BuildCard(pnlToday, lblTodayIcon, lblTodayTitle, lblTodayValue,
                      "🕐", "Today",
                      System.Drawing.Color.FromArgb(180, 90, 30));

            // ── pnlChart ──────────────────────────────────────────────
            pnlChart.BackColor = System.Drawing.Color.White;
            pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlChart.Margin = new System.Windows.Forms.Padding(16, 12, 16, 16);
            pnlChart.Name = "pnlChart";
            pnlChart.Padding = new System.Windows.Forms.Padding(16, 10, 16, 16);
            pnlChart.Controls.Add(chartPatients);
            pnlChart.Controls.Add(lblChartTitle);

            lblChartTitle.AutoSize = false;
            lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblChartTitle.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblChartTitle.Height = 36;
            lblChartTitle.Name = "lblChartTitle";
            lblChartTitle.Text = "  Patients Registered — Last 6 Months";
            lblChartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── chartPatients ─────────────────────────────────────────
            chartArea1.Name = "ChartArea1";
            chartPatients.ChartAreas.Add(chartArea1);
            chartPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            chartPatients.Name = "chartPatients";
            chartPatients.TabIndex = 0;
            chartPatients.BackColor = System.Drawing.Color.White;

            pnlTop.ResumeLayout(false);
            flpCards.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            pnlMonth.ResumeLayout(false);
            pnlMonth.PerformLayout();
            pnlWeek.ResumeLayout(false);
            pnlWeek.PerformLayout();
            pnlToday.ResumeLayout(false);
            pnlToday.PerformLayout();
            pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblDashTitle;
        private System.Windows.Forms.FlowLayoutPanel flpCards;

        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotalIcon;

        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.Label lblMonthValue;
        private System.Windows.Forms.Label lblMonthIcon;

        private System.Windows.Forms.Panel pnlWeek;
        private System.Windows.Forms.Label lblWeekTitle;
        private System.Windows.Forms.Label lblWeekValue;
        private System.Windows.Forms.Label lblWeekIcon;

        private System.Windows.Forms.Panel pnlToday;
        private System.Windows.Forms.Label lblTodayTitle;
        private System.Windows.Forms.Label lblTodayValue;
        private System.Windows.Forms.Label lblTodayIcon;

        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Label lblChartTitle;
        private Chart chartPatients;
        private ChartArea chartArea1;
    }
}