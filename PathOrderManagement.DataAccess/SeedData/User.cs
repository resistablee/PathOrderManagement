using PathOrderManagement.Entity.DbPathOrderManagement.User;
using UserEntity = PathOrderManagement.Entity.DbPathOrderManagement.User.User;

namespace PathOrderManagement.DataAccess.SeedData
{
    internal class User
    {
        internal static List<UserEntity> userList = new List<UserEntity>()
        {
            new UserEntity
            {
                Id = Guid.NewGuid(),
                UserType = UserType.SuperAdmin,
                Firstname = "SuperAdmin",
                Lastname = "Path",
                Email = "superadmin@path.com.tr",
                Phone = "0553 553 5353",
                Password = "super123"
            },

            new UserEntity
            {
                Id = Guid.NewGuid(),
                UserType = UserType.SystemAdmin,
                Firstname = "SystemAdmin",
                Lastname = "Path",
                Email = "systemadmin@path.com.tr",
                Phone = "0507 520 4582",
                Password = "system123"
            },

            new UserEntity 
            {
                Id = Guid.NewGuid(),
                UserType = UserType.Admin,
                Firstname = "Admin",
                Lastname = "Path",
                Email = "admin@path.com.tr",
                Phone = "0542 652 2358",
                Password = "admin123"
            },

            new UserEntity
            {
                Id = Guid.NewGuid(),
                UserType = UserType.Customer,
                Firstname = "Selman",
                Lastname = "KOYAN",
                Email = "resistablee7@hotmail.com",
                Phone = "0553 421 0543",
                Password = "123"
            }
        };
    }
}
