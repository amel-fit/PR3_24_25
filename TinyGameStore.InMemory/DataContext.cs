using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyGameStore.Data;

namespace TinyGameStore.InMemory
{
    public class DataContext : DbContext
    {
        string dbPath = "C:\\Users\\Amel Fit\\OneDrive - Faculty of Information Technologies\\Desktop\\PR3\\New Vjezbe\\TinyGameStore_G2\\Resources\\GamesStoreDB.db";
        public DbSet<Game> Games { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UsersGame> UsersGames { get; set; } 
        public DbSet<GamesGenre> GamesGenres { get; set; }
        public DbSet <Genre> Genres { get; set; }
        public DbSet <GameRating> GameRatings { get; set; }
        public DataContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source = {dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameRating>(entitiy =>
            {
                entitiy.HasOne(d => d.UsersGame).WithMany(p => p.GameRatings).HasForeignKey(d => d.UserGamesId);
            });
            modelBuilder.Entity<GamesGenre>(entity =>
            {
                entity.HasOne(d => d.Game).WithMany(p => p.GamesGenres).HasForeignKey(d => d.GameId);
                entity.HasOne(d => d.Genre).WithMany(p => p.GamesGenres).HasForeignKey(d => d.GenreId);
            });
            modelBuilder.Entity<UsersGame>(entity =>
            {
                entity.HasOne(d => d.Game).WithMany(p => p.UsersGames).HasForeignKey(d => d.GameId);
                entity.HasOne(d => d.User).WithMany(p => p.UsersGames).HasForeignKey(d => d.UserId);
            });
            
        }

        

    }
}
