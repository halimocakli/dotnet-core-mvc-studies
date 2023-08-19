using Model_Meta_Data_Type_Validation.Enums;
using System.Collections.Generic;

namespace Model_Meta_Data_Type_Validation.Models
{
    public class ReservationStatus : BaseEntity
    {
        public ReservedBookStatus StatusValue { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
    }
}
