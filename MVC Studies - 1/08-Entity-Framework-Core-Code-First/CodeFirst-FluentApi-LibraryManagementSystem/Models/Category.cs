using System.Collections.Generic;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Models
{
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
