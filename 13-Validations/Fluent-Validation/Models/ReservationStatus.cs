using Fluent_Validation.Enums;
using System.Collections.Generic;

namespace Fluent_Validation.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
