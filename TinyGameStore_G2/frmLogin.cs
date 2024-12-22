using TinyGameStore.Data;
using TinyGameStore.InMemory;

namespace TinyGameStore_G2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();          
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text
            };

            var result = InMemoryDb.Authenticate(user);

            if (result == null)
                MessageBox.Show("Authentication failed",
                    "Tiny game store",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                new frmStore(result).Show();
                this.Hide();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSignIn_Click(sender, e);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSignIn_Click(sender, e);
        }
    }
}