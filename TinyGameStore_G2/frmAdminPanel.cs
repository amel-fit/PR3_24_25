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
            cmbUsers.DataSource = InMemoryDb.GetUsers();
        }

        

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User? selectedUser = cmbUsers.SelectedItem as User;
            if (selectedUser == null) return;

            List<Game> games = new List<Game>();
            try
            {
                games = InMemoryDb.GetGamesList(selectedUser.Id);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in fetching Games List " + err.Message);
            }

            dgvGamesOfUser.DataSource = null;
            dgvGamesOfUser.DataSource = games;
        }
    }
}
