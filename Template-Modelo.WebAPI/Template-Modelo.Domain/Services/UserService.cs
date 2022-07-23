using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Services
{
    public class UserService : IUserService
    {
        public Task<bool> AuthenticationAsync(UserModel user)
        {
            throw new System.NotImplementedException();
        }

        public Task CreatAsync(UserModel user)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string idUser)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> GetByIdAsync(string idUser)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserModel>> ListByFilterAsync(string idUser = null, string name = null)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(UserModel user)
        {
            throw new System.NotImplementedException();
        }
    }
}
