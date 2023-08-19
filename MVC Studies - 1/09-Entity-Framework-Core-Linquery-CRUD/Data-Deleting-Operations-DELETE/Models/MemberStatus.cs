using Data_Deleting_Operations_DELETE.Enums;
using System.Collections.Generic;

namespace Data_Deleting_Operations_DELETE.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
