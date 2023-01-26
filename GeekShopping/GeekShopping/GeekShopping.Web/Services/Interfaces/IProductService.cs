using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetAll(string token);
        Task<ProductModel> GetProductById(int id, string token);
        Task<ProductModel> CreateProduct(ProductModel productModel, string token);
        Task<ProductModel> UpdateProduct(ProductModel productModel, string token);
        Task<bool> DeleteProductById(long id, string token);
    }
}
