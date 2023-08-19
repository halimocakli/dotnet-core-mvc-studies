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
