using Authorization_Yetkilendirme.Context;
using Authorization_Yetkilendirme.Dto;
using Authorization_Yetkilendirme.Enums;
using Authorization_Yetkilendirme.Models;
using Authorization_Yetkilendirme.RepositoryPattern.Base;
using Authorization_Yetkilendirme.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Authorization_Yetkilendirme.RepositoryPattern.Concreate
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
