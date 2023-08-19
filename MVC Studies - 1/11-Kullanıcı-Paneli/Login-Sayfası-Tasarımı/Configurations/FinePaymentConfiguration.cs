using Login_Sayfası_Tasarımı.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Login_Sayfası_Tasarımı.Configurations
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
