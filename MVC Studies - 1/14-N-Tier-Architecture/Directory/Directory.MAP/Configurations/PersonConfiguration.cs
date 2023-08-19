using Directory.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.MAP.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Kişiler");
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(15).HasColumnName("Isim");
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(15).HasColumnName("Soyisim");
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(13).HasColumnName("TelefonNumarası");
            builder.Property(x => x.Company).HasMaxLength(15).HasColumnName("Şirket");
        }
    }
}
