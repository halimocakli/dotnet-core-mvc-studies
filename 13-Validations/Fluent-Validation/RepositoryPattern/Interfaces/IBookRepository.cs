using Fluent_Validation.Dto;
using Fluent_Validation.Models;
using System.Collections.Generic;

namespace Fluent_Validation.RepositoryPattern.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        List<BookDto> GetBookDto();
    }
}
