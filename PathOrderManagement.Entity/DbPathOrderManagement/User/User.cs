using PathOrderManagement.Entity.DbPathOrderManagement.Base;

namespace PathOrderManagement.Entity.DbPathOrderManagement.User
{
    public class User : SoftDeleteEntity
    {
        public UserType UserType { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpireDate { get; set; }

        public virtual ICollection<Order.Order> Orders { get; set; }
    }
}
