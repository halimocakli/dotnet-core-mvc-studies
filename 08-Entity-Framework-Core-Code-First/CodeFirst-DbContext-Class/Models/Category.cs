using System.Collections.Generic;

namespace CodeFirst_DbContext_Class.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        // Relational Property
        public virtual List<Product> Products { get; set; }
    }
}
