using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models.Exercicio.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_USUARIOS");
            builder.Property(a => a.RG).HasColumnName("REGISTRO_GERAL").HasMaxLength(10).HasDefaultValue("RG-AUSENTE").IsRequired();
            builder.Ignore(a => a.Sexo);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.HasIndex("CPF").IsUnique().HasFilter("[CPF] is not null").HasDatabaseName("IX_CPF_UNIQUE");
            builder.HasIndex(a => a.CPF);

            builder.HasIndex("CPF", "Email");
            builder.HasIndex(a => new { a.CPF, a.Email });

            // Keys
            builder.HasKey("Id");
            builder.HasKey(a => a.Id);

            builder.HasKey("Id", "CPF");
            builder.HasKey(a => new { a.Id, a.CPF });

            builder.HasAlternateKey("CPF", "Email");
            builder.HasNoKey();

            /*
             * One > 1 Propriedade de navegação do objeto único
             * Many > 1 Propriedade de navegação do Tipo Lista/Coleção
             */

            builder.HasOne(usu => usu.Contato).WithOne(cont => cont.Usuario).HasForeignKey<Contato>(a => a.UsuarioId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(usu => usu.EnderecosEntrega).WithOne(end => end.Usuario).HasForeignKey(end => end.UsuarioId);
            builder.HasMany(usu => usu.Departamentos).WithMany(dep => dep.Usuarios);

            builder.Property(a => a.RG).IsRequired().HasMaxLength(12);

            builder.Property(a => a.Preco).HasPrecision(2);
        }
    }
}
