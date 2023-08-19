using Concreate_Repository.Dto;
using Concreate_Repository.Models;
using System.Collections.Generic;

namespace Concreate_Repository.RepositoryPattern.Interfaces
{
    public interface IBookTypeRepository : IRepository<BookType>
    {
        List<BookTypeDto> SelectBookTypeDto();
    }
}
