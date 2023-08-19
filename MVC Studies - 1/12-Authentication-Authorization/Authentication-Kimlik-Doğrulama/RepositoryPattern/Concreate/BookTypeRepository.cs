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
