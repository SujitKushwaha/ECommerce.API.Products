using ECommerce.API.Products.Model;

namespace ECommerce.API.Products.Interface
{
    public interface IProductsProvider
    {
        Task<(bool IsSuccess, IEnumerable<Product> Products, string ErrorMessage)> GetProductsAsync();
    }
}
