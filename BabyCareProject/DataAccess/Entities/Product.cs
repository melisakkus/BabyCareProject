using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Product : IEntity
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        [BsonIgnore]
        public IFormFile ImageFile { get; set; }
        public string InstructorName { get; set; }

    }
}
