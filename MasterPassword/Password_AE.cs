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
    public partial class Password_AE : Form
    {
        int id = 0;
        string path = "";
        public Password_AE(string password, string path)
        {
            InitializeComponent();
            this.path = path;
            Passwordtxt.Text = password;
            if (!System.IO.File.Exists(path))
            {
                CreateFileFrm frm = new CreateFileFrm(path);
                DialogResult result = frm.ShowDialog();
                if (result != DialogResult.OK)
                {
                    MessageBox.Show("File Creation Was Canceld.");
                    this.Close();
                }
            }
        }
        public Password_AE(int id, string path)
        {
            InitializeComponent();
            this.id = id;
            this.path = path;
            //Retrive Password Details
            PasswordsFile passwordfile = PasswordsFile.Load(path);
            var password = passwordfile.Passwords.FirstOrDefault(x => x.ID == id);
            Passwordtxt.Text = password.password;
            UserNameTxt.Text = password.UserName;
            Linktxt.Text = password.LNK;
            DetailsTxt.Text = password.Details;


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }
        void Save()
        {
            PasswordsFile passwordfile = PasswordsFile.Load(path);
            if (!string.IsNullOrEmpty(Passwordtxt.Text))
            {
                Password password = new Password();
                if (id != 0)
                {

                    password = passwordfile.Passwords.FirstOrDefault(x => x.ID == id);
                }
                else
                {
                    int maxid = 0;
                    if (passwordfile.Passwords == null)
                    {
                        passwordfile.Passwords = new List<Password>();

                    }
                    else if (passwordfile.Passwords.Count > 0)
                        maxid = passwordfile.Passwords.Max(x => x.ID);
                    password.ID = maxid + 1;

                    passwordfile.Passwords.Add(password);
                }
                password.password = Passwordtxt.Text;
                password.UserName = UserNameTxt.Text;
                password.LNK = Linktxt.Text;
                password.Details = DetailsTxt.Text;

                passwordfile.Save(path);
                Close();
            }
            else
                MessageBox.Show("Please Enter Password.");
        }

        private void Password_AE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Save();
        }
    }
}
