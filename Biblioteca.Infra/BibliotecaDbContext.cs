using Biblioteca.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Biblioteca.Infra
{
    public class BibliotecaDbContext :DbContext
    {
        public BibliotecaDbContext(DbContextOptions<BibliotecaDbContext> options) :base(options)
        {

        }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().HasKey(p => p.Id);

            modelBuilder.Entity<User>().HasKey(p => p.Id);

            modelBuilder.Entity<Emprestimo>().ToTable("Livros em Emprestimos").HasKey(p => p.Id);
            modelBuilder.Entity<Emprestimo>()
                        .HasOne(p => p.User)
                        .WithMany()
                        .HasForeignKey(p => p.IdUser)
                        .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Emprestimo>()
                .HasOne(p => p.Livro)
                .WithOne()
                .HasForeignKey<Emprestimo>(p => p.IdLivro)
                .OnDelete(DeleteBehavior.Restrict);
            
                        
        }
    }
}
