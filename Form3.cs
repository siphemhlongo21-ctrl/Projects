using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static Project_Draft.LoginMananger;

namespace Project_Draft
{
    public partial class login : Form
    {
        private Dictionary<string, string> userAccounts;
        public login(Dictionary<string, string> accounts)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            userAccounts = accounts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if ((userAccounts.ContainsKey(username) && (userAccounts[username] == password)))
            {
                MessageBox.Show("Login successful!");
                //Home homeForm = new Home(username, userAccounts);
                //homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }


        }
     

      

        private void button2_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        
    }
}