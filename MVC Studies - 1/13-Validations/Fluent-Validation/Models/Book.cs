using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent_Validation.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public int? PageCount { get; set; }
        public string Description { get; set; }
        public DateTime? PublicationDate { get; set; }
        public int CopiesOwned { get; set; }
        public int BookTypeID { get; set; }
        public int AuthorID { get; set; }

        public virtual BookType BookType { get; set; }
        public virtual Author Author { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Loan> Loans { get; set; }
    }
}
