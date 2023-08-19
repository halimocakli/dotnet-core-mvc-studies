using Data_Updating_Operations_UPDATE.Enums;
using System.Collections.Generic;

namespace Data_Updating_Operations_UPDATE.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
