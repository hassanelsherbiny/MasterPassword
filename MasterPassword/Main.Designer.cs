namespace MasterPassword
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordMaxLength = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordMinLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CapitalDisplay = new MasterPassword.ItemDisplayer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SmallDisplay = new MasterPassword.ItemDisplayer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.NumberDisplay = new MasterPassword.ItemDisplayer();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AllowedSymbols = new System.Windows.Forms.TextBox();
            this.SymbolDisplay = new MasterPassword.ItemDisplayer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.passwordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.GeneratePasswordBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMaxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMinLength)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PasswordMaxLength);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PasswordMinLength);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 78);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max Length";
            // 
            // PasswordMaxLength
            // 
            this.PasswordMaxLength.Location = new System.Drawing.Point(3, 57);
            this.PasswordMaxLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PasswordMaxLength.Name = "PasswordMaxLength";
            this.PasswordMaxLength.Size = new System.Drawing.Size(108, 20);
            this.PasswordMaxLength.TabIndex = 8;
            this.PasswordMaxLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PasswordMaxLength.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Min Length";
            // 
            // PasswordMinLength
            // 
            this.PasswordMinLength.Location = new System.Drawing.Point(3, 18);
            this.PasswordMinLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PasswordMinLength.Name = "PasswordMinLength";
            this.PasswordMinLength.Size = new System.Drawing.Size(108, 20);
            this.PasswordMinLength.TabIndex = 6;
            this.PasswordMinLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PasswordMinLength.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CapitalDisplay);
            this.groupBox2.Location = new System.Drawing.Point(183, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capital letters";
            // 
            // CapitalDisplay
            // 
            this.CapitalDisplay.IsSelected = true;
            this.CapitalDisplay.Location = new System.Drawing.Point(12, 19);
            this.CapitalDisplay.MaxLength = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CapitalDisplay.MinLength = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CapitalDisplay.Name = "CapitalDisplay";
            this.CapitalDisplay.Size = new System.Drawing.Size(134, 80);
            this.CapitalDisplay.TabIndex = 1;
            this.CapitalDisplay.Type = MasterPassword.CharachterTypes.Upper;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SmallDisplay);
            this.groupBox3.Location = new System.Drawing.Point(358, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(154, 104);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Small Letters";
            // 
            // SmallDisplay
            // 
            this.SmallDisplay.IsSelected = false;
            this.SmallDisplay.Location = new System.Drawing.Point(12, 19);
            this.SmallDisplay.MaxLength = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SmallDisplay.MinLength = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SmallDisplay.Name = "SmallDisplay";
            this.SmallDisplay.Size = new System.Drawing.Size(134, 80);
            this.SmallDisplay.TabIndex = 1;
            this.SmallDisplay.Type = MasterPassword.CharachterTypes.Lower;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NumberDisplay);
            this.groupBox4.Location = new System.Drawing.Point(12, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 149);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Numbers";
            // 
            // NumberDisplay
            // 
            this.NumberDisplay.IsSelected = true;
            this.NumberDisplay.Location = new System.Drawing.Point(12, 19);
            this.NumberDisplay.MaxLength = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumberDisplay.MinLength = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumberDisplay.Name = "NumberDisplay";
            this.NumberDisplay.Size = new System.Drawing.Size(134, 80);
            this.NumberDisplay.TabIndex = 1;
            this.NumberDisplay.Type = MasterPassword.CharachterTypes.Numbers;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BackColor = System.Drawing.Color.White;
            this.Passwordtxt.Location = new System.Drawing.Point(12, 368);
            this.Passwordtxt.Multiline = true;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.ReadOnly = true;
            this.Passwordtxt.Size = new System.Drawing.Size(500, 60);
            this.Passwordtxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generated Password:";
            // 
            // welcomelbl
            // 
            this.welcomelbl.Location = new System.Drawing.Point(15, 9);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(497, 20);
            this.welcomelbl.TabIndex = 6;
            this.welcomelbl.Text = "Welcome To free open Source Password generator Created By : Hassan Elsherbiny ";
            this.welcomelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.AllowedSymbols);
            this.groupBox5.Controls.Add(this.SymbolDisplay);
            this.groupBox5.Location = new System.Drawing.Point(183, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(154, 149);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Symobols";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Allowed Symbols:";
            // 
            // AllowedSymbols
            // 
            this.AllowedSymbols.Location = new System.Drawing.Point(12, 123);
            this.AllowedSymbols.Name = "AllowedSymbols";
            this.AllowedSymbols.Size = new System.Drawing.Size(111, 20);
            this.AllowedSymbols.TabIndex = 9;
            this.AllowedSymbols.Text = "@#$%^&*!~-_+><";
            // 
            // SymbolDisplay
            // 
            this.SymbolDisplay.IsSelected = false;
            this.SymbolDisplay.Location = new System.Drawing.Point(12, 19);
            this.SymbolDisplay.MaxLength = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SymbolDisplay.MinLength = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SymbolDisplay.Name = "SymbolDisplay";
            this.SymbolDisplay.Size = new System.Drawing.Size(134, 124);
            this.SymbolDisplay.TabIndex = 1;
            this.SymbolDisplay.Type = MasterPassword.CharachterTypes.Symobols;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(553, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 180, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(133, 434);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // passwordsToolStripMenuItem
            // 
            this.passwordsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordsToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordsToolStripMenuItem.Image = global::MasterPassword.Properties.Resources.splashid_icon;
            this.passwordsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.passwordsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.passwordsToolStripMenuItem.Name = "passwordsToolStripMenuItem";
            this.passwordsToolStripMenuItem.Size = new System.Drawing.Size(120, 36);
            this.passwordsToolStripMenuItem.Text = "Passwords";
            this.passwordsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.passwordsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.passwordsToolStripMenuItem.Click += new System.EventHandler(this.passwordsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = global::MasterPassword.Properties.Resources.exit;
            this.exitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveBtn.Image = global::MasterPassword.Properties.Resources.Save;
            this.SaveBtn.Location = new System.Drawing.Point(172, 324);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(40, 40);
            this.SaveBtn.TabIndex = 8;
            this.tooltip.SetToolTip(this.SaveBtn, "Save");
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CopyBtn
            // 
            this.CopyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CopyBtn.Image = global::MasterPassword.Properties.Resources.copy;
            this.CopyBtn.Location = new System.Drawing.Point(126, 324);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(40, 40);
            this.CopyBtn.TabIndex = 5;
            this.tooltip.SetToolTip(this.CopyBtn, "Copy");
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // GeneratePasswordBtn
            // 
            this.GeneratePasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneratePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeneratePasswordBtn.Image = global::MasterPassword.Properties.Resources.passicon;
            this.GeneratePasswordBtn.Location = new System.Drawing.Point(358, 174);
            this.GeneratePasswordBtn.Name = "GeneratePasswordBtn";
            this.GeneratePasswordBtn.Size = new System.Drawing.Size(154, 144);
            this.GeneratePasswordBtn.TabIndex = 3;
            this.GeneratePasswordBtn.Text = "Generate Password";
            this.GeneratePasswordBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GeneratePasswordBtn.UseVisualStyleBackColor = true;
            this.GeneratePasswordBtn.Click += new System.EventHandler(this.GeneratePasswordBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 434);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.welcomelbl);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.GeneratePasswordBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMaxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordMinLength)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ItemDisplayer CapitalDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private ItemDisplayer SmallDisplay;
        private System.Windows.Forms.GroupBox groupBox4;
        private ItemDisplayer NumberDisplay;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Button GeneratePasswordBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.GroupBox groupBox5;
        private ItemDisplayer SymbolDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem passwordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PasswordMaxLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown PasswordMinLength;
        private System.Windows.Forms.TextBox AllowedSymbols;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;

    }
}

