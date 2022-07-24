using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_Modelo.Application.Contract.Request.OrderRequest;
using Template_Modelo.Application.Contract.Response.OrderResponse;
using Template_Modelo.Application.Interfaces.Order;
using Template_Modelo.Domain.Interfaces.Services;
using Template_Modelo.Domain.Models;
using Template_Modelo.Domain.Validations.Base;

namespace Template_Modelo.Application.Applications
{
    public class OrderApplication : IOrderApplication
    {
        private readonly IOrderService _OrderService;
        private readonly IMapper _mapper;

        public OrderApplication(
            IOrderService OrderService, 
            IMapper mapper)
        {
            _OrderService = OrderService;
            _mapper = mapper;
        }

        public async Task<Response> CreateAsync(CreateOrderRequest Order)
        {
            try
            {
                var OrderModel = _mapper.Map<OrderModel>(Order);

                return await _OrderService.CreateAsync(OrderModel);
            }
            catch (Exception ex)
            {
                var response = Report.Create(ex.Message);

                return Response.Unprocessable(response);
            }
        }

        public async Task<Response<ReturnOrderResponse>> GetByIdAsync(string orderId)
        {
            Response<OrderModel> user = await _OrderService.GetByIdAsync(orderId);

            if (user.Report.Any())
                return Response.Unprocessable<ReturnOrderResponse>(user.Report);

            var response = _mapper.Map<ReturnOrderResponse>(user.Data);

            return Response.OK(response);
        }

        public async Task<Response<List<ReturnOrderResponse>>> ListByFilterAsync(string orderId = null, string clientId = null, string userId = null)
        {
            Response<List<OrderModel>> user = await _OrderService.ListByFiltersAsync(orderId, clientId, userId);

            if (user.Report.Any())
                return Response.Unprocessable<List<ReturnOrderResponse>>(user.Report);

            var response = _mapper.Map<List<ReturnOrderResponse>>(user.Data);

            return Response.OK(response);
        }
    }
}
