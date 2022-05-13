
namespace PathOrderManagement.Contract.App.Request.Cargo
{
    public class CreateCargoRequest
    {
        public Guid OrderID { get; set; }
        public string? TrackingNumber { get; set; }
    }
}
