using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Request.ProductRequest;
using Template_Modelo.Application.Contract.Response.ProductResponse;
using Template_Modelo.Application.Interfaces.Product;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Application.Applications
{
    public class ProductApplication : IProductApplication
    {
        public Task<Response> CreateAsync(CreateProductRequest Product)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<List<ReturnProductResponse>>> ListByFilterAsync(string productId = null, string description = null)
        {
            throw new System.NotImplementedException();
        }
    }
}
