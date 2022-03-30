using BookBiz_Management_System.DataAccess;
using BookBiz_Management_System.Models;
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
        public static Employee employee;
        public static string role;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var context = new DB())
            {
                try
                {
                    employee = context.Employees.Where(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if(employee != null)
                {
                    role = context.Roles.Where(x => x.Id == employee.Role).FirstOrDefault().RoleName;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            if(employee != null)
            {
                this.Hide();
                email = employee.FirstName + " " + employee.LastName;
                switch (role)
                {
                    case "MIS Manager":
                        MISDashboard dashboard = new MISDashboard();
                        dashboard.Show();
                        break;
                    case "Sales Manager":
                        SMDashboard sMDashboard = new SMDashboard();
                        sMDashboard.Show();
                        break;
                    case "Inventory Controller":
                        ICDashboard ICDashboard = new ICDashboard();
                        ICDashboard.Show();
                        break;
                    case "Order Clerks":
                        OCDashboard oCDashboard = new OCDashboard();
                        oCDashboard.Show(); 
                        break;
                    case "User":

                        break;
                    default:
                        break;
                }
            }
            
            
        }
    }
}
