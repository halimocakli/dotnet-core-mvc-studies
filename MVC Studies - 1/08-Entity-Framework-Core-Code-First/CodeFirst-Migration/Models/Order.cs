using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Migration.Models
{
    public class Order : BaseEntity
    {
        // Foreign Key for Order - AppUser : ONE-TO-MANY relationship.
        [ForeignKey("AppUser")]
        public int AppUserID { get; set; }

        // Relational Property
        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
