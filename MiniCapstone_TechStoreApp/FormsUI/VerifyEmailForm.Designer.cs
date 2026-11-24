namespace MiniCapstone_TechStoreApp.FormsUI
{
    partial class VerifyEmailForm
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
            this.txtVerificationCode = new ReaLTaiizor.Controls.DungeonTextBox();
            this.btnVerify = new ReaLTaiizor.Controls.DungeonButtonLeft();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.AirFormEmailVerify = new ReaLTaiizor.Forms.AirForm();
            this.pnlVerifyEmail = new ReaLTaiizor.Controls.Panel();
            this.AirFormEmailVerify.SuspendLayout();
            this.pnlVerifyEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVerificationCode
            // 
            this.txtVerificationCode.BackColor = System.Drawing.Color.Transparent;
            this.txtVerificationCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtVerificationCode.EdgeColor = System.Drawing.Color.White;
            this.txtVerificationCode.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtVerificationCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtVerificationCode.Location = new System.Drawing.Point(88, 157);
            this.txtVerificationCode.MaxLength = 32767;
            this.txtVerificationCode.Multiline = false;
            this.txtVerificationCode.Name = "txtVerificationCode";
            this.txtVerificationCode.ReadOnly = false;
            this.txtVerificationCode.Size = new System.Drawing.Size(168, 28);
            this.txtVerificationCode.TabIndex = 0;
            this.txtVerificationCode.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVerificationCode.UseSystemPasswordChar = false;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Transparent;
            this.btnVerify.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnVerify.Image = null;
            this.btnVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerify.InactiveColorA = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnVerify.InactiveColorB = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.btnVerify.Location = new System.Drawing.Point(88, 264);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.PressedColorA = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnVerify.PressedColorB = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnVerify.PressedContourColorA = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnVerify.PressedContourColorB = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167)))));
            this.btnVerify.Size = new System.Drawing.Size(168, 48);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Verify Code";
            this.btnVerify.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(40, 44);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(263, 20);
            this.dungeonLabel1.TabIndex = 2;
            this.dungeonLabel1.Text = "Check Your Email for Verification Code";
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(111, 123);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(123, 20);
            this.dungeonLabel2.TabIndex = 3;
            this.dungeonLabel2.Text = "Verification Code";
            // 
            // AirFormEmailVerify
            // 
            this.AirFormEmailVerify.BackColor = System.Drawing.Color.White;
            this.AirFormEmailVerify.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.AirFormEmailVerify.Controls.Add(this.pnlVerifyEmail);
            this.AirFormEmailVerify.Customization = "AAAA/1paWv9ycnL/";
            this.AirFormEmailVerify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AirFormEmailVerify.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AirFormEmailVerify.Image = null;
            this.AirFormEmailVerify.Location = new System.Drawing.Point(0, 0);
            this.AirFormEmailVerify.MaximumSize = new System.Drawing.Size(1366, 720);
            this.AirFormEmailVerify.MinimumSize = new System.Drawing.Size(112, 35);
            this.AirFormEmailVerify.Movable = true;
            this.AirFormEmailVerify.Name = "AirFormEmailVerify";
            this.AirFormEmailVerify.NoRounding = false;
            this.AirFormEmailVerify.Sizable = true;
            this.AirFormEmailVerify.Size = new System.Drawing.Size(800, 450);
            this.AirFormEmailVerify.SmartBounds = true;
            this.AirFormEmailVerify.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.AirFormEmailVerify.TabIndex = 0;
            this.AirFormEmailVerify.Text = "Email Verification";
            this.AirFormEmailVerify.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.AirFormEmailVerify.Transparent = false;
            // 
            // pnlVerifyEmail
            // 
            this.pnlVerifyEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pnlVerifyEmail.Controls.Add(this.dungeonLabel1);
            this.pnlVerifyEmail.Controls.Add(this.btnVerify);
            this.pnlVerifyEmail.Controls.Add(this.dungeonLabel2);
            this.pnlVerifyEmail.Controls.Add(this.txtVerificationCode);
            this.pnlVerifyEmail.EdgeColor = System.Drawing.Color.White;
            this.pnlVerifyEmail.Location = new System.Drawing.Point(234, 48);
            this.pnlVerifyEmail.Name = "pnlVerifyEmail";
            this.pnlVerifyEmail.Padding = new System.Windows.Forms.Padding(5);
            this.pnlVerifyEmail.Size = new System.Drawing.Size(343, 356);
            this.pnlVerifyEmail.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlVerifyEmail.TabIndex = 10;
            this.pnlVerifyEmail.Text = "panel1";
            // 
            // VerifyEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AirFormEmailVerify);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 720);
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "VerifyEmailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "themeForm1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.VerifyEmailForm_Shown);
            this.Resize += new System.EventHandler(this.VerifyEmailForm_Resize);
            this.AirFormEmailVerify.ResumeLayout(false);
            this.pnlVerifyEmail.ResumeLayout(false);
            this.pnlVerifyEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonTextBox txtVerificationCode;
        private ReaLTaiizor.Controls.DungeonButtonLeft btnVerify;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Forms.AirForm AirFormEmailVerify;
        private ReaLTaiizor.Controls.Panel pnlVerifyEmail;
    }
}