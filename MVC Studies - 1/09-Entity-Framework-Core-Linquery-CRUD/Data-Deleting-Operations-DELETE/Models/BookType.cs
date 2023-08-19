using System.Collections.Generic;

namespace Data_Deleting_Operations_DELETE.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
