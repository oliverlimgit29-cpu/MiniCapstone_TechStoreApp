using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCapstone_TechStoreApp.Models
{
    public class ProductRow
    {
        public Image ProductBox { get; set; }
        public string ProductName { get; set; }
        public string SKU { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string StockStatus { get; set; }
    }
}
