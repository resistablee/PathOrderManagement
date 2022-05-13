using PathOrderManagement.Entity.DbPathOrderManagement.Cargo;

namespace PathOrderManagement.Contract.App.Response.Cargo
{
    public class CargoResponse
    {
        public Guid Id { get; set; }
        public Guid OrderID { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public string Status { get; set; }
        public string? TrackingNumber { get; set; }
    }
}
