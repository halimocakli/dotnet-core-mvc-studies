namespace CodeFirst_DbContext_Class.Models
{
    public class OrderDetail : BaseEntity
    {
        public short Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
