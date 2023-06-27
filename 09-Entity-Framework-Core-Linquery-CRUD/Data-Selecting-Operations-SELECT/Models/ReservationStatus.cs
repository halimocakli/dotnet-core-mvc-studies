using Data_Selecting_Operations_SELECT.Enums;
using System.Collections.Generic;

namespace Data_Selecting_Operations_SELECT.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
