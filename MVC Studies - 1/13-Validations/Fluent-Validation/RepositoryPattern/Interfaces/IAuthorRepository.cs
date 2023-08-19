using Fluent_Validation.Dto;
using Fluent_Validation.Models;
using System.Collections.Generic;

namespace Fluent_Validation.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
