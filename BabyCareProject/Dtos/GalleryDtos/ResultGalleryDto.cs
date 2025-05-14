namespace BabyCareProject.Dtos.GalleryDtos
{
    public class ResultGalleryDto : IHasId
    {
        public string Id { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
