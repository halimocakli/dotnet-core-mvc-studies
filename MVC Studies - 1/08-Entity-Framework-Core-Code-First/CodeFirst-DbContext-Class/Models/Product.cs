namespace CodeFirst_DbContext_Class.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

        // Foreign Key for Product - Category : ONE-TO-MANY relationship.
        public int CategoryID { get; set; }

        // Relational Property
        public virtual Category Category { get; set; }
    }
}
