using Model_Meta_Data_Type_Validation.Dto;
using Model_Meta_Data_Type_Validation.Models;
using System.Collections.Generic;

namespace Model_Meta_Data_Type_Validation.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
