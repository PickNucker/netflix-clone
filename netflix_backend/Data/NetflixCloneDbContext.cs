using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using netflix_backend.models;

namespace netflix_backend.Data
{
    // Erbt von IdentityDbContext, damit auch alle Identity-Tabellen erstellt werden
    public class NetflixCloneDbContext : IdentityDbContext<IdentityUser>
    {
        public NetflixCloneDbContext(DbContextOptions<NetflixCloneDbContext> options) : base(options)
        {
        }

        // Deine eigene Tabelle für Filme
        public DbSet<FilmEntry> FilmEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Data für Filme
            modelBuilder.Entity<FilmEntry>().HasData(
                new FilmEntry
                {
                    Id = 1,
                    Title = "Inception",
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                    Genre = "Sci-Fi",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Rating = 8.8
                },
                new FilmEntry
                {
                    Id = 2,
                    Title = "The Dark Knight",
                    Description = "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                    Genre = "Action",
                    ReleaseDate = new DateTime(2008, 7, 18),
                    Rating = 9.0
                },
                new FilmEntry
                {
                    Id = 3,
                    Title = "Interstellar",
                    Description = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    Genre = "Sci-Fi",
                    ReleaseDate = new DateTime(2014, 11, 7),
                    Rating = 8.6
                },
                new FilmEntry
                {
                    Id = 4,
                    Title = "The Matrix",
                    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                    Genre = "Action",
                    ReleaseDate = new DateTime(1999, 3, 31),
                    Rating = 8.7
                },
                new FilmEntry
                {
                    Id = 5,
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                    Genre = "Crime",
                    ReleaseDate = new DateTime(1994, 10, 14),
                    Rating = 8.9
                }
            );
        }
    }
}