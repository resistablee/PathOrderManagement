using PathOrderManagement.Entity.DbPathOrderManagement.Base;

namespace PathOrderManagement.Entity.DbPathOrderManagement.Cargo
{
    public class Cargo : SoftDeleteEntity
    {
        public Guid OrderID { get; set; }
        public Guid CompanyID { get; set; }
        public CargoStatus Status { get; set; } = CargoStatus.Receipt;
        public string? TrackingNumber { get; set; }

        public virtual Order.Order Order { get; set; }
        public virtual CargoCompanies Company { get; set; }
    }
}
