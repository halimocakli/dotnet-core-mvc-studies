using Data_Seeding.Context;
using Data_Seeding.Dto;
using Data_Seeding.Enums;
using Data_Seeding.Models;
using Data_Seeding.RepositoryPattern.Base;
using Data_Seeding.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Data_Seeding.RepositoryPattern.Concreate
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
