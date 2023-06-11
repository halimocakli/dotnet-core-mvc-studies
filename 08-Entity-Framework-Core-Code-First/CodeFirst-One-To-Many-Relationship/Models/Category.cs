using System.Collections.Generic;

namespace CodeFirst_One_To_Many_Relationship.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        // Relational Property
        public virtual List<Product> Products { get; set; }
    }
}
