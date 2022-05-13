
namespace PathOrderManagement.Entity.DbPathOrderManagement.Cargo
{
    public class CargoCompanies : Base.SoftDeleteEntity
    {
        public string Name { get; set; }

        public virtual ICollection<CategoryCargo> CategoryCargos { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
    }
}
