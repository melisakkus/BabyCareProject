namespace BabyCareProject.Dtos.ServiceDtos
{
    public class UpdateServiceDto : IHasId
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
