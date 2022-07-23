using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Repositories;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Domain.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly ILogger<ClientService> _logger;

        public ClientService(
            ILogger<ClientService> logger, 
            IClientRepository clientRepository)
        {
            _logger = logger;
            _clientRepository = clientRepository;
        }

        public async Task CreateAsync(ClientModel client)
        {
            _logger.LogInformation($"Criando Novo Cliente com as informações '{client}'");
            await _clientRepository.CreatAsync(client);
        }

        public Task DeleteAsync(string IdClient)
        {
            throw new System.NotImplementedException();
        }

        public Task<ClientModel> GetByIdAsync(string IdClient)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ClientModel>> ListByFiltersAsync(string idClient = null, string name = null)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(ClientModel client)
        {
            throw new System.NotImplementedException();
        }
    }
}
