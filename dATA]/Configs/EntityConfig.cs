using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserForm.Entities;

namespace Data.Configs
{
    public class EntityConfig<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            ConfigureKey(builder);

            builder.Property(x => x.Id)
               .IsRequired()
               .HasColumnName("ID");

            builder.Property(x => x.CreatedAt)
                .IsRequired()
                .HasColumnName("CREATED_AT");

            builder.Property(x => x.UpdatedAt)
                .IsRequired()
                .HasColumnName("UPDATED_AT");

            builder.Property(x => x.Active)
                .IsRequired()
                .HasColumnName("ST_ACTIVE");
        }

        public virtual void ConfigureKey(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
