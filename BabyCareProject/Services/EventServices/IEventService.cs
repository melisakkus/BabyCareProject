using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.EventDtos;

namespace BabyCareProject.Services.EventServices
{
    public interface IEventService : IRepository<CreateEventDto, UpdateEventDto, ResultEventDto,Event>
    {
    }
}
