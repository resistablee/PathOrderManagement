using CategoryCargoEntity = PathOrderManagement.Entity.DbPathOrderManagement.Cargo.CategoryCargo;

namespace PathOrderManagement.DataAccess.SeedData
{
    internal class CategoryCargo
    {
        internal static List<CategoryCargoEntity> categoryList = new List<CategoryCargoEntity>
        {
            new CategoryCargoEntity()
            {
                Id = Guid.NewGuid(),
                CategoryID = Guid.Parse("b3817af4-5107-4c39-99f9-37595c7bda31"),
                CompanyID = Guid.Parse("b24ae964-4c2a-488f-944a-f9c7c2433273")
            },

            new CategoryCargoEntity()
            {
                Id = Guid.NewGuid(),
                CategoryID = Guid.Parse("66ca47cb-774f-4de4-b83f-f0a5135e1e53"),
                CompanyID = Guid.Parse("09e6edd0-b037-47a4-abb3-97af0d33c7a1")
            }
        };
    }
}
