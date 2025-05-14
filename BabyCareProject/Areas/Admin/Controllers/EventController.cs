using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Services.EventServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController(IEventService _eventService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _eventService.GetAllAsync();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateEventDto model)
        {
            await _eventService.CreateAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _eventService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(string id)
        {
            var value = await _eventService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateEventDto dto)
        {
            await _eventService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
