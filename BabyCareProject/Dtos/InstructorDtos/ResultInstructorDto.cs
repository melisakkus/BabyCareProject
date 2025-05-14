namespace BabyCareProject.Dtos.InstructorDtos
{
    public class ResultInstructorDto : IHasId
    {
        public string Id { get; set; }
        public string FullName => string.Join(" ", FirstName, LastName);
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
