using BabyCareProject.Services.InstructorServices;
using BabyCareProject.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "TestimonialViewComponent")]

    public class TestimonialViewComponent(ITestimonialService _testimonialService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllAsync();
            return View(values);
        }
    }
}
