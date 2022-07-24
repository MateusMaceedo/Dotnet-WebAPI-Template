using AutoMapper;
using Template_Modelo.Application.Contract.Request;
using Template_Modelo.Application.Contract.Request.OrderRequest;
using Template_Modelo.Domain.Models;

namespace Template_Modelo.Application.Mappers
{
    public class EntityToModelProfile : Profile
    {
        public EntityToModelProfile()
        {
            ClientMap();
        }

        private void ClientMap()
        {
            CreateMap<CreateClientRequest, ClientModel>();

            CreateMap<CreateOrderRequest, OrderModel>();
        }
    }
}
