using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreatAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(string idProduct);
        Task<ProductModel> GetByIdAsync(string idProduct);
        Task<List<ProductModel>> ListByFilterAsync(string idProduct = null, string description = null);
        Task<bool> ExistsByIdAsync(string idProduct);
    }
}
