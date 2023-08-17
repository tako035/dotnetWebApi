using System;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductSpecsController : ControllerBase
    {
        IProductSpecsService _productSpecsService;

        public ProductSpecsController(IProductSpecsService productSpecsService)
        {

            _productSpecsService = productSpecsService;
        }

        [HttpGet]
        public IActionResult GetProductSpecs()
        {
            var result = _productSpecsService.GetProductSpecs();
            if (result.Success)
                return Ok(result.Data);
            return BadRequest(result.Message);
        }
    }
}

