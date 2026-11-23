namespace MiniCapstone_TechStoreApp.FormsUI
{
    partial class AdminDashboardForm
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
            this.parrotSlidingPanel1 = new ReaLTaiizor.Controls.ParrotSlidingPanel();
            this.button1 = new ReaLTaiizor.Controls.Button();
            this.parrotControlEllipse1 = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.parrotSlidingPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parrotSlidingPanel1
            // 
            this.parrotSlidingPanel1.BottomLeft = System.Drawing.Color.MidnightBlue;
            this.parrotSlidingPanel1.BottomRight = System.Drawing.Color.MidnightBlue;
            this.parrotSlidingPanel1.CollapseControl = null;
            this.parrotSlidingPanel1.Collapsed = true;
            this.parrotSlidingPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotSlidingPanel1.Controls.Add(this.button1);
            this.parrotSlidingPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.parrotSlidingPanel1.HideControls = false;
            this.parrotSlidingPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotSlidingPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotSlidingPanel1.Name = "parrotSlidingPanel1";
            this.parrotSlidingPanel1.PanelWidthCollapsed = 50;
            this.parrotSlidingPanel1.PanelWidthExpanded = 200;
            this.parrotSlidingPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotSlidingPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotSlidingPanel1.Size = new System.Drawing.Size(155, 450);
            this.parrotSlidingPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotSlidingPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Horizontal;
            this.parrotSlidingPanel1.TabIndex = 0;
            this.parrotSlidingPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotSlidingPanel1.TopLeft = System.Drawing.Color.MidnightBlue;
            this.parrotSlidingPanel1.TopRight = System.Drawing.Color.MidnightBlue;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Image = null;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.InactiveColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(12, 102);
            this.button1.Name = "button1";
            this.button1.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotControlEllipse1
            // 
            this.parrotControlEllipse1.CornerRadius = 10;
            this.parrotControlEllipse1.EffectedControl = this.parrotSlidingPanel1;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parrotSlidingPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 720);
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "AdminDashboardForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.parrotSlidingPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotSlidingPanel parrotSlidingPanel1;
        private ReaLTaiizor.Controls.ParrotControlEllipse parrotControlEllipse1;
        private ReaLTaiizor.Controls.Button button1;
    }
}