using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyGameStore.InMemory;
using TinyGameStore.Data;
namespace TinyGameStore_G2
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
            dgvGamesOfUser.AutoGenerateColumns = false;
            cmbUsers.DataSource = null;
            cmbUsers.DataSource = DBActions.db.Users.ToArray();
        }
        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User? selectedUser = cmbUsers.SelectedItem as User;
            if (selectedUser == null) return;

            List<Game> games = new List<Game>();
            try
            {
                games = DBActions.GetUsersGamesList(selectedUser.Id);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in fetching Games List " + err.Message);
            }

            dgvGamesOfUser.DataSource = null;
            dgvGamesOfUser.DataSource = games;
        }

        private void dgvGamesOfUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Game gameToRate = dgvGamesOfUser.SelectedRows[0].DataBoundItem as Game;
            User userThatRates = cmbUsers.SelectedItem as User;
            UsersGame ug = DBActions.db.UsersGames.First(UG => UG.GameId == gameToRate.Id && UG.UserId == userThatRates.Id);
            new frmRateGame(ug).Show();
        }
    }
}
