using BlazorEcommerce.Services.ProductService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace BlazorEcommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _productService;
        public ProductsController(IProductService productService) => _productService = productService;
      
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts() =>
           Ok(await _productService.GetProductsAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int id) =>
            Ok(await _productService.GetProductAsync(id));

    }
}
