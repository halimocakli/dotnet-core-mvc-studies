using Concreate_Repository.Enums;
using System.Collections.Generic;

namespace Concreate_Repository.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
