using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCapstone_TechStoreApp.Models
{
    public class PaymentDB
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string OrderId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string BuyerId { get; set; }

        public string PaymentMethod { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Amount { get; set; }

        public string PaymentStatus { get; set; }

        public string TransactionReference { get; set; }

        public bool IsSimulated { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
