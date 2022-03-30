using BookBiz_Management_System.DataAccess;
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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void AddAuthortodb()
        {
            using (var context = new DB())
            {
                context.Authors.Add(new Models.Author
                {
                    FirstName = "",
                    LastName = "",
                    Email= ""

                });
                context.SaveChanges();
            }

        }
    }
}
