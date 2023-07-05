using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository_Metotlarının_Oluşturulması.Models
{
    public class FinePayment : BaseEntity
    {
        public int MemberID { get; set; }
        public DateTime PaymentDate { get; set; }

        public decimal PaymentAmount { get; set; }

        public virtual Member Member { get; set; }
    }
}
