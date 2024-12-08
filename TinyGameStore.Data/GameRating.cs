namespace TinyGameStore.Data
{
    public class GameRating
    {
        public int Id { get; set; }
        public int UserGamesId { get; set; }
        public int Rating { get; set; }
        public virtual UsersGame UsersGame { get; set; }
    }
}