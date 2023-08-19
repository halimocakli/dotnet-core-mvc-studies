using Fluent_Validation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fluent_Validation.Configurations
{
    public class FineConfiguration : IEntityTypeConfiguration<Fine>
    {
        public void Configure(EntityTypeBuilder<Fine> builder)
        {
            builder.HasOne(f => f.Loan).WithMany(l => l.Fines).HasForeignKey(f => f.LoanID);
            builder.HasOne(f => f.Member).WithMany(m => m.Fines).HasForeignKey(f => f.MemberID);

            builder.Property(x => x.FineAmount).IsRequired().HasColumnType("numeric(18,1)");
        }
    }
}
