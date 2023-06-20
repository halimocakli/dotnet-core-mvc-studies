using Data_Listing_Operations_READ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data_Listing_Operations_READ.Configurations
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
