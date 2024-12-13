using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using TinyGameStore.Data;

namespace TinyGameStore.InMemory
{
    public class InMemoryDb
    {
        private static DataContext db = new();
        
        private static List<User> Users { get => db.Users.ToList(); }
        private static List<Game> Games { get => db.Games.ToList(); }
        public InMemoryDb()
        {
            LoadUsers();
            LoadGames();
        }

        private void LoadGames()
        {
            return;
            var games = new List<Game>();
            //{
            //    new Game { Id = 100, Name = "DMC1", Publisher = "Capcom", ReleaseDate = new DateTime(2002, 12, 1) },
            //    new Game { Id = 200, Name = "DMC2", Publisher = "Capcom", ReleaseDate = new DateTime(2002, 12, 2)},
            //    new Game {Id = 333, Name= "DMC3", Publisher = "Capcom", ReleaseDate = new DateTime(2002, 12, 3)}
            //};

            foreach (var game in games)
            {
                AddGame(game);
            }
            

        }

        private void AddGame(Game game)
        {
            db.Games.Add(game);
            db.SaveChanges();
        }

        private void LoadUsers()
        {
            return;
            var users = new List<User>()
            {
                new User() { FirstName="Denis", LastName="Music", Birthdate = DateTime.Now, UserName = "Denis", Password = "test123"},
                new User() { FirstName="Denis", LastName="Music", Birthdate = DateTime.Now, UserName = "sudo", Password = "sudo"},
                new User() { FirstName="Denis", LastName="Music", Birthdate = DateTime.Now, UserName = "admin", Password = "password"},
                new User() { FirstName="Denis", LastName="Music", Birthdate = DateTime.Now, UserName = "emperor", Password = "protector"},
                new User() { FirstName="Denis", LastName="Music", Birthdate = DateTime.Now, UserName = "medresa", Password = "sifra"}
            };

            foreach (var user in users)
            {
                AddUser(user);
            }
        }

        public static void AddUser(User user)
        {

            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User? Authenticate(User user)
        {
            foreach (var us in Users)
            {
                if (us.UserName.ToLower() == user.UserName.ToLower()
                    && us.Password == user.Password)
                    return us;

            }

            return null;
        }

        public static User? getUser(string username)
        {
            foreach(var us in Users)
            {
                if(us.UserName.ToLower() == username.ToLower()) return us;
            }
            return null;
        }
        public static List<Game> getGamesList()
        {
            return Games;
        }

        public static List<User> GetUsers()
        {
            return Users;
        }
    }
}