namespace TinyGameStore.Data
{
    public class GamesGenre
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public int GameId { get; set; }
        public virtual Game Game { get; set; }
        public virtual Genre Genre { get; set; }
    }
}