using System;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Data.Common;
using System.ComponentModel.DataAnnotations.Schema;


namespace TinyGameStore.Data
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte[]? CoverArt { get; set; }
        public decimal Price { get; set; }

        public virtual List<GamesGenre> GamesGenres { get; set; } = new List<GamesGenre>();
        public virtual List<UsersGame> UsersGames { get; set; } = new List<UsersGame>();
        public virtual List<GameRating> GameRatings { get; set; }

        [NotMapped]
        public Image? coverArt;

        public Game()
        {
            if (CoverArt != null)
                coverArt = Image.FromStream(new MemoryStream(CoverArt));
            else
                coverArt = Image.FromFile("C:\\Users\\Amel Fit\\OneDrive - Faculty of Information Technologies\\Desktop\\PR3\\New Vjezbe\\TinyGameStore_G2\\Resources\\Marketing_Logo.png");
            
        }
        private Image getImageFromBytes()
        {
            return Image.FromStream(new MemoryStream(CoverArt));
            
        }


    }
}