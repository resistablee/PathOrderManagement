
namespace PathOrderManagement.Entity.DbPathOrderManagement.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
