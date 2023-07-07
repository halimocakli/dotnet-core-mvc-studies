using Data_Seeding.Enums;
using System.Collections.Generic;

namespace Data_Seeding.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
