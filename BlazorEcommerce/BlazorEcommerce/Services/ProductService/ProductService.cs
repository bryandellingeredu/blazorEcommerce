
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace BlazorEcommerce.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int Id)
        {
            var product = await _context.Products.FindAsync(Id);
            var response = new ServiceResponse<Product>()
            {
                Data = product,
            };
            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var products = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>()
            {
                Data = products
            };
            return response;
        }
    }
}
