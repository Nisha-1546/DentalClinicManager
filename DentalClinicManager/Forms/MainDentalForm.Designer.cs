namespace DentalClinicManager.Forms
{
    partial class MainDentalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new System.Windows.Forms.Panel();
            pnlRight = new System.Windows.Forms.Panel();
            pbAdmin = new System.Windows.Forms.PictureBox();
            lblUser = new System.Windows.Forms.Label();
            pnlLeft = new System.Windows.Forms.Panel();
            pbLogo = new System.Windows.Forms.PictureBox();
            lblMainHeading = new System.Windows.Forms.Label();
            pnlSideBar = new System.Windows.Forms.Panel();
            flpSidebar = new System.Windows.Forms.FlowLayoutPanel();
            btnDashboard = new System.Windows.Forms.Button();
            btnPatients = new System.Windows.Forms.Button();
            btnAppointments = new System.Windows.Forms.Button();
            btnBilling = new System.Windows.Forms.Button();
            pnlMainContent = new System.Windows.Forms.Panel();
            tspBottom = new System.Windows.Forms.ToolStrip();
            lblstatus = new System.Windows.Forms.ToolStripLabel();

            pnlHeader.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).BeginInit();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlSideBar.SuspendLayout();
            flpSidebar.SuspendLayout();
            tspBottom.SuspendLayout();
            SuspendLayout();

            // ── pnlHeader ─────────────────────────────────────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            pnlHeader.Controls.Add(pnlRight);
            pnlHeader.Controls.Add(pnlLeft);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1100, 60);
            pnlHeader.TabIndex = 0;

            // ── pnlRight ──────────────────────────────────────────────
            pnlRight.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            pnlRight.Controls.Add(pbAdmin);
            pnlRight.Controls.Add(lblUser);
            pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(140, 60);
            pnlRight.TabIndex = 1;

            // ── pbAdmin ───────────────────────────────────────────────
            pbAdmin.Image = Properties.Resources.ico_user;
            pbAdmin.Location = new System.Drawing.Point(10, 10);
            pbAdmin.Name = "pbAdmin";
            pbAdmin.Size = new System.Drawing.Size(38, 38);
            pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbAdmin.TabIndex = 1;
            pbAdmin.TabStop = false;

            // ── lblUser ───────────────────────────────────────────────
            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblUser.ForeColor = System.Drawing.Color.White;
            lblUser.Location = new System.Drawing.Point(54, 22);
            lblUser.Name = "lblUser";
            lblUser.TabIndex = 0;
            lblUser.Text = "Admin";

            // ── pnlLeft ───────────────────────────────────────────────
            pnlLeft.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            pnlLeft.Controls.Add(pbLogo);
            pnlLeft.Controls.Add(lblMainHeading);
            pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new System.Drawing.Size(430, 60);
            pnlLeft.TabIndex = 0;

            // ── pbLogo ────────────────────────────────────────────────
            pbLogo.Image = Properties.Resources.ico_Logo;
            pbLogo.Location = new System.Drawing.Point(14, 10);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(38, 38);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;

            // ── lblMainHeading ────────────────────────────────────────
            lblMainHeading.AutoSize = true;
            lblMainHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblMainHeading.ForeColor = System.Drawing.Color.White;
            lblMainHeading.Location = new System.Drawing.Point(58, 16);
            lblMainHeading.Name = "lblMainHeading";
            lblMainHeading.TabIndex = 0;
            lblMainHeading.Text = "Dental Clinic Management System";

            // ── pnlSideBar ────────────────────────────────────────────
            pnlSideBar.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            pnlSideBar.Controls.Add(flpSidebar);
            pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new System.Drawing.Size(210, 480);
            pnlSideBar.TabIndex = 1;

            // ── flpSidebar ────────────────────────────────────────────
            flpSidebar.AutoScroll = true;
            flpSidebar.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            flpSidebar.Controls.Add(btnDashboard);
            flpSidebar.Controls.Add(btnPatients);
            flpSidebar.Controls.Add(btnAppointments);
            flpSidebar.Controls.Add(btnBilling);
            flpSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            flpSidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpSidebar.Location = new System.Drawing.Point(0, 0);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            flpSidebar.TabIndex = 4;
            flpSidebar.WrapContents = false;

            // ── btnDashboard ──────────────────────────────────────────
            btnDashboard.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(219, 232, 245);
            btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            btnDashboard.Image = Properties.Resources.ico_Dashboard;
            btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            btnDashboard.Size = new System.Drawing.Size(192, 46);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "  Dashboard";
            btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDashboard.Click += btnDashboard_Click;

            // ── btnPatients ───────────────────────────────────────────
            btnPatients.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            btnPatients.FlatAppearance.BorderSize = 0;
            btnPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(219, 232, 245);
            btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPatients.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnPatients.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            btnPatients.Image = Properties.Resources.ico_Patients;
            btnPatients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPatients.Name = "btnPatients";
            btnPatients.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            btnPatients.Size = new System.Drawing.Size(192, 46);
            btnPatients.TabIndex = 1;
            btnPatients.Text = "  Patients";
            btnPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Cursor = System.Windows.Forms.Cursors.Hand;
            btnPatients.Click += btnPatients_Click;

            // ── btnAppointments ───────────────────────────────────────
            btnAppointments.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            btnAppointments.FlatAppearance.BorderSize = 0;
            btnAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(219, 232, 245);
            btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAppointments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnAppointments.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            btnAppointments.Image = Properties.Resources.ico_Appointments;
            btnAppointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            btnAppointments.Size = new System.Drawing.Size(192, 46);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "  Appointments";
            btnAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAppointments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAppointments.Click += btnAppointments_Click;

            // ── btnBilling ────────────────────────────────────────────
            btnBilling.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(219, 232, 245);
            btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBilling.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnBilling.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            btnBilling.Image = Properties.Resources.ico_Billings;
            btnBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBilling.Name = "btnBilling";
            btnBilling.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            btnBilling.Size = new System.Drawing.Size(192, 46);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "  Billing";
            btnBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnBilling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnBilling.UseVisualStyleBackColor = false;
            btnBilling.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBilling.Click += btnBilling_Click;

            // ── pnlMainContent ────────────────────────────────────────
            pnlMainContent.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new System.Windows.Forms.Padding(10);
            pnlMainContent.TabIndex = 2;

            // ── tspBottom ─────────────────────────────────────────────
            tspBottom.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            tspBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            tspBottom.ForeColor = System.Drawing.Color.White;
            tspBottom.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tspBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblstatus });
            tspBottom.Name = "tspBottom";
            tspBottom.Size = new System.Drawing.Size(1100, 26);
            tspBottom.TabIndex = 3;
            tspBottom.Text = "tspBottom";

            // ── lblstatus ─────────────────────────────────────────────
            lblstatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblstatus.ForeColor = System.Drawing.Color.White;
            lblstatus.Name = "lblstatus";
            lblstatus.Text = "Ready";

            // ── MainDentalForm ────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            ClientSize = new System.Drawing.Size(1100, 620);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSideBar);
            Controls.Add(tspBottom);
            Controls.Add(pnlHeader);
            MinimumSize = new System.Drawing.Size(900, 550);
            Name = "MainDentalForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dental Clinic Management System";

            pnlHeader.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAdmin).EndInit();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlSideBar.ResumeLayout(false);
            flpSidebar.ResumeLayout(false);
            tspBottom.ResumeLayout(false);
            tspBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox pbAdmin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.FlowLayoutPanel flpSidebar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.ToolStrip tspBottom;
        private System.Windows.Forms.ToolStripLabel lblstatus;
    }
}