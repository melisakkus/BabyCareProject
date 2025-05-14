using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.BannerDtos;

namespace BabyCareProject.Services.BannerServices
{
    public interface IBannerService : IRepository<CreateBannerDto,UpdateBannerDto,ResultBannerDto,Banner>
    {
    }
}
