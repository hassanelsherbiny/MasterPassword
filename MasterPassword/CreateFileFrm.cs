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
    public partial class CreateFileFrm : Form
    {

        string path;

        public string Password { get; set; }
        public CreateFileFrm(string path)
        {
            InitializeComponent();

            this.path = path;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        void Save()
        {

            if (string.IsNullOrEmpty(PasswordTxt.Text))
            {
                MessageBox.Show("Please Enter Password.");
            }
            else
            {
                if (PasswordTxt.Text == ConfirmTxt.Text)
                {
                    PasswordsFile file = new PasswordsFile();
                    file.MasterPassword = PasswordTxt.Text;
                    file.Save(path);
                    this.DialogResult = DialogResult.OK;
                    Password = PasswordTxt.Text;
                    Close();
                }
                else
                    MessageBox.Show("Password And Confirm Doesn't Match");
            }
        }

        private void CreateFileFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save();
        }
    }
}
