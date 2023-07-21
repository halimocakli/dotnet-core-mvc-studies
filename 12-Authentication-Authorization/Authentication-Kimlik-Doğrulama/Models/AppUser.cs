using Authentication_Kimlik_Doğrulama.Enums;

namespace Authentication_Kimlik_Doğrulama.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
