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
            cmbUsers.DataSource = null;
            cmbUsers.DataSource = InMemoryDb.GetUsers();
            dgvGamesOfUser.AutoGenerateColumns = false;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User selectedUser = cmbUsers.SelectedItem as User;
            if (selectedUser == null) return;

            dgvGamesOfUser.DataSource = null;
            
            List<Game> games = new List<Game>();
            foreach (var userGame in selectedUser.UsersGames)
            {
                
                games.Add(userGame.Game);
            }
            dgvGamesOfUser.DataSource = games;
        }
    }
}
