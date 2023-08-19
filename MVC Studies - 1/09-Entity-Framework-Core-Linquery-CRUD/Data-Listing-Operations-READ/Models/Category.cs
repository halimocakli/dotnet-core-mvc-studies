using System.Collections.Generic;

namespace Data_Listing_Operations_READ.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
