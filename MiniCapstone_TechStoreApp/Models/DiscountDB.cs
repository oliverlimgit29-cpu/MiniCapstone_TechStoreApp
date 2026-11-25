using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCapstone_TechStoreApp.Models
{
    public class DiscountDB
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string DiscountName { get; set; }

        public string Description { get; set; }

        public string DiscountType { get; set; }
        // Percentage / FixedAmount

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal DiscountValue { get; set; }

        public string AppliesTo { get; set; }
        // All / Product / Category

        [BsonRepresentation(BsonType.ObjectId)]
        public List<string> TargetProductIds { get; set; }

        public List<string> TargetCategories { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal MinimumOrderAmount { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal MaximumDiscountAmount { get; set; }

        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public int UsageLimit { get; set; }

        public int UsageCount { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
