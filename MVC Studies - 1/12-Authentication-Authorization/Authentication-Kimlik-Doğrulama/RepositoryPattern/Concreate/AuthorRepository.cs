using Authentication_Kimlik_Doğrulama.Context;
using Authentication_Kimlik_Doğrulama.Dto;
using Authentication_Kimlik_Doğrulama.Enums;
using Authentication_Kimlik_Doğrulama.Models;
using Authentication_Kimlik_Doğrulama.RepositoryPattern.Base;
using Authentication_Kimlik_Doğrulama.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Authentication_Kimlik_Doğrulama.RepositoryPattern.Concreate
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
