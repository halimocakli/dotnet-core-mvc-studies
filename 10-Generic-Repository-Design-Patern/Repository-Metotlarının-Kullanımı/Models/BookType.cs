using System.Collections.Generic;

namespace Repository_Metotlarının_Kullanımı.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
