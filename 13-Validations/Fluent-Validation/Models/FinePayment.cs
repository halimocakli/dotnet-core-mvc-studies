using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fluent_Validation.Models
{
    public class FinePayment : BaseEntity
    {
        public int MemberID { get; set; }
        public DateTime PaymentDate { get; set; }

        public decimal PaymentAmount { get; set; }

        public virtual Member Member { get; set; }
    }
}
