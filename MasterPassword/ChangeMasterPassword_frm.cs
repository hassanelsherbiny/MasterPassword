using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterPassword
{
    public partial class ChangeMasterPassword_frm : Form
    {

        string path = "";
        public ChangeMasterPassword_frm(string path)
        {
            InitializeComponent();

            this.path = path;
        }

        private void ChangeMasterPassword_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save();
        }
        void Save()
        {
            if (!string.IsNullOrEmpty(NewPassTxt.Text))
            {
                PasswordsFile file = PasswordsFile.Load(path);
                if (PasswordTxt.Text == file.MasterPassword)
                {
                    if (NewPassTxt.Text == ConfirmTxt.Text)
                    {
                        file.MasterPassword = NewPassTxt.Text;
                        file.Save(path);
                        Close();
                    }
                    else
                        MessageBox.Show("Password Confirm Doesn't Match.");
                }
                else
                    MessageBox.Show("Old Password Is Incorrect.");
            }
            else
                MessageBox.Show("Enter the New Password.");
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
