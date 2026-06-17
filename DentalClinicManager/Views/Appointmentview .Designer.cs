namespace DentalClinicManager.Views
{
    partial class AppointmentView
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
            tlpMain = new System.Windows.Forms.TableLayoutPanel();
            tsAppointment = new System.Windows.Forms.ToolStrip();
            tsbAdd = new System.Windows.Forms.ToolStripButton();
            tsbEdit = new System.Windows.Forms.ToolStripButton();
            tsbView = new System.Windows.Forms.ToolStripButton();
            tsbDelete = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbComplete = new System.Windows.Forms.ToolStripButton();
            tsbCancel = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbRefresh = new System.Windows.Forms.ToolStripButton();
            panelSearch = new System.Windows.Forms.Panel();
            flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lblStatusFilter = new System.Windows.Forms.Label();
            cmbStatusFilter = new System.Windows.Forms.ComboBox();
            lblCount = new System.Windows.Forms.Label();
            dgvAppointments = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();

            tlpMain.SuspendLayout();
            tsAppointment.SuspendLayout();
            panelSearch.SuspendLayout();
            flpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();

            // ── tlpMain ───────────────────────────────────────────────
            tlpMain.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.Controls.Add(tsAppointment, 0, 0);
            tlpMain.Controls.Add(panelSearch, 0, 1);
            tlpMain.Controls.Add(dgvAppointments, 0, 2);
            tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.Size = new System.Drawing.Size(860, 520);
            tlpMain.TabIndex = 0;

            // ── tsAppointment (toolbar) ───────────────────────────────
            tsAppointment.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            tsAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            tsAppointment.ForeColor = System.Drawing.Color.White;
            tsAppointment.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tsAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                tsbAdd, tsbEdit, tsbView, tsbDelete,
                toolStripSeparator1,
                tsbComplete, tsbCancel,
                toolStripSeparator2,
                tsbRefresh
            });
            tsAppointment.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tsAppointment.Size = new System.Drawing.Size(860, 42);
            tsAppointment.Name = "tsAppointment";

            // ── tsbAdd ────────────────────────────────────────────────
            tsbAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbAdd.ForeColor = System.Drawing.Color.White;
            tsbAdd.Image = Properties.Resources.ico_add;
            tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;

            // ── tsbEdit ───────────────────────────────────────────────
            tsbEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbEdit.ForeColor = System.Drawing.Color.White;
            tsbEdit.Image = Properties.Resources.ico_edit;
            tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;

            // ── tsbView ───────────────────────────────────────────────
            tsbView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbView.ForeColor = System.Drawing.Color.White;
            tsbView.Image = Properties.Resources.ico_View;
            tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;

            // ── tsbDelete ─────────────────────────────────────────────
            tsbDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbDelete.ForeColor = System.Drawing.Color.FromArgb(255, 180, 180);
            tsbDelete.Image = Properties.Resources.ico_DeleteT;
            tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;

            // ── toolStripSeparator1 ───────────────────────────────────
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 42);

            // ── tsbComplete ───────────────────────────────────────────
            tsbComplete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbComplete.ForeColor = System.Drawing.Color.FromArgb(180, 255, 180);
            tsbComplete.Name = "tsbComplete";
            tsbComplete.Text = "✔ Complete";
            tsbComplete.Click += tsbComplete_Click;

            // ── tsbCancel ─────────────────────────────────────────────
            tsbCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbCancel.ForeColor = System.Drawing.Color.FromArgb(255, 220, 150);
            tsbCancel.Name = "tsbCancel";
            tsbCancel.Text = "✖ Cancel Appt";
            tsbCancel.Click += tsbCancel_Click;

            // ── toolStripSeparator2 ───────────────────────────────────
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 42);

            // ── tsbRefresh ────────────────────────────────────────────
            tsbRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbRefresh.ForeColor = System.Drawing.Color.White;
            tsbRefresh.Image = Properties.Resources.ico_Refresh;
            tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;

            // ── panelSearch ───────────────────────────────────────────
            panelSearch.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            panelSearch.Controls.Add(flpSearch);
            panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            panelSearch.Name = "panelSearch";

            // ── flpSearch ─────────────────────────────────────────────
            flpSearch.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            flpSearch.Controls.Add(lblSearch);
            flpSearch.Controls.Add(txtSearch);
            flpSearch.Controls.Add(lblStatusFilter);
            flpSearch.Controls.Add(cmbStatusFilter);
            flpSearch.Controls.Add(lblCount);
            flpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            flpSearch.Name = "flpSearch";
            flpSearch.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            flpSearch.WrapContents = false;

            // ── lblSearch ─────────────────────────────────────────────
            lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblSearch.Location = new System.Drawing.Point(11, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Text = "Search";

            // ── txtSearch ─────────────────────────────────────────────
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtSearch.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtSearch.Location = new System.Drawing.Point(65, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(220, 24);
            txtSearch.TextChanged += txtSearch_TextChanged;

            // ── lblStatusFilter ───────────────────────────────────────
            lblStatusFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblStatusFilter.Location = new System.Drawing.Point(298, 15);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Text = "Status";

            // ── cmbStatusFilter ───────────────────────────────────────
            cmbStatusFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cmbStatusFilter.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cmbStatusFilter.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cmbStatusFilter.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Cancelled" });
            cmbStatusFilter.Location = new System.Drawing.Point(354, 10);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new System.Drawing.Size(115, 25);
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;

            // ── lblCount ──────────────────────────────────────────────
            lblCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCount.ForeColor = System.Drawing.Color.FromArgb(41, 98, 146);
            lblCount.Location = new System.Drawing.Point(482, 15);
            lblCount.Name = "lblCount";
            lblCount.Text = "Total: 0";
            lblCount.Click += lblCount_Click;

            // ── dgvAppointments ───────────────────────────────────────
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvAppointments.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvAppointments.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dgvAppointments.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvAppointments.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvAppointments.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dgvAppointments.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgvAppointments.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 232, 245);
            dgvAppointments.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvAppointments.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                colId, colPatient, colDoctor, colDate, colTime, colTreatment, colCost, colStatus
            });
            dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvAppointments.EnableHeadersVisualStyles = false;
            dgvAppointments.GridColor = System.Drawing.Color.FromArgb(220, 230, 240);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.TabIndex = 2;
            dgvAppointments.ColumnHeaderMouseClick += dgvAppointments_ColumnHeaderMouseClick;

            // ── Columns ───────────────────────────────────────────────
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.FillWeight = 30F;

            colPatient.DataPropertyName = "PatientName";
            colPatient.HeaderText = "Patient";
            colPatient.Name = "colPatient";
            colPatient.ReadOnly = true;
            colPatient.FillWeight = 100F;

            colDoctor.DataPropertyName = "Doctor";
            colDoctor.HeaderText = "Doctor";
            colDoctor.Name = "colDoctor";
            colDoctor.ReadOnly = true;
            colDoctor.FillWeight = 100F;

            colDate.DataPropertyName = "AppDate";
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.DefaultCellStyle.Format = "dd MMM yyyy";
            colDate.FillWeight = 80F;

            colTime.DataPropertyName = "AppTime";
            colTime.HeaderText = "Time";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            colTime.FillWeight = 60F;

            colTreatment.DataPropertyName = "Treatment";
            colTreatment.HeaderText = "Treatment";
            colTreatment.Name = "colTreatment";
            colTreatment.ReadOnly = true;
            colTreatment.FillWeight = 120F;

            colCost.DataPropertyName = "Cost";
            colCost.HeaderText = "Cost (Rs.)";
            colCost.Name = "colCost";
            colCost.ReadOnly = true;
            colCost.DefaultCellStyle.Format = "N2";
            colCost.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            colCost.FillWeight = 70F;

            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.FillWeight = 70F;

            // ── AppointmentView ───────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            Controls.Add(tlpMain);
            Name = "AppointmentView";
            Size = new System.Drawing.Size(860, 520);

            tlpMain.ResumeLayout(false);
            tsAppointment.ResumeLayout(false);
            tsAppointment.PerformLayout();
            panelSearch.ResumeLayout(false);
            flpSearch.ResumeLayout(false);
            flpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ToolStrip tsAppointment;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbComplete;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
