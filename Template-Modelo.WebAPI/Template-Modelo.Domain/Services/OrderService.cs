using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Services
{
    public class OrderService : IOrderService
    {
        public Task CreateAsync(OrderModel order)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string IdOrder)
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderModel> GetByIdAsync(string IdOrder)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<OrderModel>> ListByFiltersAsync(string idOrder = null, string idClient = null, string idUser = null)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ClientModel order)
        {
            throw new System.NotImplementedException();
        }
    }
}
