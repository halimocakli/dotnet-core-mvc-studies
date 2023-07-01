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
