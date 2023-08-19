using CodeFirst_Define_Relations_Between_Table.Enums;

namespace CodeFirst_Define_Relations_Between_Table.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public Role Role { get; set; }
    }
}
