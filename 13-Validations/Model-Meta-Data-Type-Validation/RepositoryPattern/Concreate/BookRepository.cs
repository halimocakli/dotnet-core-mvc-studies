using Microsoft.EntityFrameworkCore;
using Model_Meta_Data_Type_Validation.Context;
using Model_Meta_Data_Type_Validation.Dto;
using Model_Meta_Data_Type_Validation.Enums;
using Model_Meta_Data_Type_Validation.Models;
using Model_Meta_Data_Type_Validation.RepositoryPattern.Base;
using Model_Meta_Data_Type_Validation.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Model_Meta_Data_Type_Validation.RepositoryPattern.Concreate
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
