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
    public class BookTypeRepository : Repository<BookType>, IBookTypeRepository
    {
        public BookTypeRepository(MyDbContext db) : base(db)
        {
        }

        public List<BookTypeDto> SelectBookTypeDto()
        {
            {
                return table
                    .Where(x => x.Status != DataStatus.Deleted)
                    .Select(x => new BookTypeDto()
                    {
                        Id = x.Id,
                        TypeName = x.TypeName,
                    })
                    .ToList();
            }
        }
    }
}
