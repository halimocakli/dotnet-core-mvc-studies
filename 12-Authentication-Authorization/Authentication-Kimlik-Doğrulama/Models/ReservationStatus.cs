using Authentication_Kimlik_Doğrulama.Enums;
using System.Collections.Generic;

namespace Authentication_Kimlik_Doğrulama.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
