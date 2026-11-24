namespace MiniCapstone_TechStoreApp.FormsUI
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtPassword = new ReaLTaiizor.Controls.DungeonTextBox();
            this.txtEmail = new ReaLTaiizor.Controls.DungeonTextBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.btnRegister = new ReaLTaiizor.Controls.DungeonButtonLeft();
            this.linkLblLogin = new ReaLTaiizor.Controls.DungeonLinkLabel();
            this.Register = new ReaLTaiizor.Forms.AirForm();
            this.pnlRegister = new ReaLTaiizor.Controls.Panel();
            this.dungeonLabel5 = new ReaLTaiizor.Controls.DungeonLabel();
            this.Register.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtUsername.EdgeColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(45, 53);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(307, 28);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtPassword.EdgeColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(45, 132);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(307, 28);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtEmail.EdgeColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(45, 211);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.Size = new System.Drawing.Size(307, 28);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(41, 30);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(75, 20);
            this.dungeonLabel1.TabIndex = 3;
            this.dungeonLabel1.Text = "Username";
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(41, 109);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(70, 20);
            this.dungeonLabel2.TabIndex = 4;
            this.dungeonLabel2.Text = "Password";
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(41, 188);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(46, 20);
            this.dungeonLabel3.TabIndex = 5;
            this.dungeonLabel3.Text = "Email";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRegister.Image = null;
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnRegister.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btnRegister.Location = new System.Drawing.Point(49, 281);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnRegister.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnRegister.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnRegister.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnRegister.Size = new System.Drawing.Size(307, 47);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // linkLblLogin
            // 
            this.linkLblLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLblLogin.AutoSize = true;
            this.linkLblLogin.BackColor = System.Drawing.Color.Transparent;
            this.linkLblLogin.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.linkLblLogin.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLblLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLblLogin.Location = new System.Drawing.Point(267, 354);
            this.linkLblLogin.Name = "linkLblLogin";
            this.linkLblLogin.Size = new System.Drawing.Size(46, 20);
            this.linkLblLogin.TabIndex = 8;
            this.linkLblLogin.TabStop = true;
            this.linkLblLogin.Text = "Login";
            this.linkLblLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.linkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLogin_LinkClicked);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Register.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Register.Controls.Add(this.pnlRegister);
            this.Register.Customization = "AAAA/1paWv9ycnL/";
            this.Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Register.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Register.Image = null;
            this.Register.Location = new System.Drawing.Point(0, 0);
            this.Register.MaximumSize = new System.Drawing.Size(1366, 720);
            this.Register.MinimumSize = new System.Drawing.Size(112, 35);
            this.Register.Movable = true;
            this.Register.Name = "Register";
            this.Register.NoRounding = false;
            this.Register.Sizable = true;
            this.Register.Size = new System.Drawing.Size(918, 468);
            this.Register.SmartBounds = true;
            this.Register.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Register.TabIndex = 9;
            this.Register.Text = "Register";
            this.Register.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Register.Transparent = false;
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlRegister.Controls.Add(this.dungeonLabel1);
            this.pnlRegister.Controls.Add(this.txtUsername);
            this.pnlRegister.Controls.Add(this.txtPassword);
            this.pnlRegister.Controls.Add(this.dungeonLabel2);
            this.pnlRegister.Controls.Add(this.txtEmail);
            this.pnlRegister.Controls.Add(this.btnRegister);
            this.pnlRegister.Controls.Add(this.dungeonLabel5);
            this.pnlRegister.Controls.Add(this.dungeonLabel3);
            this.pnlRegister.Controls.Add(this.linkLblLogin);
            this.pnlRegister.EdgeColor = System.Drawing.Color.White;
            this.pnlRegister.Location = new System.Drawing.Point(242, 29);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Padding = new System.Windows.Forms.Padding(5);
            this.pnlRegister.Size = new System.Drawing.Size(396, 427);
            this.pnlRegister.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlRegister.TabIndex = 9;
            this.pnlRegister.Text = "panel1";
            // 
            // dungeonLabel5
            // 
            this.dungeonLabel5.AutoSize = true;
            this.dungeonLabel5.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel5.Location = new System.Drawing.Point(93, 354);
            this.dungeonLabel5.Name = "dungeonLabel5";
            this.dungeonLabel5.Size = new System.Drawing.Size(178, 20);
            this.dungeonLabel5.TabIndex = 7;
            this.dungeonLabel5.Text = "Already have an account?";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(918, 468);
            this.Controls.Add(this.Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 720);
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.RegistrationForm_Resize);
            this.Register.ResumeLayout(false);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox txtUsername;
        private ReaLTaiizor.Controls.DungeonTextBox txtPassword;
        private ReaLTaiizor.Controls.DungeonTextBox txtEmail;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonButtonLeft btnRegister;
        private ReaLTaiizor.Controls.DungeonLinkLabel linkLblLogin;
        private ReaLTaiizor.Forms.AirForm Register;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel5;
        private ReaLTaiizor.Controls.Panel pnlRegister;
    }
}