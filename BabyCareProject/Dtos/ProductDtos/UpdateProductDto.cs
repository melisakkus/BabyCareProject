namespace BabyCareProject.Dtos.ProductDtos
{
    public class UpdateProductDto : IHasId
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string InstructorName { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
