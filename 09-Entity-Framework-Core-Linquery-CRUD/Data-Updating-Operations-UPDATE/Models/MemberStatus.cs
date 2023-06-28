using Data_Updating_Operations_UPDATE.Enums;
using System.Collections.Generic;

namespace Data_Updating_Operations_UPDATE.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
