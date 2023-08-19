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
