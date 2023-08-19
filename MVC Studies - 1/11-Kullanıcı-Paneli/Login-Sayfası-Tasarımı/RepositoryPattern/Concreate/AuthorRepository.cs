using Login_Sayfası_Tasarımı.Context;
using Login_Sayfası_Tasarımı.Dto;
using Login_Sayfası_Tasarımı.Enums;
using Login_Sayfası_Tasarımı.Models;
using Login_Sayfası_Tasarımı.RepositoryPattern.Base;
using Login_Sayfası_Tasarımı.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Login_Sayfası_Tasarımı.RepositoryPattern.Concreate
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
