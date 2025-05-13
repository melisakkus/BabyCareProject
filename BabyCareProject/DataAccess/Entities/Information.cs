using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCareProject.DataAccess.Entities
{
    public class Information
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string InformationId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string SocailMedia1 { get; set; }
        public string SocailMedia2 { get; set; }
        public string SocailMedia3 { get; set; }
    }
}
