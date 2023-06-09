using CodeFirst_Migration_Exercise.Enums;
using System.Collections.Generic;

namespace CodeFirst_Migration_Exercise.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
