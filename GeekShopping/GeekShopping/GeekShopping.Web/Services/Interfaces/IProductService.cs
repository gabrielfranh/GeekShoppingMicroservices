using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAll(string token);
        Task<ProductViewModel> GetProductById(int id, string token);
        Task<ProductViewModel> CreateProduct(ProductViewModel productModel, string token);
        Task<ProductViewModel> UpdateProduct(ProductViewModel productModel, string token);
        Task<bool> DeleteProductById(long id, string token);
    }
}
