using IRepository_Interface_Yazımı.Enums;
using System.Collections.Generic;

namespace IRepository_Interface_Yazımı.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
