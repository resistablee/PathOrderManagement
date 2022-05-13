using PathOrderManagement.Entity.DbPathOrderManagement.Order;

namespace PathOrderManagement.Contract.App.Response.Order
{
    public class OrderResponse
    {
        public Guid Id { get; set; }
        public string Customer { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
    }
}
