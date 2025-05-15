using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Services.ImageServices;
using BabyCareProject.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class TestimonialController(ITestimonialService _testimonialService, IImageService _imageService) : Controller
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
            if (model.ImageFile != null)
            {
                model.ImageUrl = await _imageService.UploadImageAsync(model.ImageFile);
            }
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
            if (dto.ImageFile != null)
            {
                dto.ImageUrl = await _imageService.UploadImageAsync(dto.ImageFile);
            }
            await _testimonialService.UpdateAsync(dto);
            return RedirectToAction("Index");
        }
    }
}
