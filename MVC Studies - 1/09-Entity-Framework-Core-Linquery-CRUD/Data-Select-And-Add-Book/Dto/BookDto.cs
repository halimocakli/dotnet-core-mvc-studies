using Data_Select_And_Add_Book.Models;

namespace Data_Select_And_Add_Book.Dto
{
    public class BookDto
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public int? BookPageCount { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFullName
        {
            get
            {
                return $"{AuthorFirstName} {AuthorLastName}";
            }
        }
        public string BookTypeName { get; set; }
    }
}
