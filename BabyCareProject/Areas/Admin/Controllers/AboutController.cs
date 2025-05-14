using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutService _aboutService) : Controller
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
            await _aboutService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }

    }
}
