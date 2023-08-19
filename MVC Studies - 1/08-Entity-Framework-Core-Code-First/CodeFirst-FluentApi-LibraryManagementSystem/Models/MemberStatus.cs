using CodeFirst_FluentApi_LibraryManagementSystem.Enums;
using System.Collections.Generic;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
