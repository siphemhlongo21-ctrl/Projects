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
    public partial class StandardControl : UserControl
    {
        public StandardControl()
        {
            InitializeComponent();
        }

        private void Features_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Standard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LoginManager.IsLoggedIn)
            {
                Form7 newform = new Form7();
                newform.Show();
            }
            else
            {
                Form2 EYY = new Form2();
                EYY.Show();
            }

        }
       
    }
}   