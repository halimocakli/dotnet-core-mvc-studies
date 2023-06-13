namespace CodeFirst_One_To_Many_Relationship.Models
{
    public class OrderDetail : BaseEntity
    {
        public short Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
