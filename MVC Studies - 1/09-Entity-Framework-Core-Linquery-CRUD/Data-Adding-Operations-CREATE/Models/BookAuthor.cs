using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Adding_Operations_CREATE.Models
{
    public class BookAuthor : BaseEntity
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
