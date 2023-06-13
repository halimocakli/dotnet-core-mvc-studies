namespace CodeFirst_One_To_Many_Relationship.Models
{
    public class Order : BaseEntity
    {
        // Foreign Key for Order - AppUser : ONE-TO-MANY relationship.
        public int AppUserId { get; set; }

        // Relational Property
        public virtual AppUser AppUser { get; set; }
    }
}
