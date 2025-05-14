namespace BabyCareProject.Dtos.GalleryDtos
{
    public class UpdateGalleryDto : IHasId
    {
        public string Id { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
