using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.ServiceDtos;

namespace BabyCareProject.Mappings
{
    public class ServiceMapping : Profile
    {
        public ServiceMapping() 
        {
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, ResultServiceDto>().ReverseMap();

        }
    }
}
