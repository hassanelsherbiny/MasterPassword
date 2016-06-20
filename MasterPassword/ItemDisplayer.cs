using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasterPassword
{
    public partial class ItemDisplayer : UserControl
    {
        public ItemDisplayer()
        {
            InitializeComponent();
        }
        #region Properties
       
        public decimal MaxLength
        {
            get
            {
                return MaxUpDown.Value;
            }
            set
            {
                MaxUpDown.Value = value < MaxUpDown.Minimum ? MaxUpDown.Minimum : value;
            }
        }
      
        public decimal MinLength
        {
            get
            {
                return MinUpDown.Value;
            }
            set
            {
                MinUpDown.Value = value < MinUpDown.Minimum ? MinUpDown.Minimum : value;
            }
        }

        public CharachterTypes Type { get; set; }

        public bool IsSelected
        {
            get { return Checker.Checked; }
            set { Checker.Checked = value; }
        }
        #endregion
        private void Checker_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = Checker.Checked;
        }

        private void UpDown_ValueChanged(object sender, EventArgs e)
        {
            if (MinLength > MaxLength)
                MaxLength = MinLength;
        }
    }
}
