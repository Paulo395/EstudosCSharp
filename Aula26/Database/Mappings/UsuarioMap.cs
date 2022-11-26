using Microsoft.EntityFrameworkCore;
using Aula26.Models.Usuario;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aula26.Data.Mappings;

public class UsuarioMap : IEntityTypeConfiguration<Usuario>{
    public void Configure(EntityTypeBuilder<Usuario> builder){
        //Tabela
        builder.ToTable("Usuario");

        //Chave Primaria
        builder.HasKey(x=>x.Id);

        //Identity
        builder.Property(x=>x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        //Propriedades
        builder.Property(x=> x.Nome)
            .IsRequired()
            .HasColumnName("Nome")
            .HasColumnName("NVARCHAR")
            .HasMaxLength(80);

        builder.Property(x=>x.Bio);
        builder.Property(x=>x.Email);
        builder.Property(x=>x.Image);
        builder.Property(x=>x.SenhaHash);

        builder.Property(x=>x.Slug)
            .IsRequired()
            .HasColumnName("Slug")
            .HasColumnName("VARCHAR")
            .HasMaxLength(80);

        //Indices
        builder
            .HasIndex(x=>x.Slug, "IX_Usuario_Slug")
            .IsUnique();
    }
}