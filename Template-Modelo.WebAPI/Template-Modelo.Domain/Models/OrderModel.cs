using System.Collections.Generic;

namespace Template_Modelo.Domain.Models
{
    public class OrderModel : EntityBase
    {
        public ClientModel Client { get; set; }
        public UserModel User { get; set; }
        public List<OrderItemModel> Items { get; set; }
    }
}
