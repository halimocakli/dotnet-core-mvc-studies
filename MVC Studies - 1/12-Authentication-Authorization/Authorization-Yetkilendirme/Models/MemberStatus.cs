using Authorization_Yetkilendirme.Enums;
using System.Collections.Generic;

namespace Authorization_Yetkilendirme.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
