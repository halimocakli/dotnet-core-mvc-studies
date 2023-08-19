using System;

namespace Data_Select_And_Add_Book.Models
{
    public class MemberDetail : BaseEntity
    {
        public int MemberID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime JoinedDate { get; set; }


        // Relational Property
        public virtual Member Member { get; set; }
    }
}
