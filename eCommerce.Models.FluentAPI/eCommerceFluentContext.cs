using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eCommerce.Models.FluentAPI
{
    internal class eCommerceFluentContext : DbContext
    {

        public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options)
        {

        }

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public DbSet<Departamento>? Departamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* 
             *  Table, Column, NotMapped
             *  DatabaseGenerated
             *  ( Nome      = ValueGeneratedNever ,
             *    Identity  = ValueGeneratedOnAdd ,
             *    Computed  = ValueGeneratedOnAddOrUpdate
             *  )
             */
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");
            modelBuilder.Entity<Usuario>().Property(a => a.RG).HasColumnName("REGISTRO_GERAL").HasMaxLength(10).HasDefaultValue("RG-AUSENTE").IsRequired();
            modelBuilder.Entity<Usuario>().Ignore(a => a.Sexo);
            modelBuilder.Entity<Usuario>().Property(a => a.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<Usuario>().HasIndex("CPF").IsUnique().HasFilter("[CPF] is not null").HasDatabaseName("IX_CPF_UNIQUE");
            modelBuilder.Entity<Usuario>().HasIndex(a => a.CPF);

            modelBuilder.Entity<Usuario>().HasIndex("CPF", "Email");
            modelBuilder.Entity<Usuario>().HasIndex(a => new { a.CPF, a.Email });

            // Keys
            modelBuilder.Entity<Usuario>().HasKey("Id");
            modelBuilder.Entity<Usuario>().HasKey(a => a.Id);

            modelBuilder.Entity<Usuario>().HasKey("Id", "CPF");
            modelBuilder.Entity<Usuario>().HasKey(a => new { a.Id, a.CPF });
            
            modelBuilder.Entity<Usuario>().HasAlternateKey("CPF", "Email");
            modelBuilder.Entity<Usuario>().HasNoKey();




        }

    }
}
