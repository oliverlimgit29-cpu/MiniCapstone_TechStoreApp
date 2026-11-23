using Microsoft.VisualBasic.ApplicationServices;
using MiniCapstone_TechStoreApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCapstone_TechStoreApp.DatabaseMongoDB
{
    public class MongoDBConnector
    {
        private IMongoDatabase database;
        public MongoDBConnector()
        {
            string connectionString = Environment.GetEnvironmentVariable("MINICAPSTONE_MONGODB_CONNECTIONSTRING");

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new Exception("MongoDB connection string is missing.");
            }

            MongoClient client = new MongoClient(connectionString);

            database = client.GetDatabase("TechStoreDB");
        }

        public IMongoCollection<UserDB> Users
        {
            get 
            { 
                return database.GetCollection<UserDB>("Users"); 
            }
        }

        public IMongoCollection<EmailVerification> EmailVerifications
        {
            get
            {
                return database.GetCollection<EmailVerification>("EmailVerifications");
            }
        }

        //added
        public IMongoCollection<Product> Products
        {
            get { return database.GetCollection<Product>("Products"); }
        }

        public async Task SeedSampleProductsAsync()
        {
            long existingCount = await Products.CountDocumentsAsync(FilterDefinition<Product>.Empty);
            if (existingCount > 0)
            {
                return;
            }

            List<Product> sampleProducts = new List<Product>
            {
                new Product { Name = "ASUS ROG Strix G16", Brand = "Asus", Category = "Laptop", Price = 74999m, Rating = 4.8 },
                new Product { Name = "Dell UltraSharp 27", Brand = "Dell", Category = "Monitor", Price = 21500m, Rating = 4.6 },
                new Product { Name = "Corsair K70 RGB Pro", Brand = "Corsair", Category = "Keyboard", Price = 6800m, Rating = 4.7 },
                new Product { Name = "Logitech G Pro X Superlight", Brand = "Logitech", Category = "Mouse", Price = 5900m, Rating = 4.9 }
            };

            await Products.InsertManyAsync(sampleProducts);
        }

        //public async Task CreateIndexesAsync()
        //{
        //    // Prevent duplicate user email addresses.
        //    CreateIndexOptions userEmailOptions = new CreateIndexOptions { Unique = true };

        //    IndexKeysDefinition<UserDB> userEmailIndex = Builders<UserDB>.IndexKeys.Ascending(x => x.Email);

        //    await Users.Indexes.CreateOneAsync(new CreateIndexModel<UserDB>(userEmailIndex, userEmailOptions));

        //    // One verification document per email address.
        //    CreateIndexOptions verificationOptions = new CreateIndexOptions { Unique = true };

        //    IndexKeysDefinition<EmailVerification> verificationIndex = Builders<EmailVerification>.IndexKeys.Ascending(x => x.Email);

        //    await EmailVerifications.Indexes.CreateOneAsync(new CreateIndexModel<EmailVerification>(verificationIndex, verificationOptions));

        //    // Automatically remove expired verification documents.
        //    IndexKeysDefinition<EmailVerification> expiryIndex = Builders<EmailVerification>.IndexKeys.Ascending(x => x.ExpiresAt);

        //    CreateIndexOptions expiryOptions = new CreateIndexOptions { ExpireAfter = TimeSpan.Zero };

        //    await EmailVerifications.Indexes.CreateOneAsync(new CreateIndexModel<EmailVerification>(expiryIndex, expiryOptions));
        //}
    }
}
