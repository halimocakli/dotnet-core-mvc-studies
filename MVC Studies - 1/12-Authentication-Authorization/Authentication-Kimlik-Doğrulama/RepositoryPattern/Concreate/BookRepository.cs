using Authentication_Kimlik_Doğrulama.Context;
using Authentication_Kimlik_Doğrulama.Dto;
using Authentication_Kimlik_Doğrulama.Enums;
using Authentication_Kimlik_Doğrulama.Models;
using Authentication_Kimlik_Doğrulama.RepositoryPattern.Base;
using Authentication_Kimlik_Doğrulama.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Authentication_Kimlik_Doğrulama.RepositoryPattern.Concreate
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(MyDbContext db) : base(db)
        {

        }

        public List<BookDto> GetBookDto()
        {
            return table
                .Where(b => b.Status != DataStatus.Deleted)
                .Include(x => x.Author)
                .Include(x => x.BookType)
                .Select(x => new BookDto()
                {
                    Id = x.Id,
                    BookTitle = x.Title,
                    AuthorFirstName = x.Author.FirstName,
                    AuthorLastName = x.Author.LastName,
                    BookTypeName = x.BookType.TypeName,
                    BookPageCount = x.PageCount
                })
                .ToList();
        }
    }
}
