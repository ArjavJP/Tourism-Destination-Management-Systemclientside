using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;

namespace Tourism_Destination_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string password = txtpass.Text;

            UserOperations userOperations = new UserOperations();
            DataTable dt = userOperations.Login(email, password);

            if (dt.Rows.Count > 0)
            {
                bool isAdmin = Convert.ToBoolean(dt.Rows[0]["isAdmin"]);
                if (isAdmin)
                {
                    // Redirect to admin page or show admin-specific functionality
                    MessageBox.Show("Login successful (Admin)!");
                }
                else
                {
                    // Redirect to user page or show user-specific functionality
                    MessageBox.Show("Login successful (User)!");
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password!");
            }
        }

        private void Register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Res = new Register();
            Res.ShowDialog();
        }
    }
}
