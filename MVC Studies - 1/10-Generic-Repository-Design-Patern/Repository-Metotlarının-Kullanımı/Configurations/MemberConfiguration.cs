using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository_Metotlarının_Kullanımı.Models;
using System.Reflection.Emit;

namespace Repository_Metotlarının_Kullanımı.Configurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.FirstName).IsRequired(true);
            builder.Property(x => x.LastName).IsRequired(true);
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("nvarchar(30)");

            builder.HasOne(m => m.MemberDetail).WithOne(md => md.Member).HasForeignKey<MemberDetail>(md => md.MemberID);
            builder.HasOne(m => m.MemberStatus).WithMany(ms => ms.Members).HasForeignKey(m => m.ActiveStatusID);
        }
    }
}
