using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.ServiceDtos;

namespace BabyCareProject.Services.ServiceServices
{
    public interface IServiceService : IRepository<CreateServiceDto,UpdateServiceDto,ResultServiceDto,Service>
    {
    }
}
