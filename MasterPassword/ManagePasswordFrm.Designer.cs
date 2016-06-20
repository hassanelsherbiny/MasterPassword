namespace MasterPassword
{
    partial class ManagePasswordFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePasswordFrm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordsGrd = new System.Windows.Forms.DataGridView();
            this.Password_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link_col = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.ChangepasswordBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordsGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ExportBtn);
            this.splitContainer1.Panel2.Controls.Add(this.ImportBtn);
            this.splitContainer1.Panel2.Controls.Add(this.ChangepasswordBtn);
            this.splitContainer1.Panel2.Controls.Add(this.DeleteBtn);
            this.splitContainer1.Panel2.Controls.Add(this.EditBtn);
            this.splitContainer1.Panel2.Controls.Add(this.AddBtn);
            this.splitContainer1.Size = new System.Drawing.Size(850, 501);
            this.splitContainer1.SplitterDistance = 442;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Searchbtn);
            this.splitContainer2.Panel1.Controls.Add(this.Searchtxt);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.PasswordsGrd);
            this.splitContainer2.Size = new System.Drawing.Size(850, 442);
            this.splitContainer2.SplitterDistance = 27;
            this.splitContainer2.TabIndex = 1;
            // 
            // Searchbtn
            // 
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Searchbtn.Image = global::MasterPassword.Properties.Resources.Search_icon;
            this.Searchbtn.Location = new System.Drawing.Point(402, 0);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(43, 27);
            this.Searchbtn.TabIndex = 13;
            this.toolTip1.SetToolTip(this.Searchbtn, "Search By Password ,UserName ,Details Or Link");
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.Searchtxt.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchtxt.Location = new System.Drawing.Point(83, 0);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(319, 36);
            this.Searchtxt.TabIndex = 2;
            this.Searchtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Searchtxt_KeyDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordsGrd
            // 
            this.PasswordsGrd.AllowUserToAddRows = false;
            this.PasswordsGrd.AllowUserToDeleteRows = false;
            this.PasswordsGrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PasswordsGrd.BackgroundColor = System.Drawing.Color.White;
            this.PasswordsGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasswordsGrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Password_col,
            this.UserName_col,
            this.Details_col,
            this.Link_col,
            this.Id_col});
            this.PasswordsGrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordsGrd.Location = new System.Drawing.Point(0, 0);
            this.PasswordsGrd.Name = "PasswordsGrd";
            this.PasswordsGrd.ReadOnly = true;
            this.PasswordsGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PasswordsGrd.Size = new System.Drawing.Size(850, 411);
            this.PasswordsGrd.TabIndex = 0;
            this.PasswordsGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PasswordsGrd_CellContentClick);
            // 
            // Password_col
            // 
            this.Password_col.HeaderText = "Password";
            this.Password_col.Name = "Password_col";
            this.Password_col.ReadOnly = true;
            // 
            // UserName_col
            // 
            this.UserName_col.HeaderText = "User Name";
            this.UserName_col.Name = "UserName_col";
            this.UserName_col.ReadOnly = true;
            // 
            // Details_col
            // 
            this.Details_col.HeaderText = "Details";
            this.Details_col.Name = "Details_col";
            this.Details_col.ReadOnly = true;
            // 
            // Link_col
            // 
            this.Link_col.HeaderText = "Link";
            this.Link_col.Name = "Link_col";
            this.Link_col.ReadOnly = true;
            // 
            // Id_col
            // 
            this.Id_col.HeaderText = "Id";
            this.Id_col.Name = "Id_col";
            this.Id_col.ReadOnly = true;
            this.Id_col.Visible = false;
            // 
            // ExportBtn
            // 
            this.ExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExportBtn.Image = global::MasterPassword.Properties.Resources.export;
            this.ExportBtn.Location = new System.Drawing.Point(265, 0);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(53, 55);
            this.ExportBtn.TabIndex = 18;
            this.toolTip1.SetToolTip(this.ExportBtn, "Export");
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // ImportBtn
            // 
            this.ImportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImportBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ImportBtn.Image = global::MasterPassword.Properties.Resources.Import;
            this.ImportBtn.Location = new System.Drawing.Point(212, 0);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(53, 55);
            this.ImportBtn.TabIndex = 17;
            this.toolTip1.SetToolTip(this.ImportBtn, "Import");
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // ChangepasswordBtn
            // 
            this.ChangepasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangepasswordBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChangepasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangepasswordBtn.Image = global::MasterPassword.Properties.Resources.Change_Password;
            this.ChangepasswordBtn.Location = new System.Drawing.Point(159, 0);
            this.ChangepasswordBtn.Name = "ChangepasswordBtn";
            this.ChangepasswordBtn.Size = new System.Drawing.Size(53, 55);
            this.ChangepasswordBtn.TabIndex = 15;
            this.toolTip1.SetToolTip(this.ChangepasswordBtn, "Change Master Password");
            this.ChangepasswordBtn.UseVisualStyleBackColor = true;
            this.ChangepasswordBtn.Click += new System.EventHandler(this.ChangepasswordBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteBtn.Image = global::MasterPassword.Properties.Resources.delete;
            this.DeleteBtn.Location = new System.Drawing.Point(106, 0);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(53, 55);
            this.DeleteBtn.TabIndex = 12;
            this.toolTip1.SetToolTip(this.DeleteBtn, "Delete");
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditBtn.Image = global::MasterPassword.Properties.Resources.edit;
            this.EditBtn.Location = new System.Drawing.Point(53, 0);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(53, 55);
            this.EditBtn.TabIndex = 11;
            this.toolTip1.SetToolTip(this.EditBtn, "Edit");
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Image = global::MasterPassword.Properties.Resources.add;
            this.AddBtn.Location = new System.Drawing.Point(0, 0);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(53, 55);
            this.AddBtn.TabIndex = 10;
            this.toolTip1.SetToolTip(this.AddBtn, "Add");
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ManagePasswordFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 501);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagePasswordFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Passwords";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagePasswordFrm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordsGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView PasswordsGrd;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details_col;
        private System.Windows.Forms.DataGridViewLinkColumn Link_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_col;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.Button ChangepasswordBtn;
    }
}