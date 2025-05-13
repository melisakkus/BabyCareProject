using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.SubscribeDtos;

namespace BabyCareProject.Mappings
{
    public class SubscribeMapping : Profile
    {
        public SubscribeMapping() 
        {
            CreateMap<Subscribe,CreateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe,UpdateSubscribeDto>().ReverseMap();
            CreateMap<Subscribe,ResultSubscribeDto>().ReverseMap();
        }
    }
}
