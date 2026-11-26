using MiniCapstone_TechStoreApp.DatabaseMongoDB;
using MiniCapstone_TechStoreApp.Helper;
using MiniCapstone_TechStoreApp.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp.FormsUI
{
    public partial class UserDashboardForm : Form
    {
        private MongoDBConnector _db;
        private bool _productsLoaded;
        //private List<ProductDB> _allProducts = new List<ProductDB>();

        public UserDashboardForm()
        {
            InitializeComponent();
            DisplayLoggedInUser();
            //WireUpFilterCheckboxes();
        }

        private void DisplayLoggedInUser()
        {
            // Change CurrentUser?.Username to match the property in your UserSession class
            string username = UserSession.CurrentUser?.Username;

            if (!string.IsNullOrWhiteSpace(username))
            {
                btnUser.Text = "       " +username;
            }
        }

        //private void WireUpFilterCheckboxes()
        //{
        //    // Product type / category checkboxes (add your remaining cbFilter* controls here)
        //    cbFilterDesktop.CheckedChanged += FilterChanged;
        //    cbFilterKeyboard.CheckedChanged += FilterChanged;
        //    cbFilterMouse.CheckedChanged += FilterChanged;
        //    cbFilterLaptop.CheckedChanged += FilterChanged;
        //    cbFilterPhone.CheckedChanged += FilterChanged;
        //    cbFilterMonitor.CheckedChanged += FilterChanged;

        //    // Brand checkboxes (add your remaining cbBrand* controls here)
        //    cbBrandSamsung.CheckedChanged += FilterChanged;
        //    cbBrandHuawei.CheckedChanged += FilterChanged;
        //    cbBrandApple.CheckedChanged += FilterChanged;
        //    cbBrandAsus.CheckedChanged += FilterChanged;
        //    cbBrandXiaomi.CheckedChanged += FilterChanged;
        //    cbBrandLenovo.CheckedChanged += FilterChanged;
        //}

        //private void FilterChanged(object sender, EventArgs e)
        //{
        //    ApplyFilters();
        //}

        //private void ApplyFilters()
        //{
        //    if (_allProducts == null)
        //    {
        //        return;
        //    }

        //    List<string> selectedCategories = new List<string>();
        //    if (cbFilterDesktop.Checked) selectedCategories.Add("Desktop");
        //    if (cbFilterKeyboard.Checked) selectedCategories.Add("Keyboard");
        //    if (cbFilterMouse.Checked) selectedCategories.Add("Mouse");
        //    if (cbFilterLaptop.Checked) selectedCategories.Add("Laptop");
        //    if (cbFilterPhone.Checked) selectedCategories.Add("Phone");
        //    if (cbFilterMonitor.Checked) selectedCategories.Add("Monitor");

        //    List<string> selectedBrands = new List<string>();
        //    if (cbBrandSamsung.Checked) selectedBrands.Add("Samsung");
        //    if (cbBrandHuawei.Checked) selectedBrands.Add("Huawei");
        //    if (cbBrandApple.Checked) selectedBrands.Add("Apple");
        //    if (cbBrandAsus.Checked) selectedBrands.Add("Asus");
        //    if (cbBrandXiaomi.Checked) selectedBrands.Add("Xiaomi");
        //    if (cbBrandLenovo.Checked) selectedBrands.Add("Lenovo");

        //    IEnumerable<ProductDB> filtered = _allProducts;

        //    if (selectedCategories.Count > 0)
        //    {
        //        filtered = filtered.Where(p =>
        //            !string.IsNullOrWhiteSpace(p.Category) &&
        //            selectedCategories.Any(c => string.Equals(p.Category.Trim(), c, StringComparison.OrdinalIgnoreCase)));
        //    }

        //    if (selectedBrands.Count > 0)
        //    {
        //        filtered = filtered.Where(p =>
        //            !string.IsNullOrWhiteSpace(p.Brand) &&
        //            selectedBrands.Any(b => string.Equals(p.Brand.Trim(), b, StringComparison.OrdinalIgnoreCase)));
        //    }

        //    RenderProducts(filtered.ToList());
        //}

        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (DesignMode || _productsLoaded)
            {
                return;
            }

            _productsLoaded = true;

            try
            {
                _db = new MongoDBConnector();

                List<ProductDB> products = await _db.Products
                    .Find(p => p.IsActive)
                    .ToListAsync();

                MessageBox.Show("Products loaded: " + products.Count);

                RenderProducts(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void RenderProducts(IEnumerable<ProductDB> products)
        {
            flpProducts.Visible = true;
            flpProducts.BringToFront();

            flpProducts.SuspendLayout();
            flpProducts.Controls.Clear();

            foreach (ProductDB product in products)
            {
                ProductCard card = new ProductCard();
                card.Margin = new Padding(8);
                card.BindProduct(product);
                card.AddToCartClicked += OnProductAddToCartClicked;
                card.ViewProductClicked += OnProductViewClicked;

                flpProducts.Controls.Add(card);
            }

            flpProducts.ResumeLayout();
        }

        private void OnProductAddToCartClicked(object sender, ProductDB product)
        {
            MessageBox.Show("Added to cart: " + product.ProductName);
        }

        private void OnProductViewClicked(object sender, ProductDB product)
        {
            using (UserProductDetails detailsForm = new UserProductDetails())
            {
                detailsForm.ShowDialog(this);
            }
        }
    }
}