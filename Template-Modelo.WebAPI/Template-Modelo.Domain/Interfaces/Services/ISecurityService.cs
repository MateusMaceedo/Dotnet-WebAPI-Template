using System.Threading.Tasks;
using Template_Modelo.Domain.Models;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Domain.Interfaces.Services
{
    public interface ISecurityService
    {
        Task<Response<bool>> ComparePassword(string password, string confirmPassword);
        Task<Response<bool>> VerifyPassword(string password, UserModel user);
        Task<Response<string>> EncryptPassword(string password);
    }
}
