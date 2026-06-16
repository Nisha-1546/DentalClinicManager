namespace DentalClinicManager
{
    partial class frmLogin
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
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            lblUserName = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            pnlLoginForm = new System.Windows.Forms.Panel();
            lblHeading = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            pnlLoginForm.SuspendLayout();
            SuspendLayout();

            // ── frmLogin ──────────────────────────────────────────────
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(235, 242, 250);
            ClientSize = new System.Drawing.Size(800, 500);
            Controls.Add(pnlLoginForm);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Dental Clinic — Login";

            // ── pnlLoginForm (card) ───────────────────────────────────
            pnlLoginForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnlLoginForm.BackColor = System.Drawing.Color.White;
            pnlLoginForm.Location = new System.Drawing.Point(200, 75);
            pnlLoginForm.Name = "pnlLoginForm";
            pnlLoginForm.Size = new System.Drawing.Size(400, 350);
            pnlLoginForm.TabIndex = 5;
            pnlLoginForm.Controls.Add(lblHeading);
            pnlLoginForm.Controls.Add(lblSubtitle);
            pnlLoginForm.Controls.Add(lblUserName);
            pnlLoginForm.Controls.Add(txtUsername);
            pnlLoginForm.Controls.Add(lblPassword);
            pnlLoginForm.Controls.Add(txtPassword);
            pnlLoginForm.Controls.Add(btnLogin);

            // ── lblHeading ────────────────────────────────────────────
            lblHeading.AutoSize = false;
            lblHeading.BackColor = System.Drawing.Color.FromArgb(27, 58, 87);
            lblHeading.Dock = System.Windows.Forms.DockStyle.Top;
            lblHeading.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblHeading.ForeColor = System.Drawing.Color.White;
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new System.Drawing.Size(400, 60);
            lblHeading.TabIndex = 6;
            lblHeading.Text = "  Dental Clinic Login";
            lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── lblSubtitle ───────────────────────────────────────────
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 110);
            lblSubtitle.Location = new System.Drawing.Point(30, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 7;
            lblSubtitle.Text = "Please sign in to continue";

            // ── lblUserName ───────────────────────────────────────────
            lblUserName.AutoSize = true;
            lblUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblUserName.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblUserName.Location = new System.Drawing.Point(30, 108);
            lblUserName.Name = "lblUserName";
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Username";

            // ── txtUsername ───────────────────────────────────────────
            txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsername.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            txtUsername.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtUsername.Location = new System.Drawing.Point(30, 128);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(340, 26);
            txtUsername.TabIndex = 0;

            // ── lblPassword ───────────────────────────────────────────
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            lblPassword.Location = new System.Drawing.Point(30, 172);
            lblPassword.Name = "lblPassword";
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";

            // ── txtPassword ───────────────────────────────────────────
            txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPassword.BackColor = System.Drawing.Color.FromArgb(245, 248, 252);
            txtPassword.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30);
            txtPassword.Location = new System.Drawing.Point(30, 192);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(340, 26);
            txtPassword.TabIndex = 1;

            // ── btnLogin ──────────────────────────────────────────────
            btnLogin.BackColor = System.Drawing.Color.FromArgb(41, 98, 146);
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(30, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(340, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLogin.Click += btnLogin_Click;

            pnlLoginForm.ResumeLayout(false);
            pnlLoginForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSubtitle;
    }
}