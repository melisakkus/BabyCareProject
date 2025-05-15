using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Services.AboutServices;
using BabyCareProject.Services.ImageServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutService _aboutService, IImageService _imageService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _aboutService.GetAllAsync();
            return View(values);
        }

        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto model)
        {
            if(model.ImageFile != null)
            {
                model.ImageUrl = await _imageService.UploadImageAsync(model.ImageFile);
            }
            await _aboutService.CreateAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAbout(string id)
        {
            await _aboutService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> UpdateAbout(string id)
        {
            var value = await _aboutService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto dto)
        {
            if (dto.ImageFile != null)
            {
                dto.ImageUrl = await _imageService.UploadImageAsync(dto.ImageFile);
            }
            await _aboutService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }

    }
}
