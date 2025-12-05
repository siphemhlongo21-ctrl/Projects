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
using System.Windows.Forms;
using System.Diagnostics;// Added during programming


namespace Project_Draft
{
    public partial class signup : Form
    {
        DialogResult Selection;
        String FullName;
        private Dictionary<string, string> userAccounts = new Dictionary<string, string>();
        private login loginForm;

        public signup()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string Email = txtEMAIL.Text;
            string Cellphone = TxtCellphone.Text;

            if (!string.IsNullOrWhiteSpace(username) || !string.IsNullOrWhiteSpace(password))

            {
                if (!string.IsNullOrWhiteSpace(Email) || !string.IsNullOrWhiteSpace(Cellphone))
                {
                    if (TermsandC.Checked)
                    {
                        if (txtPassword.Text == txtRepassword.Text)

                        {
                            if (password.Length >= 8 && password.Length <= 12)
                            {


                                if (!userAccounts.ContainsKey(username))
                                {
                                    userAccounts.Add(username, password);
                                    MessageBox.Show("Account created successfully!");
                                    login loginForm = new login(userAccounts);
                                    loginForm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Username already exists. Please choose a different username.", "Message");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password must be between 8 and 12 characters.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match. Please try again.");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Please accept terms and conditions to continue.", " Message");
                    }
                }
                else
                {
                    MessageBox.Show("Phone number OR Email Address cannot be empty.", "Message");
                }
            }
            else
            {
                MessageBox.Show("Username OR password cannot be empty.", "Message");

            }
        }



        private void radioBtn1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioBtn1.Checked)//Alternative method if(radioBtn1.Checked==true)
                                  // Or if(!(radioBtn1.Checked==false))
            {
                //Once you made the selection in one radio button automatically the other remaining will be diselected
                radioBtn2.Enabled = false;
                radioBtn3.Enabled = false;
                radioBtn4.Enabled = false;
                radioBtn5.Enabled = false;
                radioBtn6.Enabled = false;
                radioBtn7.Enabled = false;

                txtUsername.Enabled = false;
                TxtSurname.Enabled = false;
                MessageBox.Show("You've made the selection, you cannot change the provided details", "Confirmation");

                //Soon as the user selects the preferred title the firstname and lastname will be concatenated into fullname
                FullName = txtUsername.Text + "  " + TxtSurname.Text;
                txtFullName.Text = FullName;

                txtFullName.ReadOnly = true;

                Selection = MessageBox.Show("Are the above details correct?", "Confirmation", MessageBoxButtons.YesNo);

                if (!(Selection == DialogResult.No))
                {

                    MessageBox.Show("The selection & the details above are correct", "Confirmation");

                }
                else
                {
                    txtUsername.Text = "";
                    TxtSurname.Text = "";
                    txtFullName.Text = "";
                    txtEMAIL.Text = "";
                    //masktxtCellNo.Clear();
                    txtUsername.Enabled = true;
                    TxtSurname.Enabled = true;

                }
            }
            else
            {
                radioBtn2.Enabled = true;
                radioBtn3.Enabled = true;
                radioBtn4.Enabled = true;
                radioBtn5.Enabled = true;
                radioBtn6.Enabled = true;
                radioBtn7.Enabled = true;
                txtUsername.Enabled = true;
                TxtSurname.Enabled = true;
                txtFullName.ReadOnly = false;
            }

        }

        private void radioBtn2_CheckedChanged(object sender, EventArgs e)
        {
            if (!(radioBtn2.Checked == false))
            {
                //Once you made the selection in one radio button automatically the other remaining will be diselected
                radioBtn1.Enabled = false;
                radioBtn3.Enabled = false;
                radioBtn4.Enabled = false;
                radioBtn5.Enabled = false;
                radioBtn6.Enabled = false;
                radioBtn7.Enabled = false;

                txtUsername.Enabled = false;
                TxtSurname.Enabled = false;
                MessageBox.Show("You've made the selection, the string values above cannot be changed",
                               "Confirmation");
                FullName = txtUsername.Text + "  " + TxtSurname.Text;
                txtFullName.Text = FullName;
                txtFullName.ReadOnly = true;

                Selection = MessageBox.Show("Are the above details correct?", "Confirmation", MessageBoxButtons.YesNo);

                if (!(Selection == DialogResult.No))
                {
                    MessageBox.Show("The selection & the details above are correct", "Confirmation");
                }
                else
                {
                    txtUsername.Text = "";
                    TxtSurname.Text = "";
                    txtFullName.Text = "";
                    txtEMAIL.Text = "";
                   // masktxtCellNo.Clear();
                    txtUsername.Enabled = true;
                    TxtSurname.Enabled = true;

                }



            }
            else
            {
                radioBtn1.Enabled = true;
                radioBtn3.Enabled = true;
                radioBtn4.Enabled = true;
                radioBtn5.Enabled = true;
                radioBtn6.Enabled = true;
                radioBtn7.Enabled = true;


                txtUsername.Text = "";
                TxtSurname.Text = "";
                txtFullName.Text = "";
                txtEMAIL.Text = "";
                //masktxtCellNo.Clear();
                txtUsername.Enabled = true;
                TxtSurname.Enabled = true;
            }
        }

