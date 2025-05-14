using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.Dtos.TestimonialDtos;

namespace BabyCareProject.Services.TestimonialServices
{
    public class TestimonialService : GenericRepository<CreateTestimonialDto, UpdateTestimonialDto, ResultTestimonialDto, Testimonial>, ITestimonialService
    {
        public TestimonialService(IMapper mapper, IDatabaseSettings databaseSettings) : base(mapper, databaseSettings)
        {
        }
    }
}
