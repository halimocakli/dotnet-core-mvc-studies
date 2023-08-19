using Fluent_Validation.Dto;
using Fluent_Validation.Models;
using System.Collections.Generic;

namespace Fluent_Validation.RepositoryPattern.Interfaces
{
    public interface IBookTypeRepository : IRepository<BookType>
    {
        List<BookTypeDto> SelectBookTypeDto();
    }
}
