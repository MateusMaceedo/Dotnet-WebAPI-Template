using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task CreatAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task DeleteAsync(string idClient);
        Task<bool> ExistsByIdAsync(string idClient);
        Task<ClientModel> GetByIdAsync(string idClient);
        Task<List<ClientModel>> ListByFilterAsync(string idClient = null, string name = null);
    }
}
