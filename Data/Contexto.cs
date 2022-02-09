using API.ENTIDADES.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class Contexto : DbContext
    {
        public DbSet<Heroe> Heroes { get; set; }
        public DbSet<Villano> Villanos { get; set; }
        public DbSet<Mundo> Mundos { get; set; }
        public DbSet<Peleas> Batalla { get; set; }
        public DbSet<Poderes> Poderes { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Peleas>().HasKey(k => k.Id_Batalla);
            modelBuilder.Entity<Poderes>().HasKey(k => k.Id_Poder);
            modelBuilder.Entity<Heroe>().HasKey(k => k.Id_Heroes);
            modelBuilder.Entity<Villano>().HasKey(k => k.Id_Villanos);
            modelBuilder.Entity<Mundo>().HasKey(k => k.Id_Mundo);
            modelBuilder.Entity<Peleas>()
            .HasOne(p => p.Heroe)
            .WithOne()
            .HasForeignKey<Peleas>(c => new { c.Id_Heroes });
            modelBuilder.Entity<Peleas>()
            .HasOne(p => p.Villano)
            .WithOne()
            .HasForeignKey<Peleas>(c => new { c.Id_Villanos });
            modelBuilder.Entity<Peleas>()
            .HasOne(p => p.Mundo)
            .WithOne()
            .HasForeignKey<Peleas>(c => new { c.Id_Mundo});
            modelBuilder.Entity<Poderes>()
            .HasOne(a => a.Heroe)
            .WithOne()
            .HasForeignKey<Poderes>(c => new { c.Id_Heroes });
            modelBuilder.Entity<Poderes>()
            .HasOne(p => p.Villano)
            .WithOne()
            .HasForeignKey<Poderes>(c => new { c.Id_Villanos });
        }
        }

}
