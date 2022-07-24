using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Request.UserRequest;
using Template_Modelo.Application.Contract.Response.UserResponse;
using Template_Modelo.Application.Interfaces.User;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Application.Applications
{
    public class UserApplication : IUserApplication
    {
        public Task<Response<Contract.Response.ClientResponse.ReturnAuthResponse>> AuthAsync(AuthRequest auth)
        {
            throw new NotImplementedException();
        }

        public Task<Response> CreateAsync(CreateUserRequest User)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ReturnUserResponse>>> ListByFilterAsync(string userId = null, string name = null)
        {
            throw new NotImplementedException();
        }

        Task<Response<Contract.Response.ClientResponse.ReturnAuthResponse>> IUserApplication.AuthAsync(AuthRequest auth)
        {
            throw new NotImplementedException();
        }
    }
}
