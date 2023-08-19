namespace _01_Basics.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age { get; set; }
    }
}