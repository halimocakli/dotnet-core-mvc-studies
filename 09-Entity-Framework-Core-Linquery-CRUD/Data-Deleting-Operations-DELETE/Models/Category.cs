using System.Collections.Generic;

namespace Data_Deleting_Operations_DELETE.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
