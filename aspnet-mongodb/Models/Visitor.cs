using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace aspnetmongodb.Models
{
    public class Visitor
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; }
    }
}
