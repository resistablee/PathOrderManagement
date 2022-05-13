
using OrderCategoryEntity = PathOrderManagement.Entity.DbPathOrderManagement.Order.OrderCategory;

namespace PathOrderManagement.DataAccess.SeedData
{
    internal class OrderCategory
    {
        internal static List<OrderCategoryEntity> categoryList = new List<OrderCategoryEntity>
        {
            new OrderCategoryEntity()
            {
                Id = Guid.Parse("b3817af4-5107-4c39-99f9-37595c7bda31"),
                Name = "Giyim"
            },

            new OrderCategoryEntity()
            {
                Id= Guid.Parse("66ca47cb-774f-4de4-b83f-f0a5135e1e53"),
                Name = "Gıda"
            }
        };
    }
}
