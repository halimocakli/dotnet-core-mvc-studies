﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repository_Metotlarının_Kullanımı.Models;

namespace Repository_Metotlarının_Kullanımı.Configurations
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
