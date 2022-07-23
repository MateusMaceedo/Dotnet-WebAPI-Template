using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Models;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task<Response> CreateAsync(ClientModel client);
        Task<Response> UpdateAsync(ClientModel client);
        Task<Response> DeleteAsync(string IdClient);
        Task<Response<ClientModel>> GetByIdAsync(string IdClient);
        Task<Response<List<ClientModel>>> ListByFiltersAsync(string idClient = null, string name = null);
    }
}
