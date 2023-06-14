using System.Collections.Generic;

namespace Data_Adding_Operations_CREATE.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
