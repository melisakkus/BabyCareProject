using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.ServiceDtos;

namespace BabyCareProject.Services.ServiceServices
{
    public class ServiceService : GenericRepository<CreateServiceDto, UpdateServiceDto, ResultServiceDto, Service>, IServiceService
    {
        public ServiceService(IMapper mapper, IDatabaseSettings databaseSettings) : base(mapper, databaseSettings)
        {
        }
    }
}
