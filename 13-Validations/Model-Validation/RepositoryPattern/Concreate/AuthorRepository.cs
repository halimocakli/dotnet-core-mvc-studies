using Model_Validation.Context;
using Model_Validation.Dto;
using Model_Validation.Enums;
using Model_Validation.Models;
using Model_Validation.RepositoryPattern.Base;
using Model_Validation.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Model_Validation.RepositoryPattern.Concreate
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
