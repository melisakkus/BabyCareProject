using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.TestimonialDtos;

namespace BabyCareProject.Mappings
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
        }            
    }
}
