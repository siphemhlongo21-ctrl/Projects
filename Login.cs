using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Login : Form
    {
        private ListBox list;
        public ListBox MyListBox { get; }

        public Login(ListBox newList)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MyListBox = listBox1;
            list = newList;

            foreach (var item in list.Items)
            {
                listBox1.Items.Add(item.ToString());
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            logpanel.Visible = true;
            handspicturebox.Visible = false;
            signinbutton.Visible = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                PasswordtextBox1.PasswordChar = '\0'; // Set to an empty character
            }
            else
            {
                PasswordtextBox1.PasswordChar = '*'; // Set to the default character
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((usernametextBox.Text == "User123") && (PasswordtextBox1.Text == "12345"))
            {
                UserHome user = new UserHome();
                user.Show();
            }
            if ((usernametextBox.Text == "Pharmacist") && (PasswordtextBox1.Text == "12345"))
            {
                
                Pharmacist p  = new Pharmacist(MyListBox);
                p.Show();
            }
        }

        private void signinbutton_Click_1(object sender, EventArgs e)
        {
            logpanel.Visible = true;
            handspicturebox.Visible = false;
            signinbutton.Visible = false;
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordtextBox1.PasswordChar = '\0'; // Set to an empty character
            }
            else
            {
                PasswordtextBox1.PasswordChar = '*'; // Set to the default character
            }
        }
    }
}
 