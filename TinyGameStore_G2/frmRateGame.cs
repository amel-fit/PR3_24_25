using System;
using System.CodeDom;
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
    public partial class frmRateGame : Form
    {
        Game GameToRate { get; set; }
        User UserThatRates { get; set; }

        UsersGame UserGame { get; set; }
        public frmRateGame()
        {
            InitializeComponent();
        }
        public frmRateGame(Game g, User u) : this() 
        {
            UserGame = InMemoryDb.db.UsersGames.First(x => x.GameId == g.Id && x.UserId == u.Id);
            GameToRate = g;
            UserThatRates = u;
            lblGame.Text = g.Name;
            lblUserName.Text = u.UserName;
        }
        public frmRateGame(UsersGame ug) : this()
        {
            UserGame = ug;

            GameToRate = ug.Game;
            UserThatRates = ug.User;
            
            lblUserName.Text = ug.User.UserName;
            lblGame.Text = ug.Game.Name;
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            var rating = new GameRating()
            {
                UserGamesId = UserGame.Id,
                Rating = int.Parse(gbRatings.Controls.OfType<RadioButton>().First(rb => rb.Checked == true).Text)
            };
            //now to check if the user already rated this gamae
            if(!HasUserAlreadyRated(UserGame))
                InMemoryDb.AddGameRating(rating);
            else
                MessageBox.Show("You have already rated this game");
        }

        private bool HasUserAlreadyRated(UsersGame userGame)
        {
            return InMemoryDb.db.GameRatings.Where(gr => gr.UserGamesId == UserGame.Id).Any();
        }
    }
}
