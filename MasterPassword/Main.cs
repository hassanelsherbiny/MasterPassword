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
    public partial class Main : Form
    {
        string defaultFilePath = "MPF.mps";
        public Main()
        {
            InitializeComponent();

        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Passwordtxt.Text))
            {
                Clipboard.SetText(Passwordtxt.Text);
            }
            else
                MessageBox.Show("Please generate Password First.", "Copy Failed");
        }

        private void GeneratePasswordBtn_Click(object sender, EventArgs e)
        {


            //Check If Password Component min Length Fits Password Max Length
            if (LengthValidate())
            {
                //Create Array To Hold Password Charachters
                char[] GeneratedPassword = new char[(int)PasswordMaxLength.Value + 1];

                //Start Generating For Minimum Requirments
                for (int x = 1; x <= SmallDisplay.MinLength; x++)
                    GenerateSmallLetters(GeneratedPassword);

                for (int x = 1; x <= CapitalDisplay.MinLength; x++)
                    GenerateCapitalLetters(GeneratedPassword);
                for (int x = 1; x <= NumberDisplay.MinLength; x++)
                    GenerateNumbers(GeneratedPassword);
                for (int x = 1; x <= SymbolDisplay.MinLength; x++)
                    GenerateSymbols(GeneratedPassword);

                string pass = GetString(GeneratedPassword);

                //Check If Password Has Min length
                decimal stop = 0;

                stop = CapitalDisplay.MaxLength - CapitalDisplay.MinLength;
                for (int i = 1; i <= stop; i++)
                {
                    if (pass.Length < PasswordMinLength.Value)
                    {
                        GenerateCapitalLetters(GeneratedPassword);
                        pass = GetString(GeneratedPassword);
                    }
                }
                stop = SmallDisplay.MaxLength - SmallDisplay.MinLength;
                for (int i = 1; i <= stop; i++)
                {
                    if (pass.Length < PasswordMinLength.Value)
                    {
                        GenerateSmallLetters(GeneratedPassword);
                        pass = GetString(GeneratedPassword);
                    }
                }
                stop = SymbolDisplay.MaxLength - SymbolDisplay.MinLength;
                for (int i = 1; i <= stop; i++)
                {
                    if (pass.Length < PasswordMinLength.Value)
                    {
                        GenerateSymbols(GeneratedPassword);
                        pass = GetString(GeneratedPassword);
                    }
                }
                stop = NumberDisplay.MaxLength - NumberDisplay.MinLength;
                for (int i = 1; i <= stop; i++)
                {
                    if (pass.Length < PasswordMinLength.Value)
                    {
                        GenerateNumbers(GeneratedPassword);
                        pass = GetString(GeneratedPassword);
                    }
                }


                Passwordtxt.Text = pass;
            }
            else
            {
                MessageBox.Show("Password Max and min length Doesn't Fit The Total Min and Max Length Of Password Component,Please Correct This Proplem First");
            }
        }
        private void UpDown_ValueChanged(object sender, EventArgs e)
        {

            if (PasswordMinLength.Value > PasswordMaxLength.Value)
                PasswordMaxLength.Value = PasswordMinLength.Value;
        }

        bool LengthValidate()
        {
            decimal totalminlength = 0;
            totalminlength += SmallDisplay.IsSelected ? SmallDisplay.MinLength : 0;
            totalminlength += CapitalDisplay.IsSelected ? CapitalDisplay.MinLength : 0;
            totalminlength += SymbolDisplay.IsSelected ? SymbolDisplay.MinLength : 0;
            totalminlength += NumberDisplay.IsSelected ? NumberDisplay.MinLength : 0;

            decimal totalmaxlength = 0;
            totalmaxlength += SmallDisplay.IsSelected ? SmallDisplay.MaxLength : 0;
            totalmaxlength += CapitalDisplay.IsSelected ? CapitalDisplay.MaxLength : 0;
            totalmaxlength += SymbolDisplay.IsSelected ? SymbolDisplay.MaxLength : 0;
            totalmaxlength += NumberDisplay.IsSelected ? NumberDisplay.MaxLength : 0;


            return PasswordMinLength.Value >= totalminlength && PasswordMinLength.Value <= totalmaxlength;
        }

        Random rnd = new Random();

        /// <summary>
        /// Get Empty Random Index
        /// </summary>
        /// <param name="array">Input Array</param>
        /// <returns></returns>
        int GetRandomIndex(char[] array)
        {
            int index = 0;
            do
            {
                index = rnd.Next(0, array.Count() - 1);
            }
            while (array[index] != '\0');
            return index;
        }

        #region Generating Functions
        void GenerateSmallLetters(char[] array)
        {
            if (SmallDisplay.IsSelected)
            {
                int i = GetRandomIndex(array);
                array[i] = (char)rnd.Next(97, 122);
            }
        }
        void GenerateCapitalLetters(char[] array)
        {
            if (CapitalDisplay.IsSelected)
            {
                int i = GetRandomIndex(array);
                array[i] = (char)rnd.Next(65, 90);
            }
        }
        void GenerateNumbers(char[] array)
        {
            if (NumberDisplay.IsSelected)
            {
                int i = GetRandomIndex(array);
                array[i] = rnd.Next(0, 9).ToString()[0];
            }
        }
        void GenerateSymbols(char[] array)
        {
            if (SymbolDisplay.IsSelected)
            {
                int i = GetRandomIndex(array);
                array[i] = AllowedSymbols.Text[rnd.Next(0, AllowedSymbols.Text.Length - 1)];
            }
        }

        #endregion

        /// <summary>
        /// Getting String from array Without Empty Charachters
        /// </summary>
        /// <param name="array">Input Array</param>
        /// <returns></returns>
        string GetString(char[] array)
        {
            StringBuilder bs = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != '\0')
                    bs.Append(array[i]);
            }
            return bs.ToString();
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Passwordtxt.Text))
            {
                try
                {
                    Password_AE frm = new Password_AE(Passwordtxt.Text, defaultFilePath);
                    frm.ShowDialog();
                }
                catch
                {
                    //Catch Exception Of Accessing Disposed Object
                    //Do Nothing If Save Canceld
                }
            }
            else
                MessageBox.Show("Please Generate password First.");
        }

        private void passwordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePasswordFrm frm = new ManagePasswordFrm(defaultFilePath);
            try { frm.ShowDialog(); }
            catch { }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            welcomelbl.Text = welcomelbl.Text.Substring(1) + welcomelbl.Text.Substring(0, 1);
        }

    }
}
