using System.Collections.Generic;

namespace Data_Updating_Operations_UPDATE.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
