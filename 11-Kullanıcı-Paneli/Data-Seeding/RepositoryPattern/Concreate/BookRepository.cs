using Data_Seeding.Context;
using Data_Seeding.Dto;
using Data_Seeding.Enums;
using Data_Seeding.Models;
using Data_Seeding.RepositoryPattern.Base;
using Data_Seeding.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data_Seeding.RepositoryPattern.Concreate
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
