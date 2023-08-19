using Data_Listing_Operations_READ.Enums;
using System.Collections.Generic;

namespace Data_Listing_Operations_READ.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
