using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Models
{
    public class Loan : BaseEntity
    {
        [ForeignKey("Book")]
        public int BookID { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }

        public DateTime LoanDate { get; set; }
        public DateTime ReturnedDate { get; set; }

        public virtual List<Fine> Fines { get; set; }
        public virtual Member Member { get; set; }
        public virtual Book Book { get; set; }
    }
}
