using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Repositories;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Infra.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task CreatAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string idUser)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(string idUser)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsByLoginAsync(string login)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetByIdAsync(string idUser)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> ListByFilterAsync(string idUser = null, string name = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
