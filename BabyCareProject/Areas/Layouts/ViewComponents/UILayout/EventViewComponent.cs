using BabyCareProject.Services.EventServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Layouts.ViewComponents.UILayout
{
    [ViewComponent(Name = "EventViewComponent")]
    public class EventViewComponent(IEventService _eventService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _eventService.GetAllAsync();
            return View(values);
        }

    }
}
