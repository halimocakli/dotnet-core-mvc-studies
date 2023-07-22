using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authentication_Kimlik_Doğrulama.Models
{
    public class Reservation : BaseEntity
    {
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public int ReservationStatusID { get; set; }

        public DateTime ReservationDate { get; set; }

        public virtual ReservationStatus ReservationStatus { get; set; }
        public virtual Member Member { get; set; }
        public virtual Book Book { get; set; }
    }
}
