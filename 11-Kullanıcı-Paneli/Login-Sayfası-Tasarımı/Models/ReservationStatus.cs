using Login_Sayfası_Tasarımı.Enums;
using System.Collections.Generic;

namespace Login_Sayfası_Tasarımı.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
