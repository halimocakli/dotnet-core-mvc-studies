using System.Collections.Generic;

namespace CodeFirst_Migration_Exercise.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
