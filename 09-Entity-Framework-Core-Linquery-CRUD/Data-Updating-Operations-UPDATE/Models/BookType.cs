using System.Collections.Generic;

namespace Data_Updating_Operations_UPDATE.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
