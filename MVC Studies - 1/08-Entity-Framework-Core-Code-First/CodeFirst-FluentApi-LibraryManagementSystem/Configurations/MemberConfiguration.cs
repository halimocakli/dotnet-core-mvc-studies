using CodeFirst_FluentApi_LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace CodeFirst_FluentApi_LibraryManagementSystem.Configurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.FirstName).IsRequired(true);
            builder.Property(x => x.LastName).IsRequired(true);
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("nvarchar(30)");

            builder.HasOne<MemberDetail>(m => m.MemberDetail).WithOne(md => md.Member).HasForeignKey<MemberDetail>(md => md.MemberID);
            builder.HasOne<MemberStatus>(m => m.MemberStatus).WithMany(ms => ms.Members).HasForeignKey(m => m.ActiveStatusID);
        }
    }
}
