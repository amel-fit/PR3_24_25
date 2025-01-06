using Microsoft.EntityFrameworkCore.Storage;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using TinyGameStore.Data;

namespace TinyGameStore.InMemory
{
    public class DBActions
    {
        public static DataContext db = new();
        
        public DBActions() { }

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

        public static void AddUserGame(UsersGame ug)
        {
            db.UsersGames.Add(ug);
            db.SaveChanges();
        }
        public static void AddGenre(Genre genre)
        {
            db.Genres.Add(genre);
            db.SaveChanges();
        }
        public static void AddGameGenre(GamesGenre GG)
        {
            db.GamesGenres.Add(GG);
            db.SaveChanges();
        }
        public static void AddGameRating(GameRating GR)
        {
            db.GameRatings.Add(GR);
            db.SaveChanges();
        }
        public static User? Authenticate(User user)
        {
            var returnUserArray = db.Users.ToList().Where(u => u.UserName.ToLower() == user.UserName.ToLower() && u.Password == user.Password);        
            if (!returnUserArray.Any())
                return null;
            return returnUserArray.ElementAt(0);
        }

        public static User? GetUserByUsername(string username)
        {
            var returnUserArray = db.Users.ToList().Where(u => u.UserName.ToLower() == username);
            if ((!returnUserArray.Any())) //apparently Any() is faster than Count() for some reason
                return null;
            return returnUserArray.ElementAt(0);
        }

        public static User? GetUserById(int id)
        {
            return db.Users.FirstOrDefault(u => u.Id == id);
        }

        public static List<Game> GetUsersGamesList(int userId)
        {
            var temp = db.UsersGames.Where(ug => ug.UserId == userId).Select(g => g.Game).ToList();
            return temp;
        }

        public static bool GameHasGenre(GamesGenre gameGenre)
        {
            return db.GamesGenres.Any(gg => gg.GameId == gameGenre.GameId && gg.GenreId == gameGenre.GenreId);
        }
    }
}