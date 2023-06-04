namespace CodeFirst_Define_Relations_Between_Table.Models
{
    public class AppUserDetail : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
