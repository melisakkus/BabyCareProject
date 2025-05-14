using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCareProject.DataAccess.Entities
{
    public abstract class IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
    }
}
