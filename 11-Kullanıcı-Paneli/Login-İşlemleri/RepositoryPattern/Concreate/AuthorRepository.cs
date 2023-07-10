using Login_İşlemleri.Context;
using Login_İşlemleri.Dto;
using Login_İşlemleri.Enums;
using Login_İşlemleri.Models;
using Login_İşlemleri.RepositoryPattern.Base;
using Login_İşlemleri.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Login_İşlemleri.RepositoryPattern.Concreate
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
