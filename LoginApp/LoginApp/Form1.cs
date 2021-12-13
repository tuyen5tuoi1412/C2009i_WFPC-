using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            // set to no text
           /* PasswordBox.Text = "";*/
            // the password character is an asterisk
            PasswordBox.PasswordChar = '*';
            // the control will allow no more than 14 characters
            PasswordBox.MaxLength = 14;
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void EmailBox_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            
            if (string.IsNullOrWhiteSpace(EmailBox.Text))
            {
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;
                errorProviderApp.SetError(EmailBox, "");
            }
            if (Regex.IsMatch(EmailBox.Text, pattern))
            {
                errorProviderApp.Clear();
            }
            else
            {
                EmailBox.Focus();
                MessageBox.Show("Please enter the correct email form", "Alert Login");
                errorProviderApp.SetError(this.EmailBox, "Email is not correct fomat");
            }
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
           
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show($"Email:{EmailBox} and {PasswordBox}", "Message Login!");
            }
           
        }
    }
}
