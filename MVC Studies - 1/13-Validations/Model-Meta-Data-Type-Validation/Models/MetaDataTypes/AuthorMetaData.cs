using System.ComponentModel.DataAnnotations;

namespace Model_Meta_Data_Type_Validation.Models.MetaDataTypes
{
    public class AuthorMetaData
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 Karakter Girilebilir.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(15, ErrorMessage = "Maksimum 15 Karakter Girilebilir.")]
        public string LastName { get; set; }
    }
}
