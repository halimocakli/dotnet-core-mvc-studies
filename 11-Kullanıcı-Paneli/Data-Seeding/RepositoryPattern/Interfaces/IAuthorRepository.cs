using Data_Seeding.Dto;
using Data_Seeding.Models;
using System.Collections.Generic;

namespace Data_Seeding.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
