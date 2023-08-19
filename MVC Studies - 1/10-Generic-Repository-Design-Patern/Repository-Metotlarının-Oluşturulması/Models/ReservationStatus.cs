using Repository_Metotlarının_Oluşturulması.Enums;
using System.Collections.Generic;

namespace Repository_Metotlarının_Oluşturulması.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
