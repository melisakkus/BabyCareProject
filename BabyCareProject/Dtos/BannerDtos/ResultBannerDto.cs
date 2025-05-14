namespace BabyCareProject.Dtos.BannerDtos
{
    public class ResultBannerDto : IHasId
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
