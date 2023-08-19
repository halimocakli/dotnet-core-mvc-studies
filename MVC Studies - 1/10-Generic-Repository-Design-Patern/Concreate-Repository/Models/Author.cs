using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concreate_Repository.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
