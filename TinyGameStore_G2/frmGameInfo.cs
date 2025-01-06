using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyGameStore.Data;
using TinyGameStore.InMemory;

namespace TinyGameStore_G2
{
    public partial class frmGameInfo : Form
    {
        public frmGameInfo()
        {
            InitializeComponent();
        }
        private async Task<string> GetGenresText(Game game)
        {
            StringBuilder genresText = new();
            var genresList = DBActions.db.GamesGenres.Where(gg => gg.GameId == game.Id).Select(gg => gg.Genre).ToList();
            
            int genreNum = genresList.Count();
            for (int i = 0; i < genreNum - 1; i++)
            {
                genresText.Append(genresList.ElementAt(i) + "; ");
            }
           
            genresText.Append(genresList.Last().Name);
            return genresText.ToString();
        }
        public frmGameInfo(Game game) : this()
        {
            var genresTextTask = GetGenresText(game);
            txtGameName.Text = game.Name;
            txtPublisher.Text = game.Publisher;
            txtReleaseDate.Text = game.ReleaseDate.ToString();
            lblPrice.Text = "$" + game.Price.ToString();
            try
            {
                txtGenres.Text = genresTextTask.Result;
            }
            catch (Exception ex) {
                txtGenres.Text = "No specified genres";
            }
            

        }
    }
}
