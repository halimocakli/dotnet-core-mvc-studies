using Login_Sayfası_Tasarımı.Enums;

namespace Login_Sayfası_Tasarımı.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
