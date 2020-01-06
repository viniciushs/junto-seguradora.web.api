namespace BackEnd.Infra.Data.Mappings
{
    using BackEnd.Domain.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    /// <summary>
    ///     Configuração do Entity Framework para a classe <see cref="Seguradora"/>.
    /// </summary>
    public class SeguradoraMap : BaseMap<Seguradora>
    {
        public override void Configure(EntityTypeBuilder<Seguradora> builder)
        {
            base.Configure(builder);

            builder.ToTable("Seguradora");

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(256)")
                .HasMaxLength(256)
                .IsRequired();

            builder.Property(c => c.Cnpj)
                .HasColumnType("varchar(14)")
                .HasMaxLength(14)
                .IsRequired();

            this.Seed(builder);
        }

        public void Seed(EntityTypeBuilder<Seguradora> builder)
        {
            var seguradora1 = new Seguradora { Id = 1, Ativo = true, CriadoEm = DateTime.Now, Cnpj = "24751734000170", Nome = "Malu e Milena Seguradora" };
            var seguradora2 = new Seguradora { Id = 2, Ativo = true, CriadoEm = DateTime.Now, Cnpj = "76395991000110", Nome = "Bruno e Kauê Seguradora" };
            var seguradora3 = new Seguradora { Id = 3, Ativo = true, CriadoEm = DateTime.Now, Cnpj = "42597748000163", Nome = "Clarice e Osvaldo Seguradora" };
            var seguradora4 = new Seguradora { Id = 4, Ativo = true, CriadoEm = DateTime.Now, Cnpj = "08141045000198", Nome = "Luan e Emanuel Seguradora" };
            var seguradora5 = new Seguradora { Id = 5, Ativo = true, CriadoEm = DateTime.Now, Cnpj = "25934594000139", Nome = "Carla e Severino Seguradora" };

            builder.HasData(
                seguradora1,
                seguradora2,
                seguradora3,
                seguradora4,
                seguradora5
            );
        }
    }
}
