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
    public partial class Form7 : Form
    {
        const decimal Fee = 500m;
        public Form7()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TimeSpan diff = dateTimePicker2.Value - dateTimePicker1.Value;
            int day = (int)diff.TotalDays;
            textBox2.Text = day.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal Guest, ReturnValue;

            try
            {
                Guest = decimal.Parse(textBox3.Text);
                ReturnValue = DateClass.NumberOfGuests(Guest, Fee);

                textBox1.Text = ReturnValue.ToString("C");
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error confirmation");
                MessageBox.Show("Invalid input" + Environment.NewLine+
                                "Please enter numeric value for a number guest", "Error in input"
                               , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           // HomePage homePage newform=new Home Homepage

        }
    }
}
