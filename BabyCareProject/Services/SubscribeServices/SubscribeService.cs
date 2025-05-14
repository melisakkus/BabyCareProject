using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.SubscribeDtos;

namespace BabyCareProject.Services.SubscribeServices
{
    public class SubscribeService : GenericRepository<CreateSubscribeDto, UpdateSubscribeDto, ResultSubscribeDto, Subscribe>, ISubscribeService
    {
        public SubscribeService(IMapper mapper, IDatabaseSettings databaseSettings) : base(mapper, databaseSettings)
        {
        }
    }
}
