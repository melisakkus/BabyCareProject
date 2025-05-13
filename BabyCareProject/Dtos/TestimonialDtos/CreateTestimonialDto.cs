namespace BabyCareProject.Dtos.TestimonialDtos
{
    public class CreateTestimonialDto
    {
        public string ClientName { get; set; }
        public string Profession { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Comment { get; set; }
        public int ReviewStar { get; set; }
    }
}
