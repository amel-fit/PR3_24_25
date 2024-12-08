using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyGameStore_G2
{
    public partial class frmStore : Form
    {
        public frmStore()
        {
            InitializeComponent();
        }

        private void frmStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
