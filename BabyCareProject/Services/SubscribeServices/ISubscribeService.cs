using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.SubscribeDtos;

namespace BabyCareProject.Services.SubscribeServices
{
    public interface ISubscribeService : IRepository<CreateSubscribeDto,UpdateSubscribeDto,ResultSubscribeDto,Subscribe>
    {
    }
}
