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

        public static void AddUserGame(UsersGame ug)
        {
            db.UsersGames.Add(ug);
            db.SaveChanges();
        }

        public static User? Authenticate(User user)
        {
            var returnUserArray = db.Users.ToList().Where(u => u.UserName.ToLower() == user.UserName.ToLower() && u.Password == user.Password);
            if ((!returnUserArray.Any())) //apparently Any() is faster than Count() for some reason
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

        public static List<UsersGame> GetUsersGamesList(int userId)
        {
            return db.UsersGames.Where(ug => ug.UserId == userId).ToList();
        }
        public static List<Game> GetGamesList(int userId)
        {
            //NOLINQ
            {  
                var UsersGamesList = GetUsersGamesList(userId);
                List<Game> GamesList = new List<Game>();
                foreach (var UserGame in UsersGamesList)
                        GamesList.Add(db.Games.First(g => g.Id == UserGame.GameId));               
            
                return GamesList;
            }

            //LINQ Invoke
            {
                var GamesListQuery = db.UsersGames.Select(UG => db.Games.FirstOrDefault(game => UG.GameId == game.Id && UG.UserId == userId));
                return GamesListQuery.Where(x => true).ToList();
                List<Game> GamesList = new List<Game>();
                for (int i = 0; i < GamesListQuery.Count(); i++)
                {
                    GamesList.Add(GamesListQuery.ElementAt(i));
                }
                return GamesList;
            }


            
            //Pure LINQ
            {
                List<Game> GamesList =
                                (List<Game>)
                                (from UG in db.UsersGames
                                where UG.UserId == userId
                                select 
                                    (from game in db.Games
                                    where game.Id == UG.GameId
                                    select game));
                return GamesList;
            }

        }
        public static List<Game> getGamesList() => Games;

        public static List<User> GetUsers() => Users;
        
    }
}