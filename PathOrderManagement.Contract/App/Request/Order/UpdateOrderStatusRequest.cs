using PathOrderManagement.Entity.DbPathOrderManagement.Order;

namespace PathOrderManagement.Contract.App.Request.Order
{
    public class UpdateOrderStatusRequest
    {
        public Guid Id { get; set; }
        public OrderStatus Status { get; set; }
    }
}
