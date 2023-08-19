using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using Fluent_Validation.Enums;

namespace Fluent_Validation.Models
{
    public class Member : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }

        public int MemberStatusID { get; set; }

        public virtual List<Fine> Fines { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Loan> Loans { get; set; }
        public virtual List<FinePayment> FinePayments { get; set; }
        public virtual MemberStatus MemberStatus { get; set; }
        public virtual MemberDetail MemberDetail { get; set; }
    }
}
