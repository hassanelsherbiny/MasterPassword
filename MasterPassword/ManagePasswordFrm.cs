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
    public partial class ManagePasswordFrm : Form
    {
        string path = "";
        PasswordsFile file = new PasswordsFile();
        public ManagePasswordFrm(string path)
        {
            InitializeComponent();
            LoadFile(path, true);
            this.path = path;
        }

        void LoadFile(string path, bool OpenWithValidation)
        {
            PasswordsGrd.Rows.Clear();
            try
            {
                file = PasswordsFile.Load(path);
                bool passwordIsOk = false;
                MasterPasswordInput_frm frm = new MasterPasswordInput_frm(file.MasterPassword);

                if (OpenWithValidation)
                    passwordIsOk = frm.ShowDialog() == DialogResult.OK;


                if ((OpenWithValidation && passwordIsOk) || OpenWithValidation == false)
                {
                    DisplayPasswords(file.Passwords);
                }
                else
                    Close();
            }
            catch
            {
                var result = MessageBox.Show("Faild To Open Passwords File.Do You Want To ReCreate It?", "Open Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    CreateFileFrm frm2 = new CreateFileFrm(path);
                    frm2.ShowDialog();
                }
            }

        }

        void DisplayPasswords(IEnumerable<Password> passwords)
        {
            PasswordsGrd.Rows.Clear();
            if (file.Passwords != null)
            {
                foreach (var password in passwords)
                {
                    PasswordsGrd.Rows.Add(password.password, password.UserName, password.Details, password.LNK, password.ID);
                }
            }
        }
        private void ManagePasswordFrm_Load(object sender, EventArgs e)
        {

        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Passwords File|*.mps";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadFile(ofd.FileName, true);
            }
        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Passwords File|*.mps";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (PasswordsGrd.SelectedRows.Count > 0)
                {
                    //Create New File To Export To
                    PasswordsFile newfile = new PasswordsFile();
                    newfile.Passwords = new List<Password>();
                    foreach (DataGridViewRow row in PasswordsGrd.SelectedRows)
                    {

                        Password password = new Password()
                        {
                            password = row.Cells["Password_col"].Value.ToString(),
                            UserName = row.Cells["UserName_col"].Value.ToString(),
                            LNK = row.Cells["Link_col"].Value.ToString(),
                            Details = row.Cells["details_col"].Value.ToString(),

                        };
                        newfile.Passwords.Add(password);
                    }
                    //Save With The Same MasterPassword Or Create New
                    var result = MessageBox.Show("Do You Want To Set Master Password?", "new MasterPassword", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        CreateFileFrm frm = new CreateFileFrm(sfd.FileName);
                        if (frm.ShowDialog() == DialogResult.OK)
                            newfile.MasterPassword = frm.Password;
                        else
                        {
                            MessageBox.Show("You Have Canceld new Password Creation.File Will Be saved With Current Master Password.");
                            newfile.MasterPassword = file.MasterPassword;
                        }
                    }
                    else
                        newfile.MasterPassword = file.MasterPassword;
                    newfile.Save(sfd.FileName);
                }
                else
                    file.Save(sfd.FileName);

                MessageBox.Show("passwords Was Successfully Exported");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Password_AE frm = new Password_AE("", path);
            frm.ShowDialog();
            LoadFile(path, false);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PasswordsGrd.SelectedRows.Count == 1)
            {
                int id = (int)PasswordsGrd.SelectedRows[0].Cells["ID_col"].Value;
                Password_AE frm = new Password_AE(id, path);
                frm.ShowDialog();
                LoadFile(path, false);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (PasswordsGrd.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are You Sure you Want To Delete Selected Passwords?", "Delete passwords", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in PasswordsGrd.SelectedRows)
                    {
                        int id = (int)row.Cells["ID_col"].Value;
                        file.Passwords.Remove(file.Passwords.FirstOrDefault(x => x.ID == id));
                    }
                    file.Save(path);
                    LoadFile(path, false);
                }
            }
        }

        private void PasswordsGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                try
                {
                    string lnk = PasswordsGrd.Rows[e.RowIndex].Cells[3].Value.ToString();
                    System.Diagnostics.Process.Start(lnk);
                }
                catch { }
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Searchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }
        void Search()
        {
            if (!string.IsNullOrEmpty(Searchtxt.Text))
            {
                string txt = Searchtxt.Text.ToLower();
                var passwords = file.Passwords.Where(x => x.password.ToLower().Contains(txt) ||
                    x.UserName.ToLower().Contains(txt) || x.Details.ToLower().Contains(txt)
                    || x.LNK.ToLower().Contains(txt));
                DisplayPasswords(passwords);
            }
        }
        private void ChangepasswordBtn_Click(object sender, EventArgs e)
        {
            ChangeMasterPassword_frm frm = new ChangeMasterPassword_frm(path);
            try
            {
                frm.ShowDialog();
                LoadFile(path, true);
            }
            catch { }
        }


    }
}
