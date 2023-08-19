using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Models
{
    public class BookAuthor : BaseEntity
    {
        [ForeignKey("Book")]
        public int BookID { get; set; }

        [ForeignKey("Author")]
        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
        public virtual Book Book { get; set; }
    }
}
