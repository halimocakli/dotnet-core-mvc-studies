using CodeFirst_Model_Generate.Enums;

namespace CodeFirst_Model_Generate.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public Role Role { get; set; }
    }
}
