using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.InformationDtos;

namespace BabyCareProject.Services.InformationServices
{
    public class InformationService : GenericRepository<CreateInformationDto, UpdateInformationDto, ResultInformationDto, Information>, IInformationService
    {
        public InformationService(IMapper mapper, IDatabaseSettings databaseSettings) : base(mapper, databaseSettings)
        {
        }
    }
}
