namespace CodeFirst_Define_Relations_Between_Table.Models
{
    public class OrderDetail : BaseEntity
    {
        public short Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
    }
}
