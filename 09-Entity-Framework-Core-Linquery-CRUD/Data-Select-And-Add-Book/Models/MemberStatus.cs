﻿using Data_Select_And_Add_Book.Enums;
using System.Collections.Generic;

namespace Data_Select_And_Add_Book.Models
{
    public class MemberStatus : BaseEntity
    {
        public MemberStatusEnum StatusValue { get; set; }

        public virtual List<Member> Members { get; set; }
    }
}
