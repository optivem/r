﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Optivem.Demo.Infrastructure.Persistence.Records;

namespace Optivem.Demo.Infrastructure.Persistence.Configuration
{
    public class ProductRecordConfiguration : IEntityTypeConfiguration<ProductRecord>
    {
        public void Configure(EntityTypeBuilder<ProductRecord> builder)
        {
            builder.Property(e => e.ProductCode)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.ListPrice)
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.IsListed)
                .IsRequired();
        }
    }
}