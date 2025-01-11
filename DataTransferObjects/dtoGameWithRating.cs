using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyGameStore.Data;
using TinyGameStore.InMemory;

namespace DataTransferObjects
{
    public class dtoGameWithRating
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float AverageScore { get; set; }
        private int GameId { get; set; }
        public Game G {  get; set; }

        public dtoGameWithRating(Game g)
        {
            G = g;
            GameId = g.Id;

            Name = g.Name;
            Publisher = g.Publisher;
            ReleaseDate = g.ReleaseDate;

            AverageScore = CalculateAverage();
        }

        private float CalculateAverage()
        {
            return 1;
            int sum = 0;
            int counter = 0;
            var lstUsersGames = DBActions.db.UsersGames.Where(ug => ug.GameId == GameId).ToList();
            foreach (var ug in lstUsersGames) {
                var allGameRatings = DBActions.db.GameRatings.Where(gr => gr.UserGamesId == ug.Id).ToList();
                foreach(var gr in allGameRatings)
                {
                    sum += gr.Rating;
                    counter++;
                }
            }
            return sum / MathF.Max(sum, 1);
        }

    }
}
