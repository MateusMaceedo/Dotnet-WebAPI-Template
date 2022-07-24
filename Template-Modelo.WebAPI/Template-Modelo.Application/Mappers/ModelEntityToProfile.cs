using AutoMapper;
using Template_Modelo.Application.Contract.Response.ClientResponse;
using Template_Modelo.Application.Contract.Response.OrderResponse;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Application.Mappers
{
    public class ModelEntityToProfile : Profile
    {
        public ModelEntityToProfile()
        {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<ClientModel, ReturnClientResponse>();

            CreateMap<OrderModel, ReturnOrderResponse>();
        }
    }
}
