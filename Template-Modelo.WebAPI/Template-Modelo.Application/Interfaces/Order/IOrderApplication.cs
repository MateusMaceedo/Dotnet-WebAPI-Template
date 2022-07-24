using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Request.OrderRequest;
using Template_Modelo.Application.Contract.Response.OrderResponse;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Application.Interfaces.Order
{
    public interface IOrderApplication
    {
        Task<Response> CreateAsync(CreateOrderRequest Order);
        Task<Response<List<ReturnOrderResponse>>> ListByFilterAsync(string orderId = null, string clientId = null, string userId = null);
        Task<Response<ReturnOrderResponse>> GetByIdAsync(string orderId);
    }
}
