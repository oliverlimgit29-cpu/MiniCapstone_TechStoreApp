namespace MiniCapstone_TechStoreApp.FormsUI
{
    partial class AdminInventoryContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInventoryContent));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblpanelInventory = new System.Windows.Forms.TableLayoutPanel();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.cmbCategories = new ReaLTaiizor.Controls.HopeComboBox();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.btnAddProduct = new ReaLTaiizor.Controls.Button();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlOutOfStock = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlTotalProducts = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBrands = new System.Windows.Forms.Panel();
            this.cmbBrands = new ReaLTaiizor.Controls.HopeComboBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtBoxSearch = new ReaLTaiizor.Controls.HopeTextBox();
            this.btnSearch = new ReaLTaiizor.Controls.Button();
            this.pnlInventory = new System.Windows.Forms.Panel();
            this.dgvInventory = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlStockHistory = new System.Windows.Forms.Panel();
            this.dgvStockHistory = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStockHistoryHeader = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlStockStatus = new System.Windows.Forms.Panel();
            this.cmbStockStatus = new ReaLTaiizor.Controls.HopeComboBox();
            this.roundedHeader = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.roundedTotalProducts = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.roundedLowStock = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.roundedOutOfStock = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.roundedCategories = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.roundedBrands = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.roundedStockStatus = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.roundedSearch = new ReaLTaiizor.Controls.ParrotControlEllipse();
            this.tblpanelInventory.SuspendLayout();
            this.pnlCategories.SuspendLayout();
            this.pnlAddProduct.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlOutOfStock.SuspendLayout();
            this.pnlTotalProducts.SuspendLayout();
            this.pnlBrands.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.pnlStockHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockHistory)).BeginInit();
            this.pnlStockHistoryHeader.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlStockStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpanelInventory
            // 
            this.tblpanelInventory.BackColor = System.Drawing.Color.Gainsboro;
            this.tblpanelInventory.ColumnCount = 12;
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tblpanelInventory.Controls.Add(this.pnlCategories, 3, 4);
            this.tblpanelInventory.Controls.Add(this.pnlAddProduct, 0, 4);
            this.tblpanelInventory.Controls.Add(this.pnlLowStock, 4, 2);
            this.tblpanelInventory.Controls.Add(this.pnlOutOfStock, 8, 2);
            this.tblpanelInventory.Controls.Add(this.pnlTotalProducts, 0, 2);
            this.tblpanelInventory.Controls.Add(this.pnlBrands, 4, 4);
            this.tblpanelInventory.Controls.Add(this.pnlSearch, 9, 4);
            this.tblpanelInventory.Controls.Add(this.pnlInventory, 0, 6);
            this.tblpanelInventory.Controls.Add(this.pnlStockHistory, 0, 13);
            this.tblpanelInventory.Controls.Add(this.pnlHeader, 0, 0);
            this.tblpanelInventory.Controls.Add(this.pnlStockStatus, 7, 4);
            this.tblpanelInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpanelInventory.Location = new System.Drawing.Point(0, 0);
            this.tblpanelInventory.Name = "tblpanelInventory";
            this.tblpanelInventory.RowCount = 20;
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tblpanelInventory.Size = new System.Drawing.Size(800, 523);
            this.tblpanelInventory.TabIndex = 0;
            // 
            // pnlCategories
            // 
            this.pnlCategories.BackColor = System.Drawing.Color.Transparent;
            this.tblpanelInventory.SetColumnSpan(this.pnlCategories, 2);
            this.pnlCategories.Controls.Add(this.cmbCategories);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCategories.Location = new System.Drawing.Point(201, 115);
            this.pnlCategories.Name = "pnlCategories";
            this.tblpanelInventory.SetRowSpan(this.pnlCategories, 2);
            this.pnlCategories.Size = new System.Drawing.Size(126, 38);
            this.pnlCategories.TabIndex = 3;
            // 
            // cmbCategories
            // 
            this.cmbCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.ItemHeight = 30;
            this.cmbCategories.Items.AddRange(new object[] {
            "All Categories",
            "Desktop",
            "Laptop",
            "Mouse",
            "Keyboard",
            "Monitor",
            "Phone"});
            this.cmbCategories.Location = new System.Drawing.Point(0, 0);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(126, 36);
            this.cmbCategories.TabIndex = 1;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.filterOrSearchChange);
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.tblpanelInventory.SetColumnSpan(this.pnlAddProduct, 3);
            this.pnlAddProduct.Controls.Add(this.btnAddProduct);
            this.pnlAddProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddProduct.ForeColor = System.Drawing.Color.Transparent;
            this.pnlAddProduct.Location = new System.Drawing.Point(3, 115);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.tblpanelInventory.SetRowSpan(this.pnlAddProduct, 2);
            this.pnlAddProduct.Size = new System.Drawing.Size(192, 38);
            this.pnlAddProduct.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddProduct.EnteredBorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Image = null;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.InactiveColor = System.Drawing.Color.DodgerBlue;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Padding = new System.Windows.Forms.Padding(12);
            this.btnAddProduct.PressedBorderColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.PressedColor = System.Drawing.Color.Blue;
            this.btnAddProduct.Size = new System.Drawing.Size(192, 38);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "➕   Add Product";
            this.btnAddProduct.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.tblpanelInventory.SetColumnSpan(this.pnlLowStock, 4);
            this.pnlLowStock.Controls.Add(this.label4);
            this.pnlLowStock.Controls.Add(this.label5);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(267, 55);
            this.pnlLowStock.Name = "pnlLowStock";
            this.tblpanelInventory.SetRowSpan(this.pnlLowStock, 2);
            this.pnlLowStock.Size = new System.Drawing.Size(258, 46);
            this.pnlLowStock.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(41, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(41, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Low Stock";
            // 
            // pnlOutOfStock
            // 
            this.pnlOutOfStock.BackColor = System.Drawing.Color.White;
            this.tblpanelInventory.SetColumnSpan(this.pnlOutOfStock, 4);
            this.pnlOutOfStock.Controls.Add(this.label6);
            this.pnlOutOfStock.Controls.Add(this.label7);
            this.pnlOutOfStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOutOfStock.Location = new System.Drawing.Point(531, 55);
            this.pnlOutOfStock.Name = "pnlOutOfStock";
            this.tblpanelInventory.SetRowSpan(this.pnlOutOfStock, 2);
            this.pnlOutOfStock.Size = new System.Drawing.Size(266, 46);
            this.pnlOutOfStock.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(40, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(40, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Out of Stock";
            // 
            // pnlTotalProducts
            // 
            this.pnlTotalProducts.BackColor = System.Drawing.Color.White;
            this.tblpanelInventory.SetColumnSpan(this.pnlTotalProducts, 4);
            this.pnlTotalProducts.Controls.Add(this.label3);
            this.pnlTotalProducts.Controls.Add(this.label2);
            this.pnlTotalProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalProducts.ForeColor = System.Drawing.SystemColors.InfoText;
            this.pnlTotalProducts.Location = new System.Drawing.Point(3, 55);
            this.pnlTotalProducts.Name = "pnlTotalProducts";
            this.tblpanelInventory.SetRowSpan(this.pnlTotalProducts, 2);
            this.pnlTotalProducts.Size = new System.Drawing.Size(258, 46);
            this.pnlTotalProducts.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(40, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(40, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Products";
            // 
            // pnlBrands
            // 
            this.pnlBrands.BackColor = System.Drawing.Color.Transparent;
            this.tblpanelInventory.SetColumnSpan(this.pnlBrands, 2);
            this.pnlBrands.Controls.Add(this.cmbBrands);
            this.pnlBrands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBrands.Location = new System.Drawing.Point(333, 115);
            this.pnlBrands.Name = "pnlBrands";
            this.tblpanelInventory.SetRowSpan(this.pnlBrands, 2);
            this.pnlBrands.Size = new System.Drawing.Size(126, 38);
            this.pnlBrands.TabIndex = 4;
            // 
            // cmbBrands
            // 
            this.cmbBrands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBrands.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrands.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.ItemHeight = 30;
            this.cmbBrands.Items.AddRange(new object[] {
            "All Brands",
            "Apple",
            "Huawei",
            "Samsung",
            "Asus",
            "Lenovo",
            "Xiaomi"});
            this.cmbBrands.Location = new System.Drawing.Point(0, 0);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(126, 36);
            this.cmbBrands.TabIndex = 1;
            this.cmbBrands.SelectedIndexChanged += new System.EventHandler(this.filterOrSearchChange);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.tblpanelInventory.SetColumnSpan(this.pnlSearch, 3);
            this.pnlSearch.Controls.Add(this.txtBoxSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(597, 115);
            this.pnlSearch.Name = "pnlSearch";
            this.tblpanelInventory.SetRowSpan(this.pnlSearch, 2);
            this.pnlSearch.Size = new System.Drawing.Size(200, 38);
            this.pnlSearch.TabIndex = 4;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.White;
            this.txtBoxSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtBoxSearch.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtBoxSearch.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtBoxSearch.Hint = "Search (Name/SKU)";
            this.txtBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.Multiline = false;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.Size = new System.Drawing.Size(160, 38);
            this.txtBoxSearch.TabIndex = 7;
            this.txtBoxSearch.TabStop = false;
            this.txtBoxSearch.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.EnteredBorderColor = System.Drawing.Color.Black;
            this.btnSearch.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.InactiveColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(160, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedBorderColor = System.Drawing.Color.Black;
            this.btnSearch.PressedColor = System.Drawing.Color.Silver;
            this.btnSearch.Size = new System.Drawing.Size(40, 38);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.filterOrSearchChange);
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.White;
            this.tblpanelInventory.SetColumnSpan(this.pnlInventory, 20);
            this.pnlInventory.Controls.Add(this.dgvInventory);
            this.pnlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInventory.Location = new System.Drawing.Point(3, 159);
            this.pnlInventory.Name = "pnlInventory";
            this.tblpanelInventory.SetRowSpan(this.pnlInventory, 7);
            this.pnlInventory.Size = new System.Drawing.Size(794, 176);
            this.pnlInventory.TabIndex = 5;
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductImage,
            this.ProductName,
            this.SKU,
            this.Category,
            this.Brand,
            this.Price,
            this.Stock,
            this.Status,
            this.Actions});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInventory.Location = new System.Drawing.Point(0, 0);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(794, 176);
            this.dgvInventory.TabIndex = 0;
            this.dgvInventory.UseCustomBackColor = true;
            this.dgvInventory.UseCustomForeColor = true;
            // 
            // ProductImage
            // 
            this.ProductImage.HeaderText = "Image";
            this.ProductImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            this.ProductImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Actions
            // 
            this.Actions.HeaderText = "Actions";
            this.Actions.Name = "Actions";
            this.Actions.ReadOnly = true;
            // 
            // pnlStockHistory
            // 
            this.pnlStockHistory.BackColor = System.Drawing.Color.White;
            this.tblpanelInventory.SetColumnSpan(this.pnlStockHistory, 20);
            this.pnlStockHistory.Controls.Add(this.dgvStockHistory);
            this.pnlStockHistory.Controls.Add(this.pnlStockHistoryHeader);
            this.pnlStockHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStockHistory.Location = new System.Drawing.Point(3, 341);
            this.pnlStockHistory.Name = "pnlStockHistory";
            this.tblpanelInventory.SetRowSpan(this.pnlStockHistory, 7);
            this.pnlStockHistory.Size = new System.Drawing.Size(794, 179);
            this.pnlStockHistory.TabIndex = 6;
            // 
            // dgvStockHistory
            // 
            this.dgvStockHistory.AllowUserToAddRows = false;
            this.dgvStockHistory.AllowUserToDeleteRows = false;
            this.dgvStockHistory.AllowUserToResizeRows = false;
            this.dgvStockHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStockHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStockHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvStockHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Product,
            this.Type,
            this.Quantity});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockHistory.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvStockHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockHistory.EnableHeadersVisualStyles = false;
            this.dgvStockHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvStockHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvStockHistory.Location = new System.Drawing.Point(0, 28);
            this.dgvStockHistory.Name = "dgvStockHistory";
            this.dgvStockHistory.ReadOnly = true;
            this.dgvStockHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvStockHistory.RowHeadersVisible = false;
            this.dgvStockHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStockHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStockHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockHistory.Size = new System.Drawing.Size(794, 151);
            this.dgvStockHistory.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // pnlStockHistoryHeader
            // 
            this.pnlStockHistoryHeader.BackColor = System.Drawing.Color.White;
            this.pnlStockHistoryHeader.Controls.Add(this.label12);
            this.pnlStockHistoryHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStockHistoryHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlStockHistoryHeader.Name = "pnlStockHistoryHeader";
            this.pnlStockHistoryHeader.Size = new System.Drawing.Size(794, 28);
            this.pnlStockHistoryHeader.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Stock History";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.tblpanelInventory.SetColumnSpan(this.pnlHeader, 12);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.Black;
            this.pnlHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.tblpanelInventory.SetRowSpan(this.pnlHeader, 2);
            this.pnlHeader.Size = new System.Drawing.Size(794, 46);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management";
            // 
            // pnlStockStatus
            // 
            this.pnlStockStatus.BackColor = System.Drawing.Color.Transparent;
            this.tblpanelInventory.SetColumnSpan(this.pnlStockStatus, 2);
            this.pnlStockStatus.Controls.Add(this.cmbStockStatus);
            this.pnlStockStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStockStatus.Location = new System.Drawing.Point(465, 115);
            this.pnlStockStatus.Name = "pnlStockStatus";
            this.tblpanelInventory.SetRowSpan(this.pnlStockStatus, 2);
            this.pnlStockStatus.Size = new System.Drawing.Size(126, 38);
            this.pnlStockStatus.TabIndex = 5;
            // 
            // cmbStockStatus
            // 
            this.cmbStockStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStockStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStockStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStockStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbStockStatus.FormattingEnabled = true;
            this.cmbStockStatus.ItemHeight = 30;
            this.cmbStockStatus.Items.AddRange(new object[] {
            "All Stock Status",
            "In Stock",
            "Low Stock",
            "Out of Stock"});
            this.cmbStockStatus.Location = new System.Drawing.Point(0, 0);
            this.cmbStockStatus.Name = "cmbStockStatus";
            this.cmbStockStatus.Size = new System.Drawing.Size(126, 36);
            this.cmbStockStatus.TabIndex = 2;
            this.cmbStockStatus.SelectedIndexChanged += new System.EventHandler(this.filterOrSearchChange);
            // 
            // roundedHeader
            // 
            this.roundedHeader.CornerRadius = 10;
            this.roundedHeader.EffectedControl = this.pnlHeader;
            // 
            // roundedTotalProducts
            // 
            this.roundedTotalProducts.CornerRadius = 10;
            this.roundedTotalProducts.EffectedControl = this.pnlTotalProducts;
            // 
            // roundedLowStock
            // 
            this.roundedLowStock.CornerRadius = 10;
            this.roundedLowStock.EffectedControl = this.pnlLowStock;
            // 
            // roundedOutOfStock
            // 
            this.roundedOutOfStock.CornerRadius = 10;
            this.roundedOutOfStock.EffectedControl = this.pnlOutOfStock;
            // 
            // roundedCategories
            // 
            this.roundedCategories.CornerRadius = 10;
            this.roundedCategories.EffectedControl = this.cmbCategories;
            // 
            // roundedBrands
            // 
            this.roundedBrands.CornerRadius = 10;
            this.roundedBrands.EffectedControl = this.cmbBrands;
            // 
            // roundedStockStatus
            // 
            this.roundedStockStatus.CornerRadius = 10;
            this.roundedStockStatus.EffectedControl = this.cmbStockStatus;
            // 
            // roundedSearch
            // 
            this.roundedSearch.CornerRadius = 10;
            this.roundedSearch.EffectedControl = this.txtBoxSearch;
            // 
            // AdminInventoryContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.tblpanelInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminInventoryContent";
            this.Text = "AdminProductContent";
            this.Load += new System.EventHandler(this.AdminInventoryContent_Load);
            this.tblpanelInventory.ResumeLayout(false);
            this.pnlCategories.ResumeLayout(false);
            this.pnlAddProduct.ResumeLayout(false);
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlOutOfStock.ResumeLayout(false);
            this.pnlOutOfStock.PerformLayout();
            this.pnlTotalProducts.ResumeLayout(false);
            this.pnlTotalProducts.PerformLayout();
            this.pnlBrands.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.pnlStockHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockHistory)).EndInit();
            this.pnlStockHistoryHeader.ResumeLayout(false);
            this.pnlStockHistoryHeader.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlStockStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpanelInventory;
        private System.Windows.Forms.Panel pnlAddProduct;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlOutOfStock;
        private System.Windows.Forms.Panel pnlTotalProducts;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Panel pnlBrands;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlInventory;
        private System.Windows.Forms.Panel pnlStockHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvInventory;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvStockHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Panel pnlStockHistoryHeader;
        private System.Windows.Forms.Label label12;
        private ReaLTaiizor.Controls.Button btnAddProduct;
        private ReaLTaiizor.Controls.HopeComboBox cmbCategories;
        private ReaLTaiizor.Controls.HopeComboBox cmbBrands;
        private System.Windows.Forms.Panel pnlStockStatus;
        private ReaLTaiizor.Controls.HopeComboBox cmbStockStatus;
        private ReaLTaiizor.Controls.Button btnSearch;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Actions;
        private ReaLTaiizor.Controls.HopeTextBox txtBoxSearch;
        private ReaLTaiizor.Controls.ParrotControlEllipse roundedHeader;
        private ReaLTaiizor.Controls.ParrotControlEllipse roundedTotalProducts;
        private ReaLTaiizor.Controls.ParrotControlEllipse roundedLowStock;
        private ReaLTaiizor.Controls.ParrotControlEllipse roundedOutOfStock;
        private ReaLTaiizor.Controls.ParrotControlEllipse roundedCategories;
        private ReaLTaiizor.Controls.ParrotControlEllipse roundedBrands;
        private ReaLTaiizor.Controls.ParrotControlEllipse roundedStockStatus;
        private ReaLTaiizor.Controls.ParrotControlEllipse roundedSearch;
    }
}