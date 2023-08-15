using System;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using shopEntities.Concrete;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var result = _categoryService.GetCategories();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);

        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            var result = _categoryService.Add(category);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Put(Category category)
        {
            var result = _categoryService.Update(category);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);

        }

        [HttpDelete]
        public IActionResult Delete(Category category)
        {
            var result = _categoryService.Delete(category);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);
        }

    }
}

