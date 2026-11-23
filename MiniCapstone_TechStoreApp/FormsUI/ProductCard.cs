using MiniCapstone_TechStoreApp.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp
{
    public partial class ProductCard : UserControl
    {
        public Product CurrentProduct { get; private set; }

        public event EventHandler<Product> AddToCartClicked;

        public ProductCard()
        {
            InitializeComponent();
            pbProduct.SizeMode = PictureBoxSizeMode.Zoom;

            btnAddToCart.Click += OnAddToCartClick;
        }

        private void OnAddToCartClick(object sender, EventArgs e)
        {
            if (CurrentProduct != null && AddToCartClicked != null)
            {
                AddToCartClicked(this, CurrentProduct);
            }
        }

        public void BindProduct(Product product)
        {
            CurrentProduct = product;

            lblProductName.Text = product.Name;
            lblPrice.Text = product.Price.ToString("C2");
            lblRating.Text = string.Format("{0:0.0} / 5", product.Rating);

            pbProduct.Image = null;
            pbProduct.ImageLocation = null;

            if (!string.IsNullOrWhiteSpace(product.ImagePath) && File.Exists(product.ImagePath))
            {
                pbProduct.ImageLocation = product.ImagePath;
            }
        }
    }
}