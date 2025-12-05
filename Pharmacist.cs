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
    public partial class Pharmacist : Form
    {
        private ListBox _form1ListBox;

        public Pharmacist(ListBox ListBox)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            _form1ListBox = ListBox;
            foreach (var item in _form1ListBox.Items)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Size = new System.Drawing.Size(632, 524);
            listBox1.Location = new System.Drawing.Point(656, 3);
            MedicalSuppliespanel.Visible = false;
            Prescriptionpanel3.Visible = false;
            personalCarepanel3.Visible = false;
            Veterinarypanel3.Visible = false;
            AllItemspanel1.Visible = false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            AllItemspanel1.Location = new System.Drawing.Point(416, 12);

            AllItemspanel1.Size = new System.Drawing.Size(872, 596);
            AllItemspanel1.Visible = true;
            Prescriptionpanel3.Visible = false;
            personalCarepanel3.Visible = false;
            Veterinarypanel3.Visible = false;
            MedicalSuppliespanel.Visible = false;
            listBox1.Visible = false;

        }

        private void mertforminpictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void mertforminpanel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EliquispictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void subEliquislabel15_Click(object sender, EventArgs e)
        {

        }

        private void Eliquispanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Prescriptionpanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void antidepictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void subantidelabel13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prescriptionpanel3.Location = new System.Drawing.Point(726, 12);
            Prescriptionpanel3.Size = new System.Drawing.Size(521, 563);
            Prescriptionpanel3.Visible = true;
            MedicalSuppliespanel.Visible = false;
            personalCarepanel3.Visible = false;
            Veterinarypanel3.Visible = false;
            listBox1.Visible = false;
            AllItemspanel1.Visible = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Prescriptionpanel3.Location = new System.Drawing.Point(726, 12);
            Prescriptionpanel3.Size = new System.Drawing.Size(521, 563);
            Prescriptionpanel3.Visible = true;
            MedicalSuppliespanel.Visible = false;
            personalCarepanel3.Visible = false;
            Veterinarypanel3.Visible = false;
            listBox1.Visible = false;
            AllItemspanel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personalCarepanel3.Location = new System.Drawing.Point(726, 12);
            personalCarepanel3.Size = new System.Drawing.Size(521, 563);
            personalCarepanel3.Visible = true;
            Prescriptionpanel3.Visible = false;
            MedicalSuppliespanel.Visible = false;
            Veterinarypanel3.Visible = false;
            listBox1.Visible = false;
            AllItemspanel1.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Veterinarypanel3.Location = new System.Drawing.Point(726, 12);
            Veterinarypanel3.Size = new System.Drawing.Size(521, 563);
            Veterinarypanel3.Visible = true;
            Prescriptionpanel3.Visible = false;
            MedicalSuppliespanel.Visible = false;
            personalCarepanel3.Visible = false;
            listBox1.Visible = false;
            AllItemspanel1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            // Check if the  clicked OK
            if (result == DialogResult.OK)
            {
                Login l = new Login(_form1ListBox);
                l.Show();
            }
        }
    }
}
