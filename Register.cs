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
using BEL;

namespace Tourism_Destination_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            UserMst user = new UserMst
            {
                Name = txt_fullname.Text,
                Address = txtAddress.Text,
                PhoneNo = txtphoneno.Text,
                Password = txt_pass.Text,
                isAdmin = rbadmin.Checked
            };

            UserOperations userOperations = new UserOperations();
            int rowsAffected = userOperations.UserInsert(user);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registration successful!");
            }
            else
            {
                MessageBox.Show("Failed to register. Please try again.");
            }
        }
    }
}
