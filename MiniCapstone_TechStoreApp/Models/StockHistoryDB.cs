using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCapstone_TechStoreApp.Models
{
    public class StockHistoryDB
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string AdminId { get; set; }

        public string ChangeType { get; set; }
        // StockIn / StockOut / Sale / Return / Adjustment

        public int QuantityChanged { get; set; }
        // Positive for stock added, negative for stock removed

        public int PreviousStock { get; set; }

        public int NewStock { get; set; }

        public string ReferenceId { get; set; }
        // Related OrderId, if applicable

        public string Remarks { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
