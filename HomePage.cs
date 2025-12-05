using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Draft
{
    public partial class Home : Form

    {
        public Home(string username, Dictionary<string, string> userAccounts)
        {
            InitializeComponent();
            Welcome.Text = "Welcome, " + username + "!";
            this.WindowState = FormWindowState.Maximized;
        }
    



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayStandardControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayDeluxeControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplaySuiteControl();
        }

        private void DisplayStandardControl()
        {
            StandardControl standardControl = new StandardControl();
            DisplayUserControl(standardControl);
        }

        private void DisplayDeluxeControl()
        {
            Deluxe deluxeControl = new Deluxe();
            DisplayUserControl(deluxeControl);
        }

        private void DisplaySuiteControl()
        {
            Ensuite suiteControl = new Ensuite();
            DisplayUserControl(suiteControl);
        }

        private void DisplayUserControl(UserControl userControl)
        {
          
            RoomPanel.Controls.Clear();

           
            RoomPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
        }

        private void RoomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
