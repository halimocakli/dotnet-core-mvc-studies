using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string Description { get; set; }
        public DateTime PublicationDate { get; set; }
        public int CopiesOwned { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Loan> Loans { get; set; }
        public virtual List<BookAuthor> BookAuthors { get; set; }
    }
}
