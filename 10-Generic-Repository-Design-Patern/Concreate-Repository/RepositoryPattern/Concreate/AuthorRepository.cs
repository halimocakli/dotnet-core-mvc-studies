using Concreate_Repository.Context;
using Concreate_Repository.Dto;
using Concreate_Repository.Enums;
using Concreate_Repository.Models;
using Concreate_Repository.RepositoryPattern.Base;
using Concreate_Repository.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Concreate_Repository.RepositoryPattern.Concreate
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
