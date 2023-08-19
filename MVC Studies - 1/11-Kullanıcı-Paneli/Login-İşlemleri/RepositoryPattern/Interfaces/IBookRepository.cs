using Login_İşlemleri.Dto;
using Login_İşlemleri.Models;
using System.Collections.Generic;

namespace Login_İşlemleri.RepositoryPattern.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        List<BookDto> GetBookDto();
    }
}
