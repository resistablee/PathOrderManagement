
namespace PathOrderManagement.Contract.App.Response.Login
{
    public class GetTokenResponse
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int? ExpiresIn { get; set; }
        public DateTime RefreshTokenExpireDate { get; set; }
    }
}
