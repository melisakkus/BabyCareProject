using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.GalleryDtos;

namespace BabyCareProject.Services.GalleryServices
{
    public class GalleryService : GenericRepository<CreateGalleryDto, UpdateGalleryDto, ResultGalleryDto, Gallery>, IGalleryService
    {
        public GalleryService(IMapper mapper, IDatabaseSettings databaseSettings) : base(mapper, databaseSettings)
        {
        }
    }
}
