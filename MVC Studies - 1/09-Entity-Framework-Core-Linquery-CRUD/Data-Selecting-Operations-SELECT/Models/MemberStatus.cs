using Data_Selecting_Operations_SELECT.Enums;
using System.Collections.Generic;

namespace Data_Selecting_Operations_SELECT.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
