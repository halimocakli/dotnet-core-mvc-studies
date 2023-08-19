using Login_Sayfası_Tasarımı.Enums;
using System.Collections.Generic;

namespace Login_Sayfası_Tasarımı.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
