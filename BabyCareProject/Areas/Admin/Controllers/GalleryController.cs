using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.GalleryDtos;
using BabyCareProject.Services.GalleryServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class GalleryController(IGalleryService _galleryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _galleryService.GetAllAsync();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGalleryDto model)
        {
            await _galleryService.CreateAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _galleryService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(string id)
        {
            var value = await _galleryService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateGalleryDto dto)
        {
            await _galleryService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
