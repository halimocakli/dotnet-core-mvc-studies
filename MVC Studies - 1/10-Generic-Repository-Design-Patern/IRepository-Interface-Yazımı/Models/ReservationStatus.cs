using IRepository_Interface_Yazımı.Enums;
using System.Collections.Generic;

namespace IRepository_Interface_Yazımı.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
