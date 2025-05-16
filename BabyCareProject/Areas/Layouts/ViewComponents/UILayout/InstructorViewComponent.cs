using BabyCareProject.Services.InstructorServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "InstructorViewComponent")]
    public class InstructorViewComponent(IInstructorService _instructorService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _instructorService.GetAllInstructorAsync();
            return View(values);
        }
    }
}
