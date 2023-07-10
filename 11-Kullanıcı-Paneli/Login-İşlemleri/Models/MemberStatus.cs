using Login_İşlemleri.Enums;
using System.Collections.Generic;

namespace Login_İşlemleri.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
