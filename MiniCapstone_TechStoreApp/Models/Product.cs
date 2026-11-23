using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MiniCapstone_TechStoreApp.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("brand")]
        public string Brand { get; set; }

        [BsonElement("category")]
        public string Category { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("rating")]
        public double Rating { get; set; }

        [BsonElement("imagePath")]
        public string ImagePath { get; set; }
    }
}