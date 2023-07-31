using Authorization_Yetkilendirme.Enums;
using System.Collections.Generic;

namespace Authorization_Yetkilendirme.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
