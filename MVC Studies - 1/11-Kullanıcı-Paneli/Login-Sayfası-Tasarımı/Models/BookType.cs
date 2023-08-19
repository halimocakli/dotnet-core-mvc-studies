using System.Collections.Generic;

namespace Login_Sayfası_Tasarımı.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
