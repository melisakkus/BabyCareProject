using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCareProject.DataAccess.Entities
{
    public class Gallery
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string GalleryId { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
