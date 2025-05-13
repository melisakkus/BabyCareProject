namespace BabyCareProject.Dtos.EventDtos
{
    public class CreateEventDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
    }
}
