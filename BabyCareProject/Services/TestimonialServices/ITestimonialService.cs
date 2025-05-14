using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.TestimonialDtos;

namespace BabyCareProject.Services.TestimonialServices
{
    public interface ITestimonialService : IRepository<CreateTestimonialDto,UpdateTestimonialDto,ResultTestimonialDto,Testimonial>
    {
    }
}
