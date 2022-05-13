using Microsoft.EntityFrameworkCore;
using PathOrderManagement.Entity.DbPathOrderManagement.Cargo;
using PathOrderManagement.Entity.DbPathOrderManagement.Order;
using PathOrderManagement.Entity.DbPathOrderManagement.User;

namespace PathOrderManagement.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<CargoCompanies> CargoCompanies { get; set; }
        public DbSet<CategoryCargo> CategoryCargo { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderCategory> OrderCategory { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region SeedData
            modelBuilder.Entity<User>().HasData(SeedData.User.userList);
            modelBuilder.Entity<OrderCategory>().HasData(SeedData.OrderCategory.categoryList);
            modelBuilder.Entity<CargoCompanies>().HasData(SeedData.CargoCompanies.companyList);
            modelBuilder.Entity<CategoryCargo>().HasData(SeedData.CategoryCargo.categoryList);
            #endregion
        }
    }
}
