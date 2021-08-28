using GeekShopping.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeekShopping.Web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts(string token);
        Task<ProductModel> FindProductById(long id, string token);
        Task<ProductModel> CreateProduct(ProductModel model, string token);
        Task<ProductModel> UpdateProduct(ProductModel model, string token);
        Task<bool> DeleteProductById(long id, string token);
    }
}
