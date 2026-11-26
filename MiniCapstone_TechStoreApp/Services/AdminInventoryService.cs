using MiniCapstone_TechStoreApp.DatabaseMongoDB;
using MiniCapstone_TechStoreApp.Helper;
using MiniCapstone_TechStoreApp.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCapstone_TechStoreApp.Services
{
    public class AdminInventoryService
    {
        private readonly MongoDBConnector db;

        public AdminInventoryService(MongoDBConnector db)
        {
            this.db = db;
        }

        public async Task<List<ProductDB>> GetAllProductsAsync()
        {
            return await db.Products
                .Find(Builders<ProductDB>.Filter.Empty)
                .ToListAsync();
        }

        public List<ProductDB> FilterProducts(
            List<ProductDB> products,
            string search,
            string category,
            string brand,
            string status)
        {
            return products.Where(p =>
                (string.IsNullOrWhiteSpace(search) ||
                    (!string.IsNullOrEmpty(p.ProductName) &&
                     p.ProductName.IndexOf(search,
                         StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(p.SKU) &&
                     p.SKU.IndexOf(search,
                         StringComparison.OrdinalIgnoreCase) >= 0))

                && (category == "All Categories" || p.Category == category)

                && (brand == "All Brands" || p.Brand == brand)

                && (status == "All Stock Status" ||
                    (status == "Out of Stock" && p.StockQuantity <= 0) ||
                    (status == "Low Stock" &&
                        p.StockQuantity > 0 && p.StockQuantity <= 5) ||
                    (status == "In Stock" && p.StockQuantity > 5))
            ).ToList();
        }
    }
}
