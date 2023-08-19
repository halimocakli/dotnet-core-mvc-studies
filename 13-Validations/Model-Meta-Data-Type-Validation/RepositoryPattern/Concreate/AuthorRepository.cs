using Model_Meta_Data_Type_Validation.Context;
using Model_Meta_Data_Type_Validation.Dto;
using Model_Meta_Data_Type_Validation.Enums;
using Model_Meta_Data_Type_Validation.Models;
using Model_Meta_Data_Type_Validation.RepositoryPattern.Base;
using Model_Meta_Data_Type_Validation.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Model_Meta_Data_Type_Validation.RepositoryPattern.Concreate
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(MyDbContext db) : base(db)
        {
        }

        public List<AuthorDto> SelectAuthorDto()
        {
            return table
                .Where(x => x.Status != DataStatus.Deleted)
                .Select(x => new AuthorDto()
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }).ToList();
        }
    }
}
