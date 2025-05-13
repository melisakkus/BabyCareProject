using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.InformationDtos;

namespace BabyCareProject.Mappings
{
    public class InformationMapping : Profile
    {
        public InformationMapping() 
        {
            CreateMap<Information,CreateInformationDto>().ReverseMap();
            CreateMap<Information,UpdateInformationDto>().ReverseMap();
            CreateMap<Information,ResultInformationDto>().ReverseMap();
        }
    }
}
