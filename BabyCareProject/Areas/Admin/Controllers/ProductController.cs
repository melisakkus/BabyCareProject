﻿using BabyCareProject.Dtos.ProductDtos;
using BabyCareProject.Services.ImageServices;
using BabyCareProject.Services.InstructorServices;
using BabyCareProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IProductService _productService,IInstructorService _instructorService, IImageService _imageService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _productService.GetAllAsync();
            return View(values);
        }

        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CreateProduct()
        {
            var instructors = await _instructorService.GetAllInstructorAsync();
            ViewBag.Instructors = (from x in instructors
                                   select new SelectListItem
                                   {
                                       Text = x.FullName,
                                       Value = x.FullName
                                   }).ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            if (createProductDto.ImageFile != null)
            {
                createProductDto.ImageUrl = await _imageService.UploadImageAsync(createProductDto.ImageFile);
            }
            await _productService.CreateAsync(createProductDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateProduct (string id)
        {
            var instructors = await _instructorService.GetAllInstructorAsync();
            ViewBag.Instructors = (from x in instructors
                                   select new SelectListItem
                                   {
                                       Text = x.FullName,
                                       Value = x.FullName
                                   }).ToList();

            var value = await _productService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            if (updateProductDto.ImageFile != null)
            {
                updateProductDto.ImageUrl = await _imageService.UploadImageAsync(updateProductDto.ImageFile);
            }
            await _productService.UpdateAsync(updateProductDto);
            return RedirectToAction(nameof(Index));
        }

    }
}
