using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Request;
using Template_Modelo.Application.Contract.Response.ClientResponse;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Application.Applications
{
    public class ClientApplication : IClientApplication
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientApplication(
            IClientService clientService, 
            IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        public async Task<Response> CreateAsync(CreateClientRequest client)
        {
            var clientModel = _mapper.Map<ClientModel>(client);

            return await _clientService.CreateAsync(clientModel);
        }

        public Task<Response<List<ReturnClientResponse>>> ListByFilterAsync(string clientId, string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
