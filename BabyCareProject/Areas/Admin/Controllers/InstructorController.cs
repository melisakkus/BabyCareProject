using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Services.ImageServices;
using BabyCareProject.Services.InstructorServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class InstructorController(IInstructorService _instructorService, IImageService _imageService) : Controller
	{
		public async Task<IActionResult> Index()
		{
			var values = await _instructorService.GetAllInstructorAsync();
			return View(values);
		}

		public IActionResult CreateInstructor()
		{
			return View();
		}
		
		[HttpPost]
		public async Task<IActionResult> CreateInstructor(CreateInstructorDto createInstructorDto)
		{
            if (createInstructorDto.ImageFile != null)
            {
                createInstructorDto.ImageUrl = await _imageService.UploadImageAsync(createInstructorDto.ImageFile);
            }
            await _instructorService.CreateInstructorAsync(createInstructorDto);
			return RedirectToAction("Index");	
		}

		public async Task<IActionResult> DeleteInstructor(string id)
		{
			await _instructorService.DeleteInstructorAsync(id);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> UpdateInstructor(string id)
		{
			var value = await _instructorService.GetInstructorByIdAsync(id);
			return View(value);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateInstructor(UpdateInstructorDto updateInstructorDto)
		{
            if (updateInstructorDto.ImageFile != null)
            {
                updateInstructorDto.ImageUrl = await _imageService.UploadImageAsync(updateInstructorDto.ImageFile);
            }
            await _instructorService.UpdateInstructorAsync(updateInstructorDto);
			return RedirectToAction("Index");
		}

	}
}
