using System.Collections.Generic;

namespace Data_Select_And_Add_Book.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
