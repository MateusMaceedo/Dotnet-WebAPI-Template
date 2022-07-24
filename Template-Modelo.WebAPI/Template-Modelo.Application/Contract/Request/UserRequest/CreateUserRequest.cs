namespace Template_Modelo.Application.Contract.Request.UserRequest
{
    public class CreateUserRequest
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
