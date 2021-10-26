using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPI.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Produto>()
                .Property(p => p.nome)
                    .HasMaxLength(45);

            modelBuilder.Entity<Produto>()
                .Property(p => p.tamanho)
                    .HasMaxLength(4);

            modelBuilder.Entity<Produto>()
                .Property(p => p.categoria)
                    .HasMaxLength(45);

            modelBuilder.Entity<Produto>()
                .Property(p => p.divisao)
                    .HasMaxLength(15);

            modelBuilder.Entity<Produto>()
                .Property(p => p.descricao)
                    .HasMaxLength(250);

            modelBuilder.Entity<Produto>()
                .Property(p => p.fornecedor)
                    .HasMaxLength(45);

            modelBuilder.Entity<Produto>()
                .Property(p => p.imagem)
                    .HasMaxLength(300);

            modelBuilder.Entity<Produto>()
                .Property(p => p.usuario_alt)
                    .HasMaxLength(45);


        }
    }
}
