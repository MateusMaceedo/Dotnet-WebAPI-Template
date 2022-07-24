using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Domain.Services
{
    public class OrderService : IOrderService
    {
        public Task<Response> CreateAsync(OrderModel order)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response> DeleteAsync(string orderId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<OrderModel>> GetByIdAsync(string orderId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response<List<OrderModel>>> ListByFiltersAsync(string orderId = null, string clientId = null, string userId = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<Response> UpdateAsync(OrderModel order)
        {
            throw new System.NotImplementedException();
        }
    }
}
