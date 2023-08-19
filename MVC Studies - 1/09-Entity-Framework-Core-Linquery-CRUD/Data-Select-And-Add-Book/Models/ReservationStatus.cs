using Data_Select_And_Add_Book.Enums;
using System.Collections.Generic;

namespace Data_Select_And_Add_Book.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
