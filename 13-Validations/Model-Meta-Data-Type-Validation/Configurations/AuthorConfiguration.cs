﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model_Meta_Data_Type_Validation.Models;
using System.Reflection.Emit;

namespace Model_Meta_Data_Type_Validation.Configurations
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
