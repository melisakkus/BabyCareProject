namespace BabyCareProject.Dtos.GalleryDtos
{
    public class ResultGalleryDto
    {
        public string GalleryId { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
