using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCapstone_TechStoreApp.Models
{
    public class OrderDB
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string OrderNumber { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string BuyerId { get; set; }

        public List<OrderItemDB> Items { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Subtotal { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal DiscountAmount { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal TotalAmount { get; set; }

        public DiscountSnapshotDB DiscountSnapshot { get; set; }

        public string OrderStatus { get; set; }

        public string PaymentStatus { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }

    public class OrderItemDB
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string SKU { get; set; }

        public string Category { get; set; }

        public BsonDocument Specifications { get; set; }

        public int Quantity { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal UnitPrice { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal LineTotal { get; set; }
    }

    public class DiscountSnapshotDB
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string DiscountId { get; set; }

        public string DiscountName { get; set; }

        public string DiscountType { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal DiscountValue { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal AppliedAmount { get; set; }
    }
}
