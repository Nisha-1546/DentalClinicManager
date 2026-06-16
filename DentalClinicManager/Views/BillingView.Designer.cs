namespace DentalClinicManager.Views
{
    partial class BillingView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tspToolbar = new System.Windows.Forms.ToolStrip();
            tsbPaid = new System.Windows.Forms.ToolStripButton();
            tsbUnpaid = new System.Windows.Forms.ToolStripButton();
            tsbSep1 = new System.Windows.Forms.ToolStripSeparator();
            tsbDelete = new System.Windows.Forms.ToolStripButton();
            tsbSep2 = new System.Windows.Forms.ToolStripSeparator();
            tsbRefresh = new System.Windows.Forms.ToolStripButton();
            pnlSearch = new System.Windows.Forms.Panel();
            txtSearch = new System.Windows.Forms.TextBox();
            lblCount = new System.Windows.Forms.Label();
            dgvBills = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAppId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();

            tspToolbar.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            SuspendLayout();

            // ── tspToolbar ────────────────────────────────────────────
            tspToolbar.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            tspToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tspToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                tsbPaid, tsbUnpaid, tsbSep1, tsbDelete, tsbSep2, tsbRefresh
            });
            tspToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            tspToolbar.Name = "tspToolbar";
            tspToolbar.Size = new System.Drawing.Size(900, 40);
            tspToolbar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);

            // ── tsbPaid ───────────────────────────────────────────────
            tsbPaid.Image = Properties.Resources.ico_Save;
            tsbPaid.Text = "Mark Paid";
            tsbPaid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            tsbPaid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbPaid.Name = "tsbPaid";
            tsbPaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            tsbPaid.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            tsbPaid.Click += tsbPaid_Click;

            // ── tsbUnpaid ─────────────────────────────────────────────
            tsbUnpaid.Image = Properties.Resources.ico_DeleteT;
            tsbUnpaid.Text = "Mark Unpaid";
            tsbUnpaid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            tsbUnpaid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbUnpaid.Name = "tsbUnpaid";
            tsbUnpaid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            tsbUnpaid.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            tsbUnpaid.Click += tsbUnpaid_Click;

            // ── tsbSep1 ───────────────────────────────────────────────
            tsbSep1.Name = "tsbSep1";

            // ── tsbDelete ─────────────────────────────────────────────
            tsbDelete.Image = Properties.Resources.ico_Delete;
            tsbDelete.Text = "Delete";
            tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            tsbDelete.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            tsbDelete.Click += tsbDelete_Click;

            // ── tsbSep2 ───────────────────────────────────────────────
            tsbSep2.Name = "tsbSep2";

            // ── tsbRefresh ────────────────────────────────────────────
            tsbRefresh.Image = Properties.Resources.ico_Refresh;
            tsbRefresh.Text = "Refresh";
            tsbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            tsbRefresh.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            tsbRefresh.Click += tsbRefresh_Click;

            // ── pnlSearch ─────────────────────────────────────────────
            pnlSearch.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblCount);
            pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new System.Drawing.Size(900, 40);
            pnlSearch.Padding = new System.Windows.Forms.Padding(4, 6, 4, 4);

            // ── txtSearch ─────────────────────────────────────────────
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtSearch.Location = new System.Drawing.Point(8, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by patient, treatment, doctor or status...";
            txtSearch.Size = new System.Drawing.Size(320, 24);
            txtSearch.TextChanged += txtSearch_TextChanged;

            // ── lblCount ──────────────────────────────────────────────
            lblCount.AutoSize = true;
            lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblCount.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblCount.Location = new System.Drawing.Point(340, 12);
            lblCount.Name = "lblCount";
            lblCount.Text = "Total: 0";
            lblCount.Click += lblCount_Click;

            // ── dgvBills ──────────────────────────────────────────────
            dgvBills.AllowUserToAddRows = false;
            dgvBills.AllowUserToDeleteRows = false;
            dgvBills.ReadOnly = true;
            dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvBills.MultiSelect = false;
            dgvBills.BackgroundColor = System.Drawing.Color.White;
            dgvBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvBills.RowHeadersVisible = false;
            dgvBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvBills.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvBills.Name = "dgvBills";
            dgvBills.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvBills.GridColor = System.Drawing.Color.FromArgb(220, 230, 240);
            dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBills.ColumnHeadersHeight = 36;
            dgvBills.RowTemplate.Height = 32;

            dgvBills.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvBills.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvBills.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvBills.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvBills.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 228, 245);
            dgvBills.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvBills.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);

            // ── columns ───────────────────────────────────────────────
            colId.HeaderText = "ID";
            colId.DataPropertyName = "Id";
            colId.FillWeight = 40;
            colId.Name = "colId";

            colAppId.HeaderText = "Appt #";
            colAppId.DataPropertyName = "AppointmentId";
            colAppId.FillWeight = 60;
            colAppId.Name = "colAppId";

            colPatient.HeaderText = "Patient";
            colPatient.DataPropertyName = "PatientName";
            colPatient.FillWeight = 160;
            colPatient.Name = "colPatient";

            colTreatment.HeaderText = "Treatment";
            colTreatment.DataPropertyName = "Treatment";
            colTreatment.FillWeight = 180;
            colTreatment.Name = "colTreatment";

            colDoctor.HeaderText = "Doctor";
            colDoctor.DataPropertyName = "Doctor";
            colDoctor.FillWeight = 130;
            colDoctor.Name = "colDoctor";

            colAmount.HeaderText = "Amount (Rs)";
            colAmount.DataPropertyName = "Amount";
            colAmount.FillWeight = 100;
            colAmount.Name = "colAmount";
            colAmount.DefaultCellStyle.Format = "N0";

            colStatus.HeaderText = "Status";
            colStatus.DataPropertyName = "Status";
            colStatus.FillWeight = 80;
            colStatus.Name = "colStatus";

            colDate.HeaderText = "Bill Date";
            colDate.DataPropertyName = "BillDate";
            colDate.FillWeight = 110;
            colDate.Name = "colDate";
            colDate.DefaultCellStyle.Format = "dd MMM yyyy";

            dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                colId, colAppId, colPatient, colTreatment, colDoctor, colAmount, colStatus, colDate
            });

            // ── BillingView ───────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(dgvBills);
            Controls.Add(pnlSearch);
            Controls.Add(tspToolbar);
            Name = "BillingView";
            Size = new System.Drawing.Size(900, 560);

            tspToolbar.ResumeLayout(false);
            tspToolbar.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ToolStrip tspToolbar;
        private System.Windows.Forms.ToolStripButton tsbPaid;
        private System.Windows.Forms.ToolStripButton tsbUnpaid;
        private System.Windows.Forms.ToolStripSeparator tsbSep1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator tsbSep2;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAppId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
    }
}