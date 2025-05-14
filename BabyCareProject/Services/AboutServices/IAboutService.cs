using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Dtos.ProductDtos;

namespace BabyCareProject.Services.AboutServices
{
    public interface IAboutService : IRepository<CreateAboutDto,UpdateAboutDto,ResultAboutDto,About>
    {
    }
}
