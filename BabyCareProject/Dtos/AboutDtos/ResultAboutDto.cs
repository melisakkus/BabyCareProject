namespace BabyCareProject.Dtos.AboutDtos
{
    public class ResultAboutDto
    {
        public string AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Items { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
