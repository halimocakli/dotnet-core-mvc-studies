using Model_Validation.Dto;
using Model_Validation.Models;
using System.Collections.Generic;

namespace Model_Validation.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
