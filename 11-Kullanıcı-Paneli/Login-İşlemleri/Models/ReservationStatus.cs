using Login_İşlemleri.Enums;
using System.Collections.Generic;

namespace Login_İşlemleri.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
