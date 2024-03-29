﻿using Ahlatci.Eticaret.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ahlatci.Eticaret.Persistence.Mappings
{
    public class AddressMapping : BaseEntityMapping<Address>
    {
        public override void ConfigureDerivedEntityMapping(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.CityId)
                .HasColumnName("CITY_ID")
                .HasColumnOrder(2);

            builder.Property(x => x.Text)
                .HasColumnName("TEXT")
                .HasColumnType("nvarchar(255)")
                .HasColumnOrder(3);

            builder.HasOne(x => x.City)
                .WithMany(x => x.Addresses)
                .HasForeignKey(x => x.CityId)
                .HasConstraintName("ADDRESS_CITY_CITY_ID");

            builder.ToTable("ADDRESSES");
        }
    }
}
