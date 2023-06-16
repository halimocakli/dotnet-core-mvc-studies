using Data_Adding_Operations_CREATE.Enums;
using System.Collections.Generic;

namespace Data_Adding_Operations_CREATE.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
