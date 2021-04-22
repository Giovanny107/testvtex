using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {

        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Types> Types { get; set; }
        public DbSet<Companies> Companies { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public DbSet<ActorsXMovie> ActorsXMovie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>()
                .HasOne(c => c.Companies)
                .WithMany(x => x.Movies)
                .HasForeignKey(f => f.IdCompany);

            modelBuilder.Entity<Movies>()
                .HasOne(c => c.Types)
                .WithMany(x => x.Movies)
                .HasForeignKey(f => f.IdType);

            modelBuilder.Entity<ActorsXMovie>()
                .HasOne(c => c.Actors)
                .WithMany(x => x.ActorsXMovie)
                .HasForeignKey(f => f.IdActor);

            modelBuilder.Entity<ActorsXMovie>()
                .HasOne(c => c.Movies)
                .WithMany(x => x.ActorsXMovie)
                .HasForeignKey(f => f.IdMovie);
        }
    }
}
