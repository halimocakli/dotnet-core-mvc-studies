using Repository_Metotlarının_Oluşturulması.Enums;
using System.Collections.Generic;

namespace Repository_Metotlarının_Oluşturulması.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
