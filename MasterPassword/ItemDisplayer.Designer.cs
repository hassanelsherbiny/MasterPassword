namespace MasterPassword
{
    partial class ItemDisplayer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MinUpDown = new System.Windows.Forms.NumericUpDown();
            this.Checker = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MaxUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MinUpDown);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 78);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Max Length";
            // 
            // MaxUpDown
            // 
            this.MaxUpDown.Location = new System.Drawing.Point(3, 57);
            this.MaxUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxUpDown.Name = "MaxUpDown";
            this.MaxUpDown.Size = new System.Drawing.Size(108, 20);
            this.MaxUpDown.TabIndex = 8;
            this.MaxUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxUpDown.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Min Length";
            // 
            // MinUpDown
            // 
            this.MinUpDown.Location = new System.Drawing.Point(3, 18);
            this.MinUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinUpDown.Name = "MinUpDown";
            this.MinUpDown.Size = new System.Drawing.Size(108, 20);
            this.MinUpDown.TabIndex = 6;
            this.MinUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinUpDown.ValueChanged += new System.EventHandler(this.UpDown_ValueChanged);
            // 
            // Checker
            // 
            this.Checker.AutoSize = true;
            this.Checker.Location = new System.Drawing.Point(116, 0);
            this.Checker.Name = "Checker";
            this.Checker.Size = new System.Drawing.Size(15, 14);
            this.Checker.TabIndex = 5;
            this.Checker.UseVisualStyleBackColor = true;
            this.Checker.CheckedChanged += new System.EventHandler(this.Checker_CheckedChanged);
            // 
            // ItemDisplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Checker);
            this.Name = "ItemDisplayer";
            this.Size = new System.Drawing.Size(134, 80);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MinUpDown;
        private System.Windows.Forms.CheckBox Checker;

    }
}
