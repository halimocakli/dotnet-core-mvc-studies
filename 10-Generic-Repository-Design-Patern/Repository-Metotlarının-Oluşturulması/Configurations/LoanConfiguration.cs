using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository_Metotlarının_Oluşturulması.Models;

namespace Repository_Metotlarının_Oluşturulması.Configurations
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasOne(l => l.Book).WithMany(b => b.Loans).HasForeignKey(l => l.BookID);
            builder.HasOne(l => l.Member).WithMany(m => m.Loans).HasForeignKey(l => l.MemberID);
        }
    }
}
