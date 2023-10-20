using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductInventory.Models;
using ProductInventory.Services;

namespace ProductInventory.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IproductServices _services;
        public ProductController(IproductServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductRequest request)
        {
            AddProductResponse response =await _services.AddProductToInventory(request);
            return Ok(response);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            GetAllProductResponse response =await _services.GetAllProduct();
            return Ok(response);
        }
    }
}
