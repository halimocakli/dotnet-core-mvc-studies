using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Migration.Models
{
    public class OrderDetail : BaseEntity
    {
        public short Quantity { get; set; }
        [Column(TypeName = "numeric(18,1)")]
        public decimal? TotalPrice { get; set; }

        // Foreign Key for OrderDetail - Order - Product relationship.
        // [Key, Column(Order = 1)]
        public int OrderID { get; set; }

        // [Key, Column(Order = 2)]
        public int ProductID { get; set; }

        // Relational Property
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
