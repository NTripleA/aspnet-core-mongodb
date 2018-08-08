using MongoDB.Driver;

namespace aspnetmongodb.Models
{
    public interface IMongoContext
    {
        IMongoCollection<Visitor> Visitors { get; }
    }
}