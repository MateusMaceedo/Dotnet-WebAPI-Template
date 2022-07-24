using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Repositories;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Infra.Repository.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task CreatAsync(OrderModel order)
        {
            throw new System.NotImplementedException();
        }

        public Task CreatItemAsync(OrderItemModel item)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string idOrder)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteItemAsync(string idItem)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(string idOrder)
        {
            throw new System.NotImplementedException();
        }

        public Task<OrderModel> GetByIdAsync(string idOrder)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<OrderModel>> ListByFilterAsync(string idOrder = null, string idClient = null, string idUser = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<OrderItemModel>> ListItemByOrderIdAsync(string idOrder)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(OrderModel order)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateItemAsync(OrderItemModel item)
        {
            throw new System.NotImplementedException();
        }
    }
}
