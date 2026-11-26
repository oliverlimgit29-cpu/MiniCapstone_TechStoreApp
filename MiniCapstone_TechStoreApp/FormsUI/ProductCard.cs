using MiniCapstone_TechStoreApp.Models;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp
{
    public partial class ProductCard : UserControl
    {
        public ProductDB CurrentProduct { get; private set; }

        public event EventHandler<ProductDB> AddToCartClicked;
        public event EventHandler<ProductDB> ViewProductClicked;

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

        public void BindProduct(ProductDB product)
        {
            CurrentProduct = product;

            lblProductName.Text = product.ProductName;
            lblPrice.Text = product.Price.ToString("C2");
            lblRating.Text = product.AverageRating > 0
                ? string.Format("{0:0.0} / 5", product.AverageRating)
                : "No ratings yet";

            LoadProductImage(product);
        }

        private void LoadProductImage(ProductDB product)
        {
            if (pbProduct.Image != null)
            {
                Image oldImage = pbProduct.Image;
                pbProduct.Image = null;
                oldImage.Dispose();
            }

            pbProduct.ImageLocation = null;

            if (product == null)
            {
                return;
            }

            // 1. Prefer binary ImageData from MongoDB
            if (product.ImageData != null && product.ImageData.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(product.ImageData))
                    using (Image tempImage = Image.FromStream(ms))
                    {
                        // Clone into a new Bitmap so the MemoryStream can be safely closed
                        pbProduct.Image = new Bitmap(tempImage);
                    }
                    return;
                }
                catch
                {
                    // Fall back to ImageUrl if ImageData isn't a valid image stream
                }
            }

            // 2. Fallback to ImageUrl on disk
            if (!string.IsNullOrWhiteSpace(product.ImageUrl))
            {
                string fullPath = Path.IsPathRooted(product.ImageUrl)
                    ? product.ImageUrl
                    : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, product.ImageUrl);

                if (File.Exists(fullPath))
                {
                    pbProduct.ImageLocation = fullPath;
                }
            }
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            if (CurrentProduct != null && ViewProductClicked != null)
            {
                ViewProductClicked(this, CurrentProduct);
            }
        }
    }
}