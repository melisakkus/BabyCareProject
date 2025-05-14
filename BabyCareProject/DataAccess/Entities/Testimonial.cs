using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.DataAccess.Entities
{
    public class Testimonial : IEntity
    {
        public string ClientName { get; set; }
        public string Profession { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Comment { get; set; }
        public int ReviewStar { get; set; }

    }
}
