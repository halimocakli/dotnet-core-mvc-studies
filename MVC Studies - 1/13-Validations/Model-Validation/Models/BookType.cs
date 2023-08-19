using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model_Validation.Models
{
    public class BookType : BaseEntity
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 Karakter Girilebilir.")]
        public string TypeName { get; set; }

        public List<Book> Books { get; set; }
    }
}
