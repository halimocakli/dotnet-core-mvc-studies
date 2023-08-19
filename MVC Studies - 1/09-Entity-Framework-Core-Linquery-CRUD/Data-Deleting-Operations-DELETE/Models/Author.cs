using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Deleting_Operations_DELETE.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<BookAuthor> BookAuthors { get; set; }
    }
}
