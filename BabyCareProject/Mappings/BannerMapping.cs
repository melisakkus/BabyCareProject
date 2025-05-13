using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.EventDtos;

namespace BabyCareProject.Mappings
{
    public class BannerMapping : Profile
    {
        public BannerMapping() 
        {
            CreateMap<Banner, ResultBannerDto>().ReverseMap();
            CreateMap<Banner, UpdateBannerDto>().ReverseMap();
            CreateMap<Banner, CreateBannerDto>().ReverseMap();
        }
    }
}
