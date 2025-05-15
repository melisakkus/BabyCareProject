using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.BannerDtos;
using MongoDB.Driver;

namespace BabyCareProject.Services.BannerServices
{
    public class BannerService : GenericRepository<CreateBannerDto, UpdateBannerDto, ResultBannerDto, Banner>, IBannerService
    {
        public BannerService(IMapper mapper, IDatabaseSettings databaseSettings) : base(mapper, databaseSettings)
        {
        }
    }
}
