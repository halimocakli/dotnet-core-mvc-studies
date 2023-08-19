using Concreate_Repository.Enums;
using System.Collections.Generic;

namespace Concreate_Repository.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
