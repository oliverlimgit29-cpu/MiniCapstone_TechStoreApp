namespace MiniCapstone_TechStoreApp.FormsUI
{
    partial class AdminCustomerContent
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
            this.pnlHeader = new ReaLTaiizor.Controls.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.lblTotalReg = new System.Windows.Forms.Label();
            this.lblTotalRegCount = new System.Windows.Forms.Label();
            this.lblTotalAct = new System.Windows.Forms.Label();
            this.lblTotalActAcount = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblRegCustomer = new System.Windows.Forms.Label();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.pnlHeader.Controls.Add(this.picUserIcon);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(5);
            this.pnlHeader.Size = new System.Drawing.Size(740, 80);
            this.pnlHeader.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Text = "panel1";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeaderTitle.Location = new System.Drawing.Point(41, 21);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(235, 20);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Manage Customer Accounts";
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(16, 46);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(172, 13);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "View registered customer accounts";
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.LightGray;
            this.pnlTotal.Controls.Add(this.lblTotalRegCount);
            this.pnlTotal.Controls.Add(this.lblTotalReg);
            this.pnlTotal.Location = new System.Drawing.Point(12, 86);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(350, 61);
            this.pnlTotal.TabIndex = 1;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.LightGray;
            this.pnlActive.Controls.Add(this.lblTotalActAcount);
            this.pnlActive.Controls.Add(this.lblTotalAct);
            this.pnlActive.Location = new System.Drawing.Point(378, 86);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(350, 61);
            this.pnlActive.TabIndex = 2;
            // 
            // lblTotalReg
            // 
            this.lblTotalReg.AutoSize = true;
            this.lblTotalReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReg.Location = new System.Drawing.Point(20, 10);
            this.lblTotalReg.Name = "lblTotalReg";
            this.lblTotalReg.Size = new System.Drawing.Size(108, 16);
            this.lblTotalReg.TabIndex = 0;
            this.lblTotalReg.Text = "Total Registered";
            // 
            // lblTotalRegCount
            // 
            this.lblTotalRegCount.AutoSize = true;
            this.lblTotalRegCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegCount.Location = new System.Drawing.Point(18, 27);
            this.lblTotalRegCount.Name = "lblTotalRegCount";
            this.lblTotalRegCount.Size = new System.Drawing.Size(24, 25);
            this.lblTotalRegCount.TabIndex = 1;
            this.lblTotalRegCount.Text = "0";
            // 
            // lblTotalAct
            // 
            this.lblTotalAct.AutoSize = true;
            this.lblTotalAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAct.Location = new System.Drawing.Point(20, 10);
            this.lblTotalAct.Name = "lblTotalAct";
            this.lblTotalAct.Size = new System.Drawing.Size(78, 16);
            this.lblTotalAct.TabIndex = 2;
            this.lblTotalAct.Text = "Total Active";
            // 
            // lblTotalActAcount
            // 
            this.lblTotalActAcount.AutoSize = true;
            this.lblTotalActAcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalActAcount.Location = new System.Drawing.Point(18, 27);
            this.lblTotalActAcount.Name = "lblTotalActAcount";
            this.lblTotalActAcount.Size = new System.Drawing.Size(24, 25);
            this.lblTotalActAcount.TabIndex = 2;
            this.lblTotalActAcount.Text = "0";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 161);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(716, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Search username or email....";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 213);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(716, 46);
            this.dgvCustomers.TabIndex = 4;
            // 
            // lblRegCustomer
            // 
            this.lblRegCustomer.AccessibleName = "Rea";
            this.lblRegCustomer.AutoSize = true;
            this.lblRegCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegCustomer.Location = new System.Drawing.Point(12, 192);
            this.lblRegCustomer.Name = "lblRegCustomer";
            this.lblRegCustomer.Size = new System.Drawing.Size(168, 17);
            this.lblRegCustomer.TabIndex = 5;
            this.lblRegCustomer.Text = "Registered Customers";
            // 
            // picUserIcon
            // 
            this.picUserIcon.BackColor = System.Drawing.Color.Transparent;
            this.picUserIcon.Image = global::MiniCapstone_TechStoreApp.Properties.Resources.White_Two_Person_Group_Icon__1_1;
            this.picUserIcon.Location = new System.Drawing.Point(17, 17);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(24, 24);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserIcon.TabIndex = 2;
            this.picUserIcon.TabStop = false;
            // 
            // AdminCustomerContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 619);
            this.Controls.Add(this.lblRegCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlHeader);
            this.Name = "AdminCustomerContent";
            this.Text = "AdminCustomerContent";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Label lblTotalReg;
        private System.Windows.Forms.Label lblTotalRegCount;
        private System.Windows.Forms.Label lblTotalActAcount;
        private System.Windows.Forms.Label lblTotalAct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblRegCustomer;
        private System.Windows.Forms.PictureBox picUserIcon;
    }
}