using Login_İşlemleri.Context;
using Login_İşlemleri.Dto;
using Login_İşlemleri.Enums;
using Login_İşlemleri.Models;
using Login_İşlemleri.RepositoryPattern.Base;
using Login_İşlemleri.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Login_İşlemleri.RepositoryPattern.Concreate
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
