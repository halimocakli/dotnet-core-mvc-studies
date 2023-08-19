using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Selecting_Operations_SELECT.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<BookAuthor> BookAuthors { get; set; }
    }
}
