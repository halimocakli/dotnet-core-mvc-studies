using Concreate_Repository.Dto;
using Concreate_Repository.Models;
using System.Collections.Generic;

namespace Concreate_Repository.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
