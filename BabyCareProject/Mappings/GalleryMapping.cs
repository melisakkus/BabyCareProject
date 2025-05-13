using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.GalleryDtos;

namespace BabyCareProject.Mappings
{
    public class GalleryMapping : Profile
    {
        public GalleryMapping()
        {
            CreateMap<Gallery, CreateGalleryDto>().ReverseMap();
            CreateMap<Gallery, UpdateGalleryDto>().ReverseMap();
            CreateMap<Gallery, ResultGalleryDto>().ReverseMap();
        }
    }
}
