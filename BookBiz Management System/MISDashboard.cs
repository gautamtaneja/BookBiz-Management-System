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
    public partial class MISDashboard : Form
    {
        public MISDashboard()
        {
            InitializeComponent();
        }

        private void MISDashboard_Load(object sender, EventArgs e)
        {
            lblEmail.Text = Login.email;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
