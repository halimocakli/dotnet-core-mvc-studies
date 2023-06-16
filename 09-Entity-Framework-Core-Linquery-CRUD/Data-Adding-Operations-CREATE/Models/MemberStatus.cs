using Data_Adding_Operations_CREATE.Enums;
using System.Collections.Generic;

namespace Data_Adding_Operations_CREATE.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
