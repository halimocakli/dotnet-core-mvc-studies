using Login_Sayfası_Tasarımı.Context;
using Login_Sayfası_Tasarımı.Dto;
using Login_Sayfası_Tasarımı.Enums;
using Login_Sayfası_Tasarımı.Models;
using Login_Sayfası_Tasarımı.RepositoryPattern.Base;
using Login_Sayfası_Tasarımı.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Login_Sayfası_Tasarımı.RepositoryPattern.Concreate
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
