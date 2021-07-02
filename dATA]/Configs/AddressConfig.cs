using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserForm.Entities;
using UserForm.ValueObjects;

namespace Data.Configs
{
    public class AddressConfig<TEntity> : EntityConfig<TEntity> where TEntity : Entity
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("TB_ADDRESS");

            builder
                .Property(x => x.Street)
                .IsRequired()
                .HasColumnName("AD_STREET");

            builder
                .Property(x => x.Number)
                .IsRequired()
                .HasColumnName("AD_NUMBER");

            builder
                .Property(x => x.ZipCode.Unmasked)
                .IsRequired()
                .HasColumnName("AD_ZIPCODE");

            builder
                .Property(x => x.Neighborhood)
                .IsRequired()
                .HasColumnName("AD_NEIGHBORHOOD");

            builder
                .Property(x => x.Complement)
                .IsRequired()
                .HasColumnName("AD_COMPLEMENT");

            builder
                .Property(x => x.City)
                .IsRequired()
                .HasColumnName("AD_CITY");

            builder
                .Property(x => x.State)
                .IsRequired()
                .HasColumnName("AD_STATE");
        }
    }
}
