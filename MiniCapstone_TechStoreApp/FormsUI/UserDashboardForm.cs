using MiniCapstone_TechStoreApp.DatabaseMongoDB;
using MiniCapstone_TechStoreApp.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp.FormsUI
{
    public partial class UserDashboardForm : Form
    {
        //Added
        private MongoDBConnector _db;
        private bool _productsLoaded;

        public UserDashboardForm()
        {
            InitializeComponent();
        }

        //Added
        protected override async void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (_productsLoaded)
            {
                return;
            }

            _productsLoaded = true;

            try
            {
                _db = new MongoDBConnector();
                await _db.SeedSampleProductsAsync();

                List<Product> products = await _db.Product.Find(_ => true).ToListAsync();
                MessageBox.Show("Products loaded: " + products.Count);

                RenderProducts(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }


        private void RenderProducts(IEnumerable<Product> products)
        {
            flpProducts.Visible = true;
            flpProducts.BringToFront();

            flpProducts.SuspendLayout();
            flpProducts.Controls.Clear();

            foreach (Product product in products)
            {
                ProductCard card = new ProductCard();
                card.Margin = new Padding(8);
                card.BindProduct(product);
                card.AddToCartClicked += OnProductAddToCartClicked;

                flpProducts.Controls.Add(card);
            }

            flpProducts.ResumeLayout();
        }

        private void OnProductAddToCartClicked(object sender, Product product)
        {
            MessageBox.Show("Added to cart: " + product.Name);
        }
    }
}
