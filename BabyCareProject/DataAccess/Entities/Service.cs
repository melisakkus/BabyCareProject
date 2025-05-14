using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Service : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        
    }
}
