using TinyGameStore.Data;

namespace TinyGamesStore.InMemory
{
    public static class InMemoryDB
    {
        public static List<User> UsersList { get; set; } = new List<User>();

        public static bool TryAdd(User user)
        {
            if(UsersList.Contains(user)) return false;
            UsersList.Add(user);
            return true;
        }
    }
}
