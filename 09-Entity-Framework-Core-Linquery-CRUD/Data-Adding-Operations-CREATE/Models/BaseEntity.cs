using Data_Adding_Operations_CREATE.Enums;
using System;

namespace Data_Adding_Operations_CREATE.Models
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

