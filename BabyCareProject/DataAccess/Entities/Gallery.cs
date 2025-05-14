using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCareProject.DataAccess.Entities
{
    public class Gallery : IEntity
    {
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
