using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Subscribe : IEntity
    {
        public string Email { get; set; }
    }
}
