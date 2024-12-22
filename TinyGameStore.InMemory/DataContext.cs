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
        //public DbSet<UsersGames> UsersGames { get; set; } //not yet :)
        public DataContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source = {dbPath}");
        }


    }
}
