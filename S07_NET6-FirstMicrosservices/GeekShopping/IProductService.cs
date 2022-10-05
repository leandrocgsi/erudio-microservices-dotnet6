
using GeekShopping.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> FindAllProducts(string token);
        Task<ProductViewModel> FindProductById(long id, string token);
        Task<ProductViewModel> CreateProduct(ProductViewModel productModel, string token);
        Task<ProductViewModel> UpdateProduct(ProductViewModel productModel, string token);
        Task<bool> DeleteProductById(long id, string token);
    }
}