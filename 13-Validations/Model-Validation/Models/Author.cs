using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model_Validation.Models
{
    public class Author : BaseEntity
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 Karakter Girilebilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 Karakter Girilebilir.")]
        public string LastName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
