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
    public partial class Form1 : Form
    {
        Timer timer;
        private ListBox l;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            l = listBox1;
            // Initialize and configure the timer
            timer = new Timer();
            timer.Interval = 10000; // 10 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer.Stop();

            // Show the login form
            Login loginForm = new Login(l);
            loginForm.ShowDialog(); // Show the login form as a modal dialog
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
