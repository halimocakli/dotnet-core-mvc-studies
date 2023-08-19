using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent_Validation.Models
{
    public class Loan : BaseEntity
    {
        public int BookID { get; set; }
        public int MemberID { get; set; }

        public DateTime LoanDate { get; set; }
        public DateTime ReturnedDate { get; set; }

        public virtual List<Fine> Fines { get; set; }
        public virtual Member Member { get; set; }
        public virtual Book Book { get; set; }
    }
}
