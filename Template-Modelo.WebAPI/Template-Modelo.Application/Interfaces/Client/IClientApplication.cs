using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Request;
using Template_Modelo.Application.Contract.Request.ClientRequest;
using Template_Modelo.Application.Contract.Response.ClientResponse;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Application
{
    public interface IClientApplication
    {
        Task<Response> CreateAsync(CreateClientRequest client);
        Task<Response<List<ClientResponse>>> ListByFilterAsync(string clientId, string name);
        Task<Response<ClientResponse>> GetByIdAsync(string clientId);
        Task<Response> UpdateAsync(UpdateClientRequest request);
        Task<Response> DeleteAsync(string clientId);
    }
}
