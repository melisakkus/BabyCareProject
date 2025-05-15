namespace BabyCareProject.Dtos.EventDtos
{
    public class UpdateEventDto : IHasId
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Location { get; set; }
        public DateTimeOffset Date { get; set; }
    }
}
