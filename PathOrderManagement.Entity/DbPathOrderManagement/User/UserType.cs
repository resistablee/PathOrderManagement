
using System.ComponentModel.DataAnnotations;

namespace PathOrderManagement.Entity.DbPathOrderManagement.User
{
    public enum UserType
    {
        [Display(Name = "Super Admin")]
        SuperAdmin = 1,

        [Display(Name = "System Admin")]
        SystemAdmin = 2, //Üst yönetici olarak kullanılacak

        [Display(Name = "Admin")]
        Admin = 3,

        [Display(Name = "Customer")]
        Customer = 4
    }
}
