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

        public override string ToString()
        {
            return Game.Name;
        }

        public UsersGame()
        {
            
        }
        public UsersGame(User user, Game game, DateTime? buyDate = null, List<GameRating> gameRatings = null, bool isGifted = false)
        {
            User = user;
            UserId = user.Id;
            
            Game = game;
            GameId = game.Id;
            
            GameRatings = gameRatings;
            IsGifted = isGifted;
            
            if (buyDate == null)
                PurchaseDate = DateTime.Now;
            
            else
                PurchaseDate = buyDate.Value;
            

            Id = User.UsersGames.Count;

        }
    }
}