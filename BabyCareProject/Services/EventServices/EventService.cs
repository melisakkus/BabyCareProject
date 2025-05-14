using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.EventDtos;

namespace BabyCareProject.Services.EventServices
{
    public class EventService : GenericRepository<CreateEventDto, UpdateEventDto, ResultEventDto, Event>, IEventService
    {
        public EventService(IMapper mapper, IDatabaseSettings databaseSettings) : base(mapper, databaseSettings)
        {
        }
    }
}
