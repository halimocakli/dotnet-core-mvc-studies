using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Migration_Exercise.Models
{
    public class FinePayment : BaseEntity
    {
        [ForeignKey("Member")]
        public int MemberID { get; set; }
        public DateTime PaymentDate { get; set; }

        [Column(TypeName = "numeric(18,1)")]
        public decimal PaymentAmount { get; set; }

        public virtual Member Member { get; set; }
    }
}
