using PathOrderManagement.Entity.DbPathOrderManagement.Base;

namespace PathOrderManagement.Entity.DbPathOrderManagement.Order
{
    public class Order : SoftDeleteEntity
    {
        public Guid CustomerID { get; set; }
        public Guid CategoryID { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Receipt;
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal Total { get; set; }

        public virtual User.User Customer { get; set; }
        public virtual OrderCategory Category { get; set; }

        public virtual ICollection<Cargo.Cargo> Cargo { get; set; }
    }
}
