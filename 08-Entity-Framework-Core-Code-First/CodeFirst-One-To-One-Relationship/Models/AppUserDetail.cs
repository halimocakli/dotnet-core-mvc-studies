namespace CodeFirst_One_To_One_Relationship.Models
{
    public class AppUserDetail : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Foreign Key for AppUser - AppUserDetail : ONE-TO-ONE relationship.
        public int AppUserID { get; set; }  

        // Relational Property
        public AppUser AppUser { get; set; }

    }
}
