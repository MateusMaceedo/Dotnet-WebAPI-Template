using System.Collections.Generic;

namespace Template_Modelo.Application.Contract.Request.OrderRequest
{
    public class CreateOrderRequest
    {
        public string ClientId { get; set; }
        public string UserId { get; set; }
        public List<CreateOrderItemRequest> Items { get; set; }
    }
}
