using CodeFirst_FluentApi_LibraryManagementSystem.Enums;
using System.Collections.Generic;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
