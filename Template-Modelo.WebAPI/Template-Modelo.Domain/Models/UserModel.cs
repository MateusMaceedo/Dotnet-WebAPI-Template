namespace Template_Modelo.Domain.Models
{
    public class UserModel : EntityBase
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string PasswordHash{ get; set; }
    }
}
