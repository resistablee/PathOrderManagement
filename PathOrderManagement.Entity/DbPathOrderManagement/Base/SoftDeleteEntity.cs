namespace PathOrderManagement.Entity.DbPathOrderManagement.Base
{
    public class SoftDeleteEntity : BaseEntity
    {
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedOn { get; set; }
    }
}
