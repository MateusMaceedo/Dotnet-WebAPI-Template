using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task CreatAsync(OrderModel order);
        Task CreatItemAsync(OrderItemModel item);
        Task UpdateAsync(OrderModel order);
        Task UpdateItemAsync(OrderItemModel item);
        Task DeleteAsync(string idOrder);
        Task DeleteItemAsync(string idItem);
        Task<OrderModel> GetByIdAsync(string idOrder);
        Task<List<OrderModel>> ListByFilterAsync(string idOrder = null, string idClient = null, string idUser = null);
        Task<List<OrderItemModel>> ListItemByOrderIdAsync(string idOrder);
        Task<bool> ExistsByIdAsync(string idOrder);
    }
}
