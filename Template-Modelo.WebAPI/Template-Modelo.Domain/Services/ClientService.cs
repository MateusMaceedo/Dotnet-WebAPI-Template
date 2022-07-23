using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Domain.Interfaces.Repositories;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;
using Template_Modelo.Domain.Validations;
using Template_Modelo.Domain.Validations.Base;

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

        public async Task<Response> CreateAsync(ClientModel client)
        {
            var response = new Response();
            var validation = new ClientValidation();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0) return errors;

            _logger.LogInformation($"Criando Novo Cliente com as informações '{client}'");
            await _clientRepository.CreatAsync(client);

            return response;
        }

        public async Task<Response> DeleteAsync(string IdClient)
        {
            var response = new Response();

            var exists = await _clientRepository.ExistsByIdAsync(IdClient);

            if (!exists)
            {
                response.Report.Add(Report.Create($"Client {IdClient} not exists!"));
                return response;
            }

            _logger.LogInformation($"Deletando Cliente pelo Id'{IdClient}'");
            await _clientRepository.DeleteAsync(IdClient);

            return response;
        }

        public async Task<Response<ClientModel>> GetByIdAsync(string IdClient)
        {
            var response = new Response<ClientModel>();

            var exists = await _clientRepository.ExistsByIdAsync(IdClient);

            if (!exists)
            {
                response.Report.Add(Report.Create($"Client {IdClient} not exists!"));
                return response;
            }

            var data = await _clientRepository.GetByIdAsync(IdClient);
            response.Data = data;
            return response;
        }

        public async Task<Response<List<ClientModel>>> ListByFiltersAsync(string idClient = null, string name = null)
        {
            var response = new Response<List<ClientModel>>();

            if (!string.IsNullOrWhiteSpace(idClient))
            {
                var exists = await _clientRepository.ExistsByIdAsync(idClient);

                if (!exists)
                {
                    response.Report.Add(Report.Create($"Client {idClient} not exists!"));
                    return response;
                }
            }

            var data = await _clientRepository.ListByFilterAsync(idClient, name);
            response.Data = data;

            return response;
        }

        public async Task<Response> UpdateAsync(ClientModel client)
        {
            var response = new Response();

            var validation = new ClientValidation();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            var exists = await _clientRepository.ExistsByIdAsync(client.Id);

            if (!exists)
            {
                response.Report.Add(Report.Create($"Client {client.Id} not exists!"));
                return response;
            }

            await _clientRepository.UpdateAsync(client);

            return response;
        }
    }
}
