using Fluent_Validation.Enums;
using System.Collections.Generic;

namespace Fluent_Validation.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
