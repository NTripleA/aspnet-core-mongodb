using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace aspnetmongodb.Models
{
    public class Visitor
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("VisitorId")]
        public int VistiorId { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }

        public string toString(){
          return Name;
        }
    }
}
