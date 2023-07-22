using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authentication_Kimlik_Doğrulama.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
