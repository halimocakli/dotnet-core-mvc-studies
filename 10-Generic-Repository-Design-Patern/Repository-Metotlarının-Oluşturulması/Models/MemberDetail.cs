using System;

namespace Repository_Metotlarının_Oluşturulması.Models
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
