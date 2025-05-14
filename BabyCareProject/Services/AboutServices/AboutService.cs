using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.AboutDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.AboutServices
{
    public class AboutService : GenericRepository<CreateAboutDto, UpdateAboutDto, ResultAboutDto, About>, IAboutService
    {
        public AboutService(IMapper mapper, IDatabaseSettings databaseSettings) : base(mapper, databaseSettings)
        {
        }
    }
}