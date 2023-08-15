using System;
using shopEntities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Microsoft.AspNetCore.Authorization;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        //[Authorize(Roles = "Product.List")]
        public IActionResult GetProducts()
        {
            var result = _productService.GetProducts();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpGet("category/{category_id}")]
        public IActionResult GetListByCategory(int category_id)
        {
            var result = _productService.GetListByCategory(category_id);
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Success)
                return Ok(result.Message);
            return BadRequest(result.Message);
        }
    }
}

