using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.InformationDtos;

namespace BabyCareProject.Services.InformationServices
{
    public interface IInformationService : IRepository<CreateInformationDto,UpdateInformationDto,ResultInformationDto,Information>
    {
    }
}
