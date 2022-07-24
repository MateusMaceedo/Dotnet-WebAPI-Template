using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Repositories;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Infra.Repository.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public Task CreatAsync(ClientModel client)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(string idClient)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ExistsByIdAsync(string idClient)
        {
            throw new System.NotImplementedException();
        }

        public Task<ClientModel> GetByIdAsync(string idClient)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ClientModel>> ListByFilterAsync(string idClient = null, string name = null)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new System.NotImplementedException();
        }
    }
}
