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
