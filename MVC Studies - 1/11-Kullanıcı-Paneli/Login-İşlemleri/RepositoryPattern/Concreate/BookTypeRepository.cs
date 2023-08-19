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
