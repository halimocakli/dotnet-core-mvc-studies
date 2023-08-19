using Model_Meta_Data_Type_Validation.Enums;
using System.Collections.Generic;

namespace Model_Meta_Data_Type_Validation.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
