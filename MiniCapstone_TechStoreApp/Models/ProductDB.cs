using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MiniCapstone_TechStoreApp.Models
{
    [BsonIgnoreExtraElements]
    public class ProductDB
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }

        public byte[] ImageData { get; set; }

        public BsonDocument Specifications { get; set; }

        //// Groups related product variants
        //public string ModelGroupId { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] ImageData { get; set; }

        // Computed from Feedbacks collection (not stored directly on Products)
        [BsonIgnore]
        public double AverageRating { get; set; }
    }
}