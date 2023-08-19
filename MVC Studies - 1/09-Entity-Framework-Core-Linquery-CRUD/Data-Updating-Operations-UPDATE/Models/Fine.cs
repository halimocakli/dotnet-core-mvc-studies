using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data_Updating_Operations_UPDATE.Models
{
    public class Fine : BaseEntity
    {
        public int LoanID { get; set; }
        public int? MemberID { get; set; }
        public DateTime FineDate { get; set; }
        public decimal FineAmount { get; set; }

        public virtual Loan Loan { get; set; }
        public virtual Member Member { get; set; }
    }
}
