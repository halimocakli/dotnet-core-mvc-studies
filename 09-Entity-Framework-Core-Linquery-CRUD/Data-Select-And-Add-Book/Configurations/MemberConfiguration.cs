using Data_Select_And_Add_Book.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Data_Select_And_Add_Book.Configurations
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
