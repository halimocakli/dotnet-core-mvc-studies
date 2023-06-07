using System.Collections.Generic;

namespace CodeFirst_Many_To_Many_Relationship.Models
{
    public class Order : BaseEntity
    {
        // Foreign Key for Order - AppUser : ONE-TO-MANY relationship.
        public int AppUserID { get; set; }

        // Relational Property
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
