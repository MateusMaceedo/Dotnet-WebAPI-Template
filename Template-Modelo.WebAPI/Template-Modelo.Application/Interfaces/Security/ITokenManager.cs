using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Response.ClientResponse;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Application.Interfaces.Security
{
    public interface ITokenManager
    {
        Task<ReturnAuthResponse> GenerateTokenAsync(UserModel user);
    }
}
