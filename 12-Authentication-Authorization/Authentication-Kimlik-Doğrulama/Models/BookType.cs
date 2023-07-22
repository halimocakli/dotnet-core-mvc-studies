using System.Collections.Generic;

namespace Authentication_Kimlik_Doğrulama.Models
{
    public class BookType : BaseEntity
    {
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
