using Domain;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Product Product {get; set;}
        Task GetProducts();
        Task GetProduct(int id);
    }
}
