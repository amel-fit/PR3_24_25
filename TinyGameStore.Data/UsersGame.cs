namespace TinyGameStore.Data
{
    public class UsersGame
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public bool IsGifted { get; set; }
        public DateTime PurchaseDate { get; set; }
        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
        public virtual List<GameRating> GameRatings { get; set; } = new List<GameRating>();
    }
}