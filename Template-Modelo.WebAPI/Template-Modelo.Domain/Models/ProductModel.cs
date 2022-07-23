namespace Template_Modelo.Domain.Models
{
    public class ProductModel : EntityBase
    {
        public string Description { get; set; }
        public string SelValue { get; set; }
        public int Stock { get; set; }
    }
}
