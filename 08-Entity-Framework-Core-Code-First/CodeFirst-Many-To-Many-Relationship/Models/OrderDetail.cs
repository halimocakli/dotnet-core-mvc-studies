namespace CodeFirst_Many_To_Many_Relationship.Models
{
    public class OrderDetail : BaseEntity
    {
        public short Quantity { get; set; }
        public decimal? TotalPrice { get; set; }

        // Foreign Key for OrderDetail - Order - Product relationship.
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        // Relational Property
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
