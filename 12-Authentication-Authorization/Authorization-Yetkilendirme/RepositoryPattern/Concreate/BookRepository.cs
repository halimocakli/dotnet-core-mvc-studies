using Authorization_Yetkilendirme.Context;
using Authorization_Yetkilendirme.Dto;
using Authorization_Yetkilendirme.Enums;
using Authorization_Yetkilendirme.Models;
using Authorization_Yetkilendirme.RepositoryPattern.Base;
using Authorization_Yetkilendirme.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Authorization_Yetkilendirme.RepositoryPattern.Concreate
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
