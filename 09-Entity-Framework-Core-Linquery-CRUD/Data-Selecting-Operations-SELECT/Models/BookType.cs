using System.Collections.Generic;

namespace Data_Selecting_Operations_SELECT.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
