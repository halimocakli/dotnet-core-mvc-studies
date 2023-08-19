using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Migration_Exercise.Models
{
    public class Reservation : BaseEntity
    {
        [ForeignKey("Book")]
        public int BookID { get; set; }

        [ForeignKey("Member")]
        public int MemberID { get; set; }

        [ForeignKey("ReservationStatus")]
        public int ReservationStatusID { get; set; }

        public DateTime ReservationDate { get; set; }

        public virtual ReservationStatus ReservationStatus { get; set; }
        public virtual Member Member { get; set; }
        public virtual Book Book { get; set; }
    }
}
