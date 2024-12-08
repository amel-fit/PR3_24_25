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
    public partial class frmStore : Form
    {
        private User LoggedUser { get; set; }
        public frmStore()
        {
            InitializeComponent();
            dgvGames.AutoGenerateColumns = false;
            dgvGames.DataSource = null;
            dgvGames.DataSource = InMemoryDb.getGamesList();
        }

        public frmStore(User user) : this()
        {
            LoggedUser = user;
            lblUsername.Text = LoggedUser.UserName;
        }

        private void frmStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            var SelectedGames = dgvGames.SelectedRows;
            for (int i = 0; i < SelectedGames.Count; i++)
            {
                if (SelectedGames[i]?.DataBoundItem is Game)
                {
                    Game game = SelectedGames[i].DataBoundItem as Game;
                    UsersGame ug = new UsersGame()
                    {
                        //User data
                        User = LoggedUser,
                        UserId = LoggedUser.Id,
                        //Purchase Data
                        PurchaseDate = DateTime.Now,
                        IsGifted = false,
                        Id = LoggedUser.UsersGames.Count,
                        //Game data
                        Game = game,
                        GameId = game.Id,
                        //GameRatings = new List<GameRating>() //don't know what I gotta do here yet...
                    };
                    if (!UserHasGame(ug))
                        LoggedUser.UsersGames.Add(ug);
                }
            }

        }

        private bool UserHasGame(UsersGame ug)
        {
            foreach (var userGame in LoggedUser.UsersGames)
            {
                if (userGame.GameId == ug.GameId)
                    return true;
            }
            return false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var AdminPanel = new frmAdminPanel();
            AdminPanel.Show();
        }
    }
}
