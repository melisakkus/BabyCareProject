using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Dtos.ProductDtos;

namespace BabyCareProject.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAsync();
        Task<UpdateAboutDto> GetById(string id);
        Task CreateAsync(CreateAboutDto createAboutDto);
        Task UpdateAsync(UpdateAboutDto updateAboutDto);
        Task DeleteAsync(string id);
    }
}
