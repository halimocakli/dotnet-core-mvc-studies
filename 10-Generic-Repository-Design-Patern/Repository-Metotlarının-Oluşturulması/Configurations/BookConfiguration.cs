using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository_Metotlarının_Oluşturulması.Models;

namespace Repository_Metotlarının_Oluşturulması.Configurations
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
