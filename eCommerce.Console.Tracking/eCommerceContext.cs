﻿using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True;");
                //.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
                //.EnableSensitiveDataLogging();
        }        


        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public DbSet<Departamento>? Departamentos { get; set; }
    }
}
