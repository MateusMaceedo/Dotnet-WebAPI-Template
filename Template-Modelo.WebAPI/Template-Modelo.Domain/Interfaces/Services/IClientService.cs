using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task CreateAsync(ClientModel client);
        Task UpdateAsync(ClientModel client);
        Task DeleteAsync(string IdClient);
        Task<ClientModel> GetByIdAsync(string IdClient);
        Task<List<ClientModel>> ListByFiltersAsync(string idClient = null, string name = null);
    }
}
