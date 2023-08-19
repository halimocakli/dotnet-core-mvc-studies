using Concreate_Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Concreate_Repository.Configurations
{
    public class FinePaymentConfiguration : IEntityTypeConfiguration<FinePayment>
    {
        public void Configure(EntityTypeBuilder<FinePayment> builder)
        {
            builder.HasOne(fp => fp.Member).WithMany(m => m.FinePayments).HasForeignKey(fp => fp.MemberID);
            builder.Property(x => x.PaymentAmount).IsRequired().HasColumnType("numeric(18,1)");
        }
    }
}
