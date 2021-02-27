using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("Index")]
        public async Task<IActionResult> Index(int? pageNumber , int pageSize)
        {
            var model = await _productService.GetProductHomepagesPaginate(pageNumber == null ? 1  : pageNumber.Value, pageSize);
            var JsonModel = JsonConvert.SerializeObject(model);
            return Ok(JsonModel);
        }
        [HttpGet("ProductCount")]
        public async Task<IActionResult> ProductCount()
        {
            var model = await _productService.GetProductTopView();
            return Ok(model.Count);
        }
    }
}