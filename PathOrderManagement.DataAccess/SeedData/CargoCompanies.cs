using CargoCompanyEntity = PathOrderManagement.Entity.DbPathOrderManagement.Cargo.CargoCompanies;

namespace PathOrderManagement.DataAccess.SeedData
{
    internal class CargoCompanies
    {
        internal static List<CargoCompanyEntity> companyList = new List<CargoCompanyEntity>
        {
            new CargoCompanyEntity
            {
                Id = Guid.Parse("09e6edd0-b037-47a4-abb3-97af0d33c7a1"),
                Name = "Yurtiçi Kargo"
            },

            new CargoCompanyEntity
            {
                Id= Guid.Parse("b24ae964-4c2a-488f-944a-f9c7c2433273"),
                Name = "Aras Kargo"
            }
        };
    }
}
