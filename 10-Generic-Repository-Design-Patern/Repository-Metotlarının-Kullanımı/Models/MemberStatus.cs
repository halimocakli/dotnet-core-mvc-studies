using Repository_Metotlarının_Kullanımı.Enums;
using System.Collections.Generic;

namespace Repository_Metotlarının_Kullanımı.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
