namespace DentalClinicManager.Forms
{
    partial class PatientForm
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
            lblTitle = new System.Windows.Forms.Label();
            tlpPatient = new System.Windows.Forms.TableLayoutPanel();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblPhone = new System.Windows.Forms.Label();
            txtPhone = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblAddress = new System.Windows.Forms.Label();
            txtAddress = new System.Windows.Forms.TextBox();
            pnlButtons = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            tlpPatient.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();

            // ── lblTitle (header banner) ──────────────────────────────
            lblTitle.AutoSize = false;
            lblTitle.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(460, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "  Patient Details";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── tlpPatient ────────────────────────────────────────────
            tlpPatient.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            tlpPatient.ColumnCount = 2;
            tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            tlpPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPatient.Controls.Add(lblName, 0, 0);
            tlpPatient.Controls.Add(txtName, 1, 0);
            tlpPatient.Controls.Add(lblPhone, 0, 1);
            tlpPatient.Controls.Add(txtPhone, 1, 1);
            tlpPatient.Controls.Add(lblEmail, 0, 2);
            tlpPatient.Controls.Add(txtEmail, 1, 2);
            tlpPatient.Controls.Add(lblAddress, 0, 3);
            tlpPatient.Controls.Add(txtAddress, 1, 3);
            tlpPatient.Controls.Add(pnlButtons, 1, 4);
            tlpPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpPatient.Location = new System.Drawing.Point(0, 50);
            tlpPatient.Name = "tlpPatient";
            tlpPatient.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            tlpPatient.RowCount = 5;
            tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tlpPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpPatient.TabIndex = 1;

            // ── lblName ───────────────────────────────────────────────
            lblName.AutoSize = false;
            lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblName.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblName.Name = "lblName";
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── txtName ───────────────────────────────────────────────
            txtName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtName.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtName.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(320, 26);
            txtName.TabIndex = 1;

            // ── lblPhone ──────────────────────────────────────────────
            lblPhone.AutoSize = false;
            lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPhone.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblPhone.Name = "lblPhone";
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── txtPhone ──────────────────────────────────────────────
            txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPhone.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPhone.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(320, 26);
            txtPhone.TabIndex = 3;

            // ── lblEmail ──────────────────────────────────────────────
            lblEmail.AutoSize = false;
            lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── txtEmail ──────────────────────────────────────────────
            txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtEmail.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtEmail.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(320, 26);
            txtEmail.TabIndex = 5;

            // ── lblAddress ────────────────────────────────────────────
            lblAddress.AutoSize = false;
            lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblAddress.Name = "lblAddress";
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address";
            lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── txtAddress ────────────────────────────────────────────
            txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtAddress.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtAddress.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(320, 50);
            txtAddress.TabIndex = 7;

            // ── pnlButtons ────────────────────────────────────────────
            pnlButtons.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlButtons.Name = "pnlButtons";
            pnlButtons.TabIndex = 8;

            // ── btnSave ───────────────────────────────────────────────
            btnSave.BackColor = System.Drawing.Color.FromArgb(41, 98, 146);
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Image = Properties.Resources.ico_Save;
            btnSave.Location = new System.Drawing.Point(80, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(100, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "  Save";
            btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.Click += btnSave_Click;

            // ── btnCancel ─────────────────────────────────────────────
            btnCancel.BackColor = System.Drawing.Color.FromArgb(180, 60, 60);
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Image = Properties.Resources.ico_Delete;
            btnCancel.Location = new System.Drawing.Point(192, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 36);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "  Cancel";
            btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.Click += btnCancel_Click;

            // ── PatientForm ───────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            ClientSize = new System.Drawing.Size(460, 370);
            Controls.Add(tlpPatient);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PatientForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Patient Details";

            tlpPatient.ResumeLayout(false);
            tlpPatient.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tlpPatient;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}