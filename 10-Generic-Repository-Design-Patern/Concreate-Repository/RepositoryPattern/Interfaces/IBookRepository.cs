using Concreate_Repository.Dto;
using Concreate_Repository.Models;
using System.Collections.Generic;

namespace Concreate_Repository.RepositoryPattern.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        List<BookDto> GetBookDto();
    }
}
