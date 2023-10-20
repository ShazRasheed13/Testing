using MongoDB.Driver;
using ProductInventory.Models;

namespace ProductInventory.DAL
{
    public class MongoDb
    {
        private IConfiguration _configuration;
        public MongoClient _mongoClient;
        public IMongoCollection<AddProductRequest> _MongoCollection;

        public MongoDb(IConfiguration configuration)
        {
            _configuration = configuration;
            _mongoClient = new MongoClient(_configuration["DatabaseSettings:ConnectionString"]);
            var _MongoDb = _mongoClient.GetDatabase(_configuration["DatabaseSettings:DatabaseName"]);
            _MongoCollection = _MongoDb.GetCollection<AddProductRequest>(_configuration["DatabaseSettings:CollectionName"]);
        }
    }
}
