using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Repositories;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Infra.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreatAsync(ProductModel product)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string idProduct)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(string idProduct)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductModel> GetByIdAsync(string idProduct)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ProductModel>> ListByFilterAsync(string idProduct = null, string description = null)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ProductModel product)
        {
            throw new System.NotImplementedException();
        }
    }
}
