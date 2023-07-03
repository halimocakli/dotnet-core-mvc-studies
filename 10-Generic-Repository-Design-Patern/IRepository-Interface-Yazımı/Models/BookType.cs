using System.Collections.Generic;

namespace IRepository_Interface_Yazımı.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
