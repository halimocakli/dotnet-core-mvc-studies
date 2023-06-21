using System.Collections.Generic;

namespace Data_Listing_Operations_READ.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
