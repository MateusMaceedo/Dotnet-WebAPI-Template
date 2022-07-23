using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Task CreateAsync(OrderModel order);
        Task UpdateAsync(ClientModel order);
        Task DeleteAsync(string IdOrder);
        Task<OrderModel> GetByIdAsync(string IdOrder);
        Task<List<OrderModel>> ListByFiltersAsync(string idOrder = null, string idClient = null, string idUser = null);
    }
}
