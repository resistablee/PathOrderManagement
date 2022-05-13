
namespace PathOrderManagement.Contract.App.Request.Order
{
    public class CreateOrderRequest
    {
        public Guid CustomerID { get; set; }
        public Guid CategoryID { get; set; }
        public string OrderNumber { get; set; }
        public decimal Total { get; set; }
    }
}
