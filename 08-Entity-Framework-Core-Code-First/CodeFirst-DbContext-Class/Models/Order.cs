namespace CodeFirst_DbContext_Class.Models
{
    public class Order : BaseEntity
    {
        // Foreign Key for Order - AppUser : ONE-TO-MANY relationship.
        public int AppUserId { get; set; }

        // Relational Property
        public virtual AppUser AppUser { get; set; }
    }
}
