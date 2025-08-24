using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using netflix_backend.models;

namespace netflix_backend.Data
{
    public class NetflixCloneDbContext : DbContext
    {
        public NetflixCloneDbContext(DbContextOptions<NetflixCloneDbContext> options) : base(options)
        {

        }

        public DbSet<FilmEntry> FilmEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                }
            );
        }
    }
}