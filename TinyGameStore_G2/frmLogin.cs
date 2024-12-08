using TinyGamesStore.InMemory;

namespace TinyGameStore_G2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                loginFail(new Exception("No pass or usname"));
                return;
            }


            foreach (var usr in InMemoryDB.UsersList)
            {
                if (usr.UserName == txtUsername.Text && usr.Password == txtPassword.Text)
                {
                    loginSuccess();
                    return;
                }
            }
            loginFail(new Exception("Wrong username or password"));
        }

        private void loginSuccess()
        {
            //MessageBox.Show("Login Success");
            TinyGameStore_G2.Program.Store.Show();
            TinyGameStore_G2.Program.Store.Text = $"Welcome, {txtUsername.Text}";
            this.Hide();
            //this.Close();//bad
        }

        private void loginFail(Exception? e)
        {
            string message = (e == null) ? "Error" : e.Message;
            MessageBox.Show(message);

        }

        //when enter pressed:
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter) 
            {
                btnLogin_Click(sender, e);    
            }
        }
    }
}