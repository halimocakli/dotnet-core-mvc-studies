﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository_Metotlarının_Oluşturulması.Models;
using System.Reflection.Emit;

namespace Repository_Metotlarının_Oluşturulması.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Yazarlar");
            builder.Property(x => x.FirstName).HasColumnName("Isim");
            builder.Property(x => x.LastName).HasColumnName("Soyisim");
        }
    }
}
