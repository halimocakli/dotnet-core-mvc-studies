using System.Collections.Generic;

namespace Data_Selecting_Operations_SELECT.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
