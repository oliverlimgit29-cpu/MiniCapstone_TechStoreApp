using MailKit.Search;
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

        public IMongoCollection<ProductDB> Products
        {
            get { return database.GetCollection<ProductDB>("Products"); }
        }

        public IMongoCollection<CartDB> Carts
        {
            get { return database.GetCollection<CartDB>("Carts"); }
        }

        public IMongoCollection<OrderDB> Orders
        {
            get { return database.GetCollection<OrderDB>("Orders"); }
        }

        public IMongoCollection<PaymentDB> Payments
        {
            get { return database.GetCollection<PaymentDB>("Payments"); }
        }

        public IMongoCollection<DiscountDB> Discounts
        {
            get { return database.GetCollection<DiscountDB>("Discounts"); }
        }

        public IMongoCollection<StockHistoryDB> StockHistory
        {
            get { return database.GetCollection<StockHistoryDB>("StockHistory"); }
        }

        public IMongoCollection<FeedbackDB> Feedback
        {
            get { return database.GetCollection<FeedbackDB>("Feedback"); }
        }

        //added
        public IMongoCollection<Product> Product
        {
            get { return database.GetCollection<Product>("Products"); }
        }

        public async Task SeedSampleProductsAsync()
        {
            long existingCount = await Product.CountDocumentsAsync(FilterDefinition<Product>.Empty);
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

            await Product.InsertManyAsync(sampleProducts);
        }

        //backup indexes pag nawala database
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


        //    // Products: unique SKU
        //    var productIndex = new CreateIndexModel<ProductDB>(Builders<ProductDB>.IndexKeys.Ascending(x => x.SKU),new CreateIndexOptions { Unique = true });

        //    await Products.Indexes.CreateOneAsync(productIndex);

        //    // Carts: one cart per buyer
        //    var cartIndex = new CreateIndexModel<CartDB>(Builders<CartDB>.IndexKeys.Ascending(x => x.BuyerId),new CreateIndexOptions { Unique = true });

        //    await Carts.Indexes.CreateOneAsync(cartIndex);

        //    // Orders: unique order number
        //    var orderIndex = new CreateIndexModel<OrderDB>(Builders<OrderDB>.IndexKeys.Ascending(x => x.OrderNumber),new CreateIndexOptions { Unique = true });

        //    await Orders.Indexes.CreateOneAsync(orderIndex);

        //    // Payments: unique transaction reference
        //    var paymentIndex = new CreateIndexModel<PaymentDB>(Builders<PaymentDB>.IndexKeys.Ascending(x => x.TransactionReference),new CreateIndexOptions { Unique = true });

        //    await Payments.Indexes.CreateOneAsync(paymentIndex);

        //    // Feedback: one review per buyer, product, and order
        //    var feedbackIndex = new CreateIndexModel<FeedbackDB>(Builders<FeedbackDB>.IndexKeys.Ascending(x => x.BuyerId).Ascending(x => x.ProductId).Ascending(x => x.OrderId),new CreateIndexOptions { Unique = true });

        //    await Feedback.Indexes.CreateOneAsync(feedbackIndex);
        //}
    }
}
