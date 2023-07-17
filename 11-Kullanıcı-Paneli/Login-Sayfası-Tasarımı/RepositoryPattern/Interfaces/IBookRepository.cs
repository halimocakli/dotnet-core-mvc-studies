using Login_Sayfası_Tasarımı.Dto;
using Login_Sayfası_Tasarımı.Models;
using System.Collections.Generic;

namespace Login_Sayfası_Tasarımı.RepositoryPattern.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        List<BookDto> GetBookDto();
    }
}
