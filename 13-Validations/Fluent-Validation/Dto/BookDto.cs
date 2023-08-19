namespace Fluent_Validation.Dto
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
