using Authorization_Yetkilendirme.Enums;

namespace Authorization_Yetkilendirme.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
