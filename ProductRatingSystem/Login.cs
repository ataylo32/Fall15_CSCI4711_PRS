using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProductRatingSystem
{
    public partial class Login_Dialog_Form1 : Form
    {
        public Login_Dialog_Form1()
        {
            InitializeComponent();
        }
        private bool ValidateUsername()
        {
            //TODO: add code to validate User Name here.
            return true;
        }
        private bool ValidatePassword()
        {
            if (!ValidateUsername())
            {
                MessageBox.Show("Wrong Username", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            else
            {
                //TODO: add code to validate password.
                return true;
            }
            
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidatePassword())
            {
                txtUserName.Clear();
                txtPassword.Clear();
                MessageBox.Show("The calculations are complete", "My Application",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("You are logged on!", "Product Rating System",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            this.Close();
        }
    }
}
