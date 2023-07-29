using System.Collections.Generic;

namespace Authorization_Yetkilendirme.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
