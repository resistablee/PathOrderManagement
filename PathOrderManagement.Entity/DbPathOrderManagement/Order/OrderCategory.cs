using PathOrderManagement.Entity.DbPathOrderManagement.Base;
using PathOrderManagement.Entity.DbPathOrderManagement.Cargo;

namespace PathOrderManagement.Entity.DbPathOrderManagement.Order
{
    public class OrderCategory : SoftDeleteEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CategoryCargo> CategoryCargos { get; set; }
    }
}
