using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Request.UserRequest;
using Template_Modelo.Application.Contract.Response.ClientResponse;
using Template_Modelo.Application.Contract.Response.UserResponse;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Application.Interfaces.User
{
    public interface IUserApplication
    {
        Task<Response<Contract.Response.ClientResponse.ReturnAuthResponse>> AuthAsync(AuthRequest auth);
        Task<Response> CreateAsync(CreateUserRequest User);
        Task<Response<List<ReturnUserResponse>>> ListByFilterAsync(string userId = null, string name = null);
    }
}
