using MiniCapstone_TechStoreApp.Helper;
using MiniCapstone_TechStoreApp.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniCapstone_TechStoreApp.DatabaseMongoDB;
using MiniCapstone_TechStoreApp.Services;

namespace MiniCapstone_TechStoreApp.FormsUI
{
    public partial class AdminInventoryContent : Form
    {
        private readonly AdminInventoryService adminInventoryService;
        private List<ProductDB> allProducts = new List<ProductDB>();

        public AdminInventoryContent(MongoDBConnector db)
        {
            InitializeComponent();

            dgvInventory.AutoGenerateColumns = false;

            adminInventoryService = new AdminInventoryService(db);

        }

        private void InitializeFilters()
        {
            cmbCategories.SelectedIndex = 0;
            cmbBrands.SelectedIndex = 0;
            cmbStockStatus.SelectedIndex = 0;
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                allProducts = await adminInventoryService.GetAllProductsAsync();

                DisplayProducts(allProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load products: " + ex.Message);
            }
        }

        private void DisplayProducts(List<ProductDB> products)
        {
            dgvInventory.Rows.Clear();

            foreach (ProductDB p in products)
            {
                Image productImage = ImageHelper.ConvertBytesToImage(p.ImageData);

                string stockStatus = p.StockQuantity <= 0
                    ? "Out of Stock"
                    : p.StockQuantity <= 5
                        ? "Low Stock"
                        : "In Stock";

                int rowIndex = dgvInventory.Rows.Add();

                DataGridViewRow row = dgvInventory.Rows[rowIndex];

                row.Cells["ProductImage"].Value = productImage;
                row.Cells["ProductName"].Value = p.ProductName;
                row.Cells["SKU"].Value = p.SKU;
                row.Cells["Category"].Value = p.Category;
                row.Cells["Brand"].Value = p.Brand;
                row.Cells["Price"].Value = p.Price;
                row.Cells["Stock"].Value = p.StockQuantity;
                row.Cells["Status"].Value = stockStatus;
                row.Cells["Actions"].Value = "Edit";
            }
        }

        private void ApplyFilters()
        {
            string search = txtBoxSearch.Text.Trim();
            string category = cmbCategories.Text;
            string brand = cmbBrands.Text;
            string status = cmbStockStatus.Text;

            List<ProductDB> filteredProducts =
                adminInventoryService.FilterProducts(
                    allProducts,
                    search,
                    category,
                    brand,
                    status
                );

            DisplayProducts(filteredProducts);
        }

        private async void AdminInventoryContent_Load(object sender, EventArgs e)
        {
            await LoadProductsAsync();
            InitializeFilters();
        }

        private void filterOrSearchChange(object sender, EventArgs e)
        {
            ApplyFilters();
        }



        //private void btnConvertImage_Click(object sender, EventArgs e)
        //{
        //    if (picProduct.Image == null)
        //    {
        //        MessageBox.Show("Please select an image first.");
        //        return;
        //    }

        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        picProduct.Image.Save(
        //            ms,
        //            System.Drawing.Imaging.ImageFormat.Png
        //        );

        //        string base64 = Convert.ToBase64String(ms.ToArray());

        //        Clipboard.SetText(base64);

        //        MessageBox.Show("Base64 image copied to clipboard!");
        //    }
        //}
    }
}
