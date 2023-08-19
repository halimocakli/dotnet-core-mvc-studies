using Repository_Metotlarının_Kullanımı.Enums;
using System.Collections.Generic;

namespace Repository_Metotlarının_Kullanımı.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
