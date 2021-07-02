using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UserForm.Entities;

namespace Data.Configs
{
    public class CustomerConfig<TEntity> : EntityConfig<TEntity> where TEntity : Entity
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("TB_CUSTOMER");

            builder
                .OwnsOne(x => x.Name)
                .Property(x => x.FirstName)
                .IsRequired()
                .HasColumnName("NM_FIRST");

            builder
                .OwnsOne(x => x.Name)
                .Property(x => x.MiddleName)
                .IsRequired()
                .HasColumnName("NM_MIDDLE");

            builder
                .OwnsOne(x => x.Name)
                .Property(x => x.LastName)
                .IsRequired()
                .HasColumnName("NM_LAST");

            builder
                .Property(x => x.Email)
                .IsRequired()
                .HasColumnName("DS_EMAIL");

            builder
                .Property(x => x.Phone.Unmasked)
                .IsRequired()
                .HasColumnName("NR_PHONE");

            builder
                .Property(x => x.Address.Street)
                .IsRequired()
                .HasColumnName("AD_STREET");

            builder
                .Property(x => x.Address.Number)
                .IsRequired()
                .HasColumnName("AD_NUMBER");

            builder
                .Property(x => x.Address.ZipCode.Unmasked)
                .IsRequired()
                .HasColumnName("AD_ZIPCODE");

            builder
                .Property(x => x.Address.Neighborhood)
                .IsRequired()
                .HasColumnName("AD_NEIGHBORHOOD");

            builder
                .Property(x => x.Address.Complement)
                .IsRequired()
                .HasColumnName("AD_COMPLEMENT");

            builder
                .Property(x => x.Address.City)
                .IsRequired()
                .HasColumnName("AD_CITY");

            builder
                .Property(x => x.Address.State)
                .IsRequired()
                .HasColumnName("AD_STATE");
        }
    }
}
