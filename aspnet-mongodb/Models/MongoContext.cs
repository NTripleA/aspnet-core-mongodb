using aspnetmongodb.Properties;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace aspnetmongodb.Models
{
    public class MongoContext : IMongoContext
    {
        private readonly IMongoDatabase _db;
        public  MongoContext(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Visitor> Visitors => _db.GetCollection<Visitor>("Visitors");

    }
}
