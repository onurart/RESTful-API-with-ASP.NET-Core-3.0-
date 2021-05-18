using BandAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.DbContexts
{
    public class BandAlbumContext : DbContext
    {
        public BandAlbumContext(DbContextOptions<BandAlbumContext> options) :
            base(options)
        {

        }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>().HasData(new Band()
            {
                Id = Guid.Parse("66d91052-69ba-44cd-a5d9-1c369e5fbc74"),
                Name = "Metallica",
                Founded = new DateTime(1880, 1, 1),
                MainGenre = "Heavy Metal"
            },
            new Band
            {
                Id = Guid.Parse("c66b75f1-b1dd-4d29-9d58-0fd581bcbef2"),
                Name = "Metallica",
                Founded = new DateTime(1880, 1, 1),
                MainGenre = "Heavy Metal"
            },
            new Band
            {
                Id = Guid.Parse("c76b75f1-b1dd-4d29-9d58-0fd581bcb2f2"),
                Name = "Metallica",
                Founded = new DateTime(1880, 1, 1),
                MainGenre = "Heavy Metal"
            });
            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    Id = Guid.Parse("3cfb608a-0b3b-4781-adb4-76042d236d97"),
                    Title = "Master",
                    Description = "onur",
                    BandId = Guid.Parse("66d91052-69ba-44cd-a5d9-1c369e5fbc74")
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
