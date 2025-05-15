namespace BabyCareProject.Services.ImageServices
{
    public interface IImageService
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}
