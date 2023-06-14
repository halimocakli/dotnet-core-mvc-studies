using System.Collections.Generic;

namespace Data_Adding_Operations_CREATE.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
