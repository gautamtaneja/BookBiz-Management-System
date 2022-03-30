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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        public void AddClienttodb()
        {
            using (var context = new DB())
            {
                context.Clients.Add(new Models.Client
                {
                    Name="",
                    Street="",
                    City="",
                    PostalCode="",
                    PhoneNumber=1,
                    FaxNumber=1,
                    CreditLimit=0,
                });
                context.SaveChanges();
            }

            using (var context = new DB())
            {
                context.Employees.Add(new Models.Employee
                {
                   FirstName="",
                   LastName="",
                   Email="",
                   Password = "",
                   Role = 1
                });
                context.SaveChanges();
            }


            using (var context = new DB())
            {
                context.Employees.Add(new Models.Employee
                {
                    FirstName = "",
                    LastName = "",
                    Email = "",
                    Password = "",
                    Role = 1
                });
                context.SaveChanges();
            }
           
        }
    }
}
