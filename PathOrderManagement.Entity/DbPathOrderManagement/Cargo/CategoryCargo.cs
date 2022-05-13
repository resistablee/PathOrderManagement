using PathOrderManagement.Entity.DbPathOrderManagement.Order;

namespace PathOrderManagement.Entity.DbPathOrderManagement.Cargo
{
    public class CategoryCargo : Base.SoftDeleteEntity
    {
        public Guid CategoryID { get; set; }
        public Guid CompanyID { get; set; }

        public virtual OrderCategory Category { get; set; }
        public virtual CargoCompanies Company { get; set; }
    }
}
