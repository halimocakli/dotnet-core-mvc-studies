using Data_Seeding.Enums;
using System.Collections.Generic;

namespace Data_Seeding.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
