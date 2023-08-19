using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Models
{
    public class Fine : BaseEntity
    {
        [ForeignKey("Loan")]
        public int LoanID { get; set; }

        [ForeignKey("Member")]
        public int? MemberID { get; set; }
        public DateTime FineDate { get; set; }

        [Column(TypeName = "numeric(18,1)")]
        public decimal FineAmount { get; set; }

        public virtual Loan Loan { get; set; }
        public virtual Member Member { get; set; }
    }
}
