using Data_Deleting_Operations_DELETE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Data_Deleting_Operations_DELETE.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasOne(r => r.Book).WithMany(b => b.Reservations).HasForeignKey(r => r.BookID);
            builder.HasOne(r => r.Member).WithMany(m => m.Reservations).HasForeignKey(r => r.MemberID);
            builder.HasOne(r => r.ReservationStatus).WithMany(rs => rs.Reservations).HasForeignKey(r => r.ReservationStatusID);
        }
    }
}
