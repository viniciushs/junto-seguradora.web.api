namespace BackEnd.Infra.Data.Mappings
{
    using BackEnd.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System.ComponentModel.DataAnnotations.Schema;

    public abstract class BaseEnumMap<TEntity> : BaseMap<TEntity>
        where TEntity : BaseEnumEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedNever()
                .HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.None)
                .IsRequired();

            builder.Property(c => c.CriadoEm)
                .HasColumnName("CriadoEm")
                .HasDefaultValue();

            builder.Property(c => c.Ativo)
                .HasColumnName("Ativo")
                .HasDefaultValue(true);

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(16)")
                .HasMaxLength(16)
                .IsRequired();
        }
    }
}
