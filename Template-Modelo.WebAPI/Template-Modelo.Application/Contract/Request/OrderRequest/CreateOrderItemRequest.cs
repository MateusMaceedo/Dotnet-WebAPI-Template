namespace Template_Modelo.Application.Contract.Request.OrderRequest
{
    public class CreateOrderItemRequest
    {
        public string ProductId { get; set; }
        public decimal SellValue { get; set; }
        public int Quantity { get; set; }
    }
}
