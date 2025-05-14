using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class TestimonialController(ITestimonialService _testimonialService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _testimonialService.GetAllAsync();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateTestimonialDto model)
        {
            await _testimonialService.CreateAsync(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await _testimonialService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(string id)
        {
            var value = await _testimonialService.GetByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateTestimonialDto dto)
        {
            await _testimonialService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
