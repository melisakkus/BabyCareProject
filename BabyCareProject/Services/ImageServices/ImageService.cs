﻿
using System.ComponentModel.DataAnnotations;

namespace BabyCareProject.Services.ImageServices
{
    public class ImageService : IImageService
    {
        public async Task<string> UploadImageAsync(IFormFile file)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
            {
                throw new ValidationException("Dosya formatı resim olmalıdır.");
            }
            var imageName = Guid.NewGuid() + extension;
            var imageFolder = Path.Combine(currentDirectory, "wwwroot/images");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }

            var saveLocation = Path.Combine(imageFolder, imageName);
            var stream = new FileStream(saveLocation, FileMode.Create);
            await file.CopyToAsync(stream);
            return "/images/" + imageName;

        }
    }
}
