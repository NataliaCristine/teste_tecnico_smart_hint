using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using smartHint.Models;

namespace smartHint
{
    public partial class MyDbContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public DbSet<Fisica> Fisicas {get;set;}

        public DbSet<Juridico> Juridicos {get;set;}

        public DbSet<Loja> Lojas {get;set;}

        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user id=root;password=test;database=test", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<User>()
                .HasIndex(p => new {p.Email}).IsUnique();

            modelBuilder.Entity<Juridico>()
                .HasIndex(p => new {p.Cnpj, p.InscricaoEstadual}).IsUnique();

            modelBuilder.Entity<Fisica>()
                .HasIndex(p => new {p.Cpf}).IsUnique();

            OnModelCreatingPartial(modelBuilder);
        }
                     

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
