using Data_Listing_Operations_READ.Enums;
using System.Collections.Generic;

namespace Data_Listing_Operations_READ.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
