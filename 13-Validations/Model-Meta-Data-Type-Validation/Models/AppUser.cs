﻿using Model_Meta_Data_Type_Validation.Enums;

namespace Model_Meta_Data_Type_Validation.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
