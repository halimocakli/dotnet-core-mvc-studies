using CodeFirst_Migration.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Migration.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        [NotMapped]     // RetypePasword DB üzerinde karşılık bulmayacak.
        public string RetypePasword { get; set; }
        public Role Role { get; set; }

        // Relational Property
        public virtual AppUserDetail AppUserDetail { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
