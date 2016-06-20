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
    public partial class MasterPasswordInput_frm : Form
    {
        string password;
        public MasterPasswordInput_frm(string password)
        {
            InitializeComponent();
            this.password = password;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Checkpassword();
        }
        void Checkpassword()
        {
            if (password == PasswordTxt.Text)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Password Is InCorrect..", "Wrong Password");
        }
        private void MasterPasswordInput_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Checkpassword();
        }
    }
}
