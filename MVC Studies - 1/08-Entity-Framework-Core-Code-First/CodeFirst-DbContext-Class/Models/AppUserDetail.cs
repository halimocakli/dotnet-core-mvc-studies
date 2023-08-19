namespace CodeFirst_DbContext_Class.Models
{
    public class AppUserDetail : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int AppUserID { get; set; }  // Foreign Key for AppUser - AppUserDetail : ONE-TO-ONE relationship.

        // Relational Property
        public AppUser AppUser { get; set; }

    }
}
