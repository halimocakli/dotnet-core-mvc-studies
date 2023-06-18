using Data_Deleting_Operations_DELETE.Enums;
using System.Collections.Generic;

namespace Data_Deleting_Operations_DELETE.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
