using TinyGameStore.Data;

namespace TinyGameStore.InMemory
{
    public class InMemoryDb
    {
        private static List<User> Users { get; set; }
        private static List<Game> Games { get; set; }
        public InMemoryDb()
        {
            FillMockData();
            FillMockGames();
        }

        private void FillMockGames()
        {
            Games = new List<Game>()
            {
                new Game { Id = 1, Name = "DMC1", Publisher = "Capcom", ReleaseDate = new DateTime(2002, 12, 1) },
                new Game { Id = 2, Name = "DMC2", Publisher = "Capcom", ReleaseDate = new DateTime(2002, 12, 2)},
                new Game {Id = 3, Name= "DMC3", Publisher = "Capcom", ReleaseDate = new DateTime(2002, 12, 3)}
            };
    }
        private void FillMockData()
        {
            Users = new List<User>()
            {
                new User() { UserName = "Denis", Password = "test123"},
                new User() { UserName = "sudo", Password = "sudo"},
                new User() { UserName = "admin", Password = "password"},
                new User() { UserName = "emperor", Password = "protector"},
                new User() { UserName = "medresa", Password = "sifra"}
            };
        }

        public static void AddUser(User user) => Users.Add(user);

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

        public static User getUser(string username)
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