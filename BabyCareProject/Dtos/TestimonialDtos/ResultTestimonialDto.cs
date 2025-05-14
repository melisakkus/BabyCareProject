namespace BabyCareProject.Dtos.TestimonialDtos
{
    public class ResultTestimonialDto : IHasId
    {
        public string Id { get; set; }
        public string ClientName { get; set; }
        public string Profession { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Comment { get; set; }
        public int ReviewStar { get; set; }
    }
}