        private void radioBtn3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioBtn3.Checked == true)
            {
                //Once you made the selection in one radio button automatically the other remaining will be diselected
                radioBtn1.Enabled = false;
                radioBtn2.Enabled = false;
                radioBtn4.Enabled = false;
                radioBtn5.Enabled = false;
                radioBtn6.Enabled = false;
                radioBtn7.Enabled = false;

                txtUsername.Enabled = false;
                TxtSurname.Enabled = false;
                MessageBox.Show("You've made the selection, the string values above cannot be changed",
                               "Confirmation");
                FullName = txtUsername.Text + "  " + TxtSurname.Text;
                txtFullName.Text = FullName;
                txtFullName.ReadOnly = true;

                Selection = MessageBox.Show("Are the above details correct?", "Confirmation", MessageBoxButtons.YesNo);

                if (!(Selection == DialogResult.No))
                {
                    MessageBox.Show("The selection & the details above are correct", "Confirmation");
                }
                else
                {
                    txtUsername.Text = "";
                    TxtSurname.Text = "";
                    txtFullName.Text = "";
                    txtEMAIL.Text = "";
                   // masktxtCellNo.Clear();
                    txtUsername.Enabled = true;
                    TxtSurname.Enabled = true;

                }


            }
            else
            {
                radioBtn1.Enabled = true;
                radioBtn2.Enabled = true;
                radioBtn4.Enabled = true;
                radioBtn5.Enabled = true;
                radioBtn6.Enabled = true;
                radioBtn7.Enabled = true;
                txtUsername.Enabled = true;
                TxtSurname.Enabled = true;
                txtFullName.ReadOnly = false;
            }
        }

        private void radioBtn4_CheckedChanged(object sender, EventArgs e)
        {
            if (!(radioBtn4.Checked == false))
            {
                //Once you've made the selection in one radio button automatically the other remaining will be diselected
                radioBtn1.Enabled = false;
                radioBtn2.Enabled = false;
                radioBtn3.Enabled = false;
                radioBtn5.Enabled = false;
                radioBtn6.Enabled = false;
                radioBtn7.Enabled = false;

                txtUsername.Enabled = false;
                TxtSurname.Enabled = false;
                MessageBox.Show("You've made the selection, the string values above cannot be changed",
                               "Confirmation");
                //The above disabled textboxes forces the user to continue
                FullName = txtUsername.Text + "  " + TxtSurname.Text;
                txtFullName.Text = FullName;
                txtFullName.ReadOnly = true;

                Selection = MessageBox.Show("Are the above details correct?", "Confirmation", MessageBoxButtons.YesNo);

                if (!(Selection == DialogResult.No))
                {
                    MessageBox.Show("The selection & the details above are correct", "Confirmation");
                }
                else
                {
                    txtUsername.Text = "";
                    TxtSurname.Text = "";
                    txtFullName.Text = "";
                    txtEMAIL.Text = "";
                    //masktxtCellNo.Clear();
                    txtUsername.Enabled = true;
                    TxtSurname.Enabled = true;

                }

            }
            else
            {
                radioBtn1.Enabled = true;
                radioBtn2.Enabled = true;
                radioBtn3.Enabled = true;
                radioBtn5.Enabled = true;
                radioBtn6.Enabled = true;
                radioBtn7.Enabled = true;
                txtUsername.Enabled = true;
                TxtSurname.Enabled = true;
                txtFullName.ReadOnly = false;
            }
        }

        private void radioBtn5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn5.Checked)
            {


                txtUsername.Enabled = false;
                TxtSurname.Enabled = false;
                MessageBox.Show("You've made the selection, the string values above cannot be changed",
                               "Confirmation");
                FullName = txtUsername.Text + "  " + TxtSurname.Text;
                txtFullName.Text = FullName;
                txtFullName.ReadOnly = true;

                Selection = MessageBox.Show("Are the above details correct?", "Confirmation", MessageBoxButtons.YesNo);

                if (!(Selection == DialogResult.No))
                {
                    MessageBox.Show("The selection & the details above are correct", "Confirmation");
                }
                else
                {
                    txtUsername.Text = "";
                    TxtSurname.Text = "";
                    txtFullName.Text = "";
                    txtEMAIL.Text = "";
                    //masktxtCellNo.Clear();
                    txtUsername.Enabled = true;
                    TxtSurname.Enabled = true;

                }

            }
        }

        private void radioBtn6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn6.Checked == true)
            {

                txtUsername.Enabled = false;
                TxtSurname.Enabled = false;
                MessageBox.Show("You've made the selection, the string values above cannot be changed",
                               "Confirmation");
                FullName = txtUsername.Text + "  " + TxtSurname.Text;
                txtFullName.Text = FullName;
                txtFullName.ReadOnly = true;

                Selection = MessageBox.Show("Are the above details correct?", "Confirmation", MessageBoxButtons.YesNo);

                if (!(Selection == DialogResult.No))
                {
                    MessageBox.Show("The selection & the details above are correct", "Confirmation");
                }
                else
                {
                    txtUsername.Text = "";
                    TxtSurname.Text = "";
                    txtFullName.Text = "";
                    txtEMAIL.Text = "";
                   // masktxtCellNo.Clear();
                    txtUsername.Enabled = true;
                    TxtSurname.Enabled = true;

                }


            }
        }

        private void radioBtn7_CheckedChanged(object sender, EventArgs e)
        {
            if (!(radioBtn7.Checked == false))
            {

                txtUsername.Enabled = false;
                TxtSurname.Enabled = false;
                MessageBox.Show("You've made the selection, the string values above cannot be changed",
                               "Confirmation");
                FullName = txtUsername.Text + "  " + TxtSurname.Text;
                txtFullName.Text = FullName;
                txtFullName.ReadOnly = true;

                Selection = MessageBox.Show("Are the above details correct?", "Confirmation", MessageBoxButtons.YesNo);

                if (!(Selection == DialogResult.No))
                {
                    MessageBox.Show("The selection & the details above are correct", "Confirmation");
                }
                else
                {
                    txtUsername.Text = "";
                    TxtSurname.Text = "";
                    txtFullName.Text = "";
                    txtEMAIL.Text = "";
                    //masktxtCellNo.Clear();
                    txtUsername.Enabled = true;
                    TxtSurname.Enabled = true;

                }

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = ShowPass.Checked;
            txtRepassword.UseSystemPasswordChar = ShowPass.Checked;
        }

        private void TxtCellphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.netlawman.co.za/d/website-terms-hotel");
        }

        private void TermsandC_CheckedChanged(object sender, EventArgs e)
        {
            if (TermsandC.Checked == true)
            {
                MessageBox.Show("You've successful accepted terms and conditions", "Confirmation");
                //button1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please accept terms and conditions", "Confirmation");
                //button1.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                MessageBox.Show("The sms is already sent to your cellphone number" +" "+
                               "and also the email is sent out" ,"Confirmation");
                //masktxtCellNo.Enabled = false;
                maskedTextBox1.Enabled = false;
                txtEMAIL.Enabled = false;

            }
            else
            {

                MessageBox.Show("Please make the selection to receive promotions", "Confirmation");
                //masktxtCellNo.Enabled = true;
                maskedTextBox1.Enabled = true;
                txtEMAIL.Enabled = false;
            }
        }
    }
}
