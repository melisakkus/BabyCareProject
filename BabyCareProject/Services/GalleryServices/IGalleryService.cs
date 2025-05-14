using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.GalleryDtos;

namespace BabyCareProject.Services.GalleryServices
{
    public interface IGalleryService : IRepository<CreateGalleryDto,UpdateGalleryDto,ResultGalleryDto,Gallery>
    {
    }
}
