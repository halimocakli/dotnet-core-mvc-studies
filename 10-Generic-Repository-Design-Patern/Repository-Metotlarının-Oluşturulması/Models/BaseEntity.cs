﻿using Repository_Metotlarının_Oluşturulması.Enums;
using System;

namespace Repository_Metotlarının_Oluşturulması.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDateTime = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        public int Id { get; set; }
        public DataStatus Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
    }
}

