namespace Template_Modelo.Application.Contract.Response.UserResponse
{
    public class ReturnAuthResponse
    {
        public string Token { get; set; }
        public string Type { get; set; }
        public int ExpireIn { get; set; }
    }
}
