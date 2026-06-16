namespace DentalClinicManager.Forms
{
    partial class AppointmentForm
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
            tlpForm = new System.Windows.Forms.TableLayoutPanel();
            pnlHeader = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            pnlBody = new System.Windows.Forms.Panel();
            lblPatient = new System.Windows.Forms.Label();
            cmbPatient = new System.Windows.Forms.ComboBox();
            lblDoctor = new System.Windows.Forms.Label();
            txtDoctor = new System.Windows.Forms.TextBox();
            lblDate = new System.Windows.Forms.Label();
            dtpDate = new System.Windows.Forms.DateTimePicker();
            lblTime = new System.Windows.Forms.Label();
            dtpTime = new System.Windows.Forms.DateTimePicker();
            lblTreatment = new System.Windows.Forms.Label();
            txtTreatment = new System.Windows.Forms.TextBox();
            lblCost = new System.Windows.Forms.Label();
            numCost = new System.Windows.Forms.NumericUpDown();
            lblStatus = new System.Windows.Forms.Label();
            cmbStatus = new System.Windows.Forms.ComboBox();
            lblNotes = new System.Windows.Forms.Label();
            txtNotes = new System.Windows.Forms.TextBox();
            pnlFooter = new System.Windows.Forms.Panel();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            tlpForm.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            SuspendLayout();

            // ── tlpForm ───────────────────────────────────────────────
            tlpForm.ColumnCount = 1;
            tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpForm.Controls.Add(pnlHeader, 0, 0);
            tlpForm.Controls.Add(pnlBody, 0, 1);
            tlpForm.Controls.Add(pnlFooter, 0, 2);
            tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpForm.Location = new System.Drawing.Point(0, 0);
            tlpForm.Name = "tlpForm";
            tlpForm.RowCount = 3;
            tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            tlpForm.Size = new System.Drawing.Size(460, 560);
            tlpForm.TabIndex = 0;

            // ── pnlHeader ─────────────────────────────────────────────
            pnlHeader.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(460, 52);
            pnlHeader.TabIndex = 0;

            // ── lblTitle ──────────────────────────────────────────────
            lblTitle.AutoSize = false;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(460, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "  Appointment Details";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── pnlBody ───────────────────────────────────────────────
            pnlBody.AutoScroll = true;
            pnlBody.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            pnlBody.Controls.Add(lblPatient);
            pnlBody.Controls.Add(cmbPatient);
            pnlBody.Controls.Add(lblDoctor);
            pnlBody.Controls.Add(txtDoctor);
            pnlBody.Controls.Add(lblDate);
            pnlBody.Controls.Add(dtpDate);
            pnlBody.Controls.Add(lblTime);
            pnlBody.Controls.Add(dtpTime);
            pnlBody.Controls.Add(lblTreatment);
            pnlBody.Controls.Add(txtTreatment);
            pnlBody.Controls.Add(lblCost);
            pnlBody.Controls.Add(numCost);
            pnlBody.Controls.Add(lblStatus);
            pnlBody.Controls.Add(cmbStatus);
            pnlBody.Controls.Add(lblNotes);
            pnlBody.Controls.Add(txtNotes);
            pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBody.Location = new System.Drawing.Point(0, 52);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new System.Windows.Forms.Padding(24, 16, 24, 8);
            pnlBody.Size = new System.Drawing.Size(460, 452);
            pnlBody.TabIndex = 1;

            // ── lblPatient ────────────────────────────────────────────
            lblPatient.AutoSize = false;
            lblPatient.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblPatient.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblPatient.Location = new System.Drawing.Point(24, 16);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new System.Drawing.Size(390, 18);
            lblPatient.TabIndex = 0;
            lblPatient.Text = "Patient *";

            // ── cmbPatient ────────────────────────────────────────────
            cmbPatient.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            cmbPatient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPatient.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cmbPatient.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cmbPatient.Location = new System.Drawing.Point(24, 38);
            cmbPatient.Name = "cmbPatient";
            cmbPatient.Size = new System.Drawing.Size(390, 28);
            cmbPatient.TabIndex = 1;

            // ── lblDoctor ─────────────────────────────────────────────
            lblDoctor.AutoSize = false;
            lblDoctor.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblDoctor.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblDoctor.Location = new System.Drawing.Point(24, 74);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new System.Drawing.Size(390, 18);
            lblDoctor.TabIndex = 2;
            lblDoctor.Text = "Doctor *";

            // ── txtDoctor ─────────────────────────────────────────────
            txtDoctor.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            txtDoctor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDoctor.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtDoctor.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtDoctor.Location = new System.Drawing.Point(24, 94);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new System.Drawing.Size(390, 28);
            txtDoctor.TabIndex = 3;

            // ── lblDate ───────────────────────────────────────────────
            lblDate.AutoSize = false;
            lblDate.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblDate.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblDate.Location = new System.Drawing.Point(24, 130);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(185, 18);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date *";

            // ── lblTime ───────────────────────────────────────────────
            lblTime.AutoSize = false;
            lblTime.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTime.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblTime.Location = new System.Drawing.Point(224, 130);
            lblTime.Name = "lblTime";
            lblTime.Size = new System.Drawing.Size(185, 18);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time *";

            // ── dtpDate ───────────────────────────────────────────────
            dtpDate.CalendarForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            dtpDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDate.Location = new System.Drawing.Point(24, 152);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new System.Drawing.Size(185, 28);
            dtpDate.TabIndex = 6;

            // ── dtpTime ───────────────────────────────────────────────
            dtpTime.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpTime.Location = new System.Drawing.Point(224, 152);
            dtpTime.Name = "dtpTime";
            dtpTime.ShowUpDown = true;
            dtpTime.Size = new System.Drawing.Size(185, 28);
            dtpTime.TabIndex = 7;

            // ── lblTreatment ──────────────────────────────────────────
            lblTreatment.AutoSize = false;
            lblTreatment.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblTreatment.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblTreatment.Location = new System.Drawing.Point(24, 188);
            lblTreatment.Name = "lblTreatment";
            lblTreatment.Size = new System.Drawing.Size(390, 18);
            lblTreatment.TabIndex = 8;
            lblTreatment.Text = "Treatment *";

            // ── txtTreatment ──────────────────────────────────────────
            txtTreatment.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            txtTreatment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtTreatment.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtTreatment.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtTreatment.Location = new System.Drawing.Point(24, 208);
            txtTreatment.Name = "txtTreatment";
            txtTreatment.Size = new System.Drawing.Size(390, 28);
            txtTreatment.TabIndex = 9;

            // ── lblCost ───────────────────────────────────────────────
            lblCost.AutoSize = false;
            lblCost.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblCost.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblCost.Location = new System.Drawing.Point(24, 244);
            lblCost.Name = "lblCost";
            lblCost.Size = new System.Drawing.Size(185, 18);
            lblCost.TabIndex = 10;
            lblCost.Text = "Cost (Rs.)";

            // ── lblStatus ─────────────────────────────────────────────
            lblStatus.AutoSize = false;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblStatus.Location = new System.Drawing.Point(224, 244);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(185, 18);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";

            // ── numCost ───────────────────────────────────────────────
            numCost.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            numCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            numCost.DecimalPlaces = 2;
            numCost.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            numCost.Location = new System.Drawing.Point(24, 264);
            numCost.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numCost.Name = "numCost";
            numCost.Size = new System.Drawing.Size(185, 28);
            numCost.TabIndex = 12;

            // ── cmbStatus ─────────────────────────────────────────────
            cmbStatus.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cmbStatus.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            cmbStatus.Items.AddRange(new object[] { "Scheduled", "Completed", "Cancelled" });
            cmbStatus.Location = new System.Drawing.Point(224, 264);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new System.Drawing.Size(185, 28);
            cmbStatus.TabIndex = 13;
            cmbStatus.SelectedIndex = 0;

            // ── lblNotes ──────────────────────────────────────────────
            lblNotes.AutoSize = false;
            lblNotes.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblNotes.ForeColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblNotes.Location = new System.Drawing.Point(24, 300);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new System.Drawing.Size(390, 18);
            lblNotes.TabIndex = 14;
            lblNotes.Text = "Notes (optional)";

            // ── txtNotes ──────────────────────────────────────────────
            txtNotes.BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtNotes.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtNotes.Location = new System.Drawing.Point(24, 320);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtNotes.Size = new System.Drawing.Size(390, 64);
            txtNotes.TabIndex = 15;

            // ── pnlFooter ─────────────────────────────────────────────
            pnlFooter.BackColor = System.Drawing.Color.FromArgb(220, 232, 245);
            pnlFooter.Controls.Add(btnCancel);
            pnlFooter.Controls.Add(btnSave);
            pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFooter.Location = new System.Drawing.Point(0, 504);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new System.Drawing.Size(460, 56);
            pnlFooter.TabIndex = 2;

            // ── btnSave ───────────────────────────────────────────────
            btnSave.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.Location = new System.Drawing.Point(246, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(96, 32);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            // ── btnCancel ─────────────────────────────────────────────
            btnCancel.BackColor = System.Drawing.Color.FromArgb(180, 90, 30);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(352, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(84, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            // ── Form ──────────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            ClientSize = new System.Drawing.Size(460, 560);
            Controls.Add(tlpForm);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppointmentForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Appointment";

            tlpForm.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}