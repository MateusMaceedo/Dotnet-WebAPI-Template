using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task CreatAsync(UserModel user);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(string idUser);
        Task<UserModel> GetByIdAsync(string idUser);
        Task<List<UserModel>> ListByFilterAsync(string idUser = null, string name = null);
        Task<bool> ExistsByIdAsync(string idUser);
        Task<bool> ExistsByLoginAsync(string login);
    }
}
