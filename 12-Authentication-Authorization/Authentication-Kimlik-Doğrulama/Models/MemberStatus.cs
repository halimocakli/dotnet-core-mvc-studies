using Authentication_Kimlik_Doğrulama.Enums;
using System.Collections.Generic;

namespace Authentication_Kimlik_Doğrulama.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
