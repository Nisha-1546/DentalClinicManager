namespace DentalClinicManager.Views
{
    partial class PatientView
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
            tsPatient = new System.Windows.Forms.ToolStrip();
            tsbAdd = new System.Windows.Forms.ToolStripButton();
            tsbEdit = new System.Windows.Forms.ToolStripButton();
            tsbView = new System.Windows.Forms.ToolStripButton();
            tsbDelete = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbRefresh = new System.Windows.Forms.ToolStripButton();
            panelSearch = new System.Windows.Forms.Panel();
            flpSearch = new System.Windows.Forms.FlowLayoutPanel();
            lblSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lblCount = new System.Windows.Forms.Label();
            dgvPatients = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();

            tlpMain.SuspendLayout();
            tsPatient.SuspendLayout();
            panelSearch.SuspendLayout();
            flpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();

            // ── tlpMain ───────────────────────────────────────────────
            tlpMain.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.Controls.Add(tsPatient, 0, 0);
            tlpMain.Controls.Add(panelSearch, 0, 1);
            tlpMain.Controls.Add(dgvPatients, 0, 2);
            tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpMain.Location = new System.Drawing.Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpMain.Size = new System.Drawing.Size(660, 401);
            tlpMain.TabIndex = 0;

            // ── tsPatient (toolbar) ───────────────────────────────────
            tsPatient.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            tsPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            tsPatient.ForeColor = System.Drawing.Color.White;
            tsPatient.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tsPatient.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh
            });
            tsPatient.Location = new System.Drawing.Point(0, 0);
            tsPatient.Name = "tsPatient";
            tsPatient.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tsPatient.Size = new System.Drawing.Size(660, 42);
            tsPatient.TabIndex = 0;
            tsPatient.Text = "tsPatient";

            // ── tsbAdd ────────────────────────────────────────────────
            tsbAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbAdd.ForeColor = System.Drawing.Color.White;
            tsbAdd.Image = Properties.Resources.ico_add;
            tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new System.Drawing.Size(54, 39);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;

            // ── tsbEdit ───────────────────────────────────────────────
            tsbEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbEdit.ForeColor = System.Drawing.Color.White;
            tsbEdit.Image = Properties.Resources.ico_edit;
            tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new System.Drawing.Size(52, 39);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;

            // ── tsbView ───────────────────────────────────────────────
            tsbView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbView.ForeColor = System.Drawing.Color.White;
            tsbView.Image = Properties.Resources.ico_View;
            tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new System.Drawing.Size(57, 39);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;

            // ── tsbDelete ─────────────────────────────────────────────
            tsbDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbDelete.ForeColor = System.Drawing.Color.FromArgb(255, 180, 180);
            tsbDelete.Image = Properties.Resources.ico_DeleteT;
            tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new System.Drawing.Size(65, 39);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;

            // ── toolStripSeparator1 ───────────────────────────────────
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 42);

            // ── tsbRefresh ────────────────────────────────────────────
            tsbRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            tsbRefresh.ForeColor = System.Drawing.Color.White;
            tsbRefresh.Image = Properties.Resources.ico_Refresh;
            tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new System.Drawing.Size(72, 39);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;

            // ── panelSearch ───────────────────────────────────────────
            panelSearch.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            panelSearch.Controls.Add(flpSearch);
            panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new System.Drawing.Size(660, 46);
            panelSearch.TabIndex = 1;

            // ── flpSearch ─────────────────────────────────────────────
            flpSearch.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            flpSearch.Controls.Add(lblSearch);
            flpSearch.Controls.Add(txtSearch);
            flpSearch.Controls.Add(lblCount);
            flpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            flpSearch.Location = new System.Drawing.Point(0, 0);
            flpSearch.Name = "flpSearch";
            flpSearch.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            flpSearch.Size = new System.Drawing.Size(660, 46);
            flpSearch.TabIndex = 0;
            flpSearch.WrapContents = false;

            // ── lblSearch ─────────────────────────────────────────────
            lblSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblSearch.AutoSize = true;
            lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblSearch.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblSearch.Location = new System.Drawing.Point(11, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search";

            // ── txtSearch ─────────────────────────────────────────────
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtSearch.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtSearch.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtSearch.Location = new System.Drawing.Point(65, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(220, 24);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;

            // ── lblCount ──────────────────────────────────────────────
            lblCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblCount.AutoSize = true;
            lblCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblCount.ForeColor = System.Drawing.Color.FromArgb(41, 98, 146);
            lblCount.Location = new System.Drawing.Point(298, 15);
            lblCount.Name = "lblCount";
            lblCount.TabIndex = 4;
            lblCount.Text = "Total: 0";
            lblCount.Click += lblCount_Click;

            // ── dgvPatients ───────────────────────────────────────────
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.BackgroundColor = System.Drawing.Color.White;
            dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvPatients.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvPatients.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dgvPatients.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvPatients.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvPatients.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dgvPatients.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dgvPatients.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(219, 232, 245);
            dgvPatients.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dgvPatients.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                colId, colName, colPhone, colEmail, colAddress, colCreatedAt
            });
            dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPatients.EnableHeadersVisualStyles = false;
            dgvPatients.GridColor = System.Drawing.Color.FromArgb(220, 230, 240);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersVisible = false;
            dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.TabIndex = 2;

            // ── colId ─────────────────────────────────────────────────
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.FillWeight = 30F;

            // ── colName ───────────────────────────────────────────────
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.FillWeight = 120F;

            // ── colPhone ──────────────────────────────────────────────
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.FillWeight = 80F;

            // ── colEmail ──────────────────────────────────────────────
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.FillWeight = 120F;

            // ── colAddress ────────────────────────────────────────────
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            colAddress.FillWeight = 120F;

            // ── colCreatedAt ──────────────────────────────────────────
            colCreatedAt.DataPropertyName = "CreatedAt";
            colCreatedAt.HeaderText = "Created At";
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            colCreatedAt.FillWeight = 80F;

            // ── PatientView ───────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            Controls.Add(tlpMain);
            Name = "PatientView";
            Size = new System.Drawing.Size(660, 401);

            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tsPatient.ResumeLayout(false);
            tsPatient.PerformLayout();
            panelSearch.ResumeLayout(false);
            flpSearch.ResumeLayout(false);
            flpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ToolStrip tsPatient;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.FlowLayoutPanel flpSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
    }
}