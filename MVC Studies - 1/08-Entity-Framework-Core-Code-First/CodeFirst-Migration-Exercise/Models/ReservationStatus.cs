using CodeFirst_Migration_Exercise.Enums;
using System.Collections.Generic;

namespace CodeFirst_Migration_Exercise.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set;}
    }
}
