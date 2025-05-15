using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Services.EventServices;
using BabyCareProject.Services.ImageServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController(IEventService _eventService, IImageService _imageService) : Controller
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
            if (model.ImageFile != null)
            {
                model.ImageUrl = await _imageService.UploadImageAsync(model.ImageFile);
            }
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
            if (dto.ImageFile != null)
            {
                dto.ImageUrl = await _imageService.UploadImageAsync(dto.ImageFile);
            }
            await _eventService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
