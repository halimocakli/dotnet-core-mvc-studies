using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model_Meta_Data_Type_Validation.Models;

namespace Model_Meta_Data_Type_Validation.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorID);
            builder.HasOne(b => b.BookType).WithMany(bt => bt.Books).HasForeignKey(b => b.BookTypeID);
        }
    }
}
