using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Services
{
    public class ProductService : IProductService
    {
        public Task CreatAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string idProduct)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetByIdAsync(string idProduct)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> ListByFilterAsync(string idProduct = null, string description = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
