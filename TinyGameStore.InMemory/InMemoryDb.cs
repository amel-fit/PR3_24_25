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
        public InMemoryDb() { }

        private void AddGame(Game game)
        {
            db.Games.Add(game);
            db.SaveChanges();
        }
        public static void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User? Authenticate(User user)
        {
            var returnUserArray = db.Users.ToList().Where(u => u.UserName.ToLower() == user.UserName.ToLower() && u.Password == user.Password);
            if ((!returnUserArray.Any())) //apparently Any() is faster than Count() for some reason
                return null;
            return returnUserArray.ElementAt(0);
        }

        public static User? getUser(string username)
        {
            var returnUserArray = db.Users.ToList().Where(u => u.UserName.ToLower() == username);
            if ((!returnUserArray.Any())) //apparently Any() is faster than Count() for some reason
                return null;
            return returnUserArray.ElementAt(0);
        }
        public static List<Game> getGamesList() => Games;

        public static List<User> GetUsers() => Users;
        
    }
}