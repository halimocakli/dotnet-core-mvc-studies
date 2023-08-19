using Fluent_Validation.Context;
using Fluent_Validation.Dto;
using Fluent_Validation.Enums;
using Fluent_Validation.Models;
using Fluent_Validation.RepositoryPattern.Base;
using Fluent_Validation.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Fluent_Validation.RepositoryPattern.Concreate
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
