using PathOrderManagement.Entity.DbPathOrderManagement.User;

namespace PathOrderManagement.Contract.App.Request.Login
{
    public class SignUpRequest
    {
        public UserType UserType { get; set; } //Kullanıcı tipi
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
