using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz_Management_System
{
    public partial class Login : Form
    {
        public static string email=string.Empty;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "admin" && txtPassword.Text == "admin")
            {
                email = txtEmail.Text;
                MISDashboard dashboard = new MISDashboard();
                this.Hide();
                dashboard.Show();
            }
        }
    }
}
