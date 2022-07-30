using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Request;
using Template_Modelo.Application.Contract.Request.ClientRequest;
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
            try
            {
                var clientModel = _mapper.Map<ClientModel>(client);

                return await _clientService.CreateAsync(clientModel);
            }
            catch (Exception ex)
            {
                var response = Report.Create(ex.Message);

                return Response.Unprocessable(response);
            }
        }

        public async Task<Response> DeleteAsync(string clientId)
        {
            return await _clientService.DeleteAsync(clientId);
        }

        public async Task<Response<ClientResponse>> GetByIdAsync(string clientId)
        {
            Response<ClientModel> client = await _clientService.GetByIdAsync(clientId);

            if (client.Report.Any())
                return Response.Unprocessable<ClientResponse>(client.Report);

            var response = _mapper.Map<ClientResponse>(client.Data);

            return Response.OK(response);
        }

        public async Task<Response<List<ClientResponse>>> ListByFilterAsync(string clientId, string name)
        {
            Response<List<ClientModel>> client = await _clientService.ListByFiltersAsync(clientId, name);

            if (client.Report.Any())
                return Response.Unprocessable<List<ClientResponse>>(client.Report);

            var response = _mapper.Map<List<ClientResponse>>(client.Data);

            return Response.OK(response);
        }

        public async Task<Response> UpdateAsync(UpdateClientRequest request)
        {
            var clientModel = _mapper.Map<ClientModel>(request);

            return await _clientService.UpdateAsync(clientModel);
        }
    }
}
