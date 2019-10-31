using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Bsic_Calculaor
{
    /// <summary>
    /// Basic Calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        #region Operator Methods
        /// <summary>
        /// Insert the divade character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">the event argument</param>
        private void DivadeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// insert the times character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the additions character
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="e">the event arguments</param>
        private void AdditionButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            // Focus the user input text
            FocusInputText();
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// insert the minus character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Calculate the given equation in the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void EqualButton_Click(object sender, EventArgs e)
        {
            //Calculate de equation
            ClaculateEcuation();

            // Focus the user input text
            FocusInputText();
        }



        #endregion

        #region Clearing Methods
        /// <summary>
        /// Clear the user imput text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clear the text from user imput text box
            this.UserInputText.Text = string.Empty;

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Delete the character to the right of selection
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Delete the value to the right of selection position
            DeletetTextValue();

            //Focus the user imput text
            FocusInputText();
        }
        #endregion
        
        #region Numbers Methods
        /// <summary>
        /// Insert the 7 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">the event argument</param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 8 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 9 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 4 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">the event argument</param>
        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 5 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">the event argument</param>
        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 6 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 1 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">the event argument</param>
        private void OaneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 2 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 3 character
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            // Focus the user input text
            FocusInputText();
        }
        /// <summary>
        /// Insert the 0 character
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="e">the event argument</param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            // Focus the user input text
            FocusInputText();
        }




        #endregion

        #region Private Helpers
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }
        /// <summary>
        /// Delete the character to the rightof the selection start of the user input text box
        /// </summary>
        private void DeletetTextValue()
        {
            //If we dont have a value to delete, return
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //Delete the character to the rightof the selection

            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
      

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart;

            //Set selection length to 0
            this.UserInputText.SelectionLength = 0;
        }
        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            //Set new text 
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            //Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            //Set selection length to zero
            this.UserInputText.SelectionLength = 0;
        }
        #endregion

        /// <summary>
        /// Calculate the given ecuation and outputs the answer to user label
        /// </summary>
        private void ClaculateEcuation()
        {
            throw new NotImplementedException();
        }

    }
}
