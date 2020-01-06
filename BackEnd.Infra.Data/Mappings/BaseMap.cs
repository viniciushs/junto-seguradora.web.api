namespace BackEnd.Infra.Data.Mappings
{
    using BackEnd.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class BaseMap<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("Id")
                .UseSqlServerIdentityColumn();

            builder.Property(c => c.CriadoEm)
                .HasColumnName("CriadoEm")
                .HasDefaultValue();

            builder.Property(c => c.Ativo)
                .HasColumnName("Ativo")
                .HasDefaultValue(true);
        }
    }
}
