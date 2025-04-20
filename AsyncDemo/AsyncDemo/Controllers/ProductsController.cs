using AsyncDemo.Models;
using AsyncDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsyncDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;
        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<Product>> Get(int id, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProductAsync(id, cancellationToken);
            return Ok(product);
        }
    }
}
