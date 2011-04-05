/* Project 2 CIS 476 Design Patterns
 * By Scott Smereka
 * Problem 2
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class MainForm : Form
    {
        Boolean evaluated = false;
        USDHandler USD = new USDHandler();
        CADHandler CAD = new CADHandler();
        AUDHandler AUD = new AUDHandler();
        ErrorHandler ERH = new ErrorHandler();
        RoundDecorator Round = new RoundDecorator();
        ExpNotationDecorator ExpNote = new ExpNotationDecorator();
        CurrencyNameDecorator CurrName = new CurrencyNameDecorator();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            //Setup handler successor chain (Order is not important, but error handler must be last)
            USD.Successor = CAD;  
            CAD.Successor = AUD;
            AUD.Successor = ERH;  //Handle invalid input with error handler as last in chain

            //Setup decorator chain (in specific order)
            Round.Handler = USD;          //Go through handler chain, then Round to two decimals
            ExpNote.Handler = Round;      //Then Convert to exp notation
            CurrName.Handler = ExpNote;   //Finally Add the currency name to the end

            try
            {
                OutputTxt.Text = "$" + CurrName.Process(inputTxt.Text);  //Try to process data
            }
            catch
            {
                MessageBox.Show("Error: The entered conversion is not valid");  //Show error
            }
            finally
            {
                evaluated = true;             //Mark the data as being evaluated 
                ConvertBtn.Enabled = false;   //Diable ability to run convert on old data
            }
        }

        private void inputTxt_KeyUp(object sender, KeyEventArgs e)  
        {//Pre:  none
         //Post: Enable or diable convert process, Run input if enter is pressed (and if ok to run it)
            if (!e.KeyCode.Equals(Keys.Enter))  //If new input to process
                evaluated = false;              //Mark data as new data to evaluate
            if ((inputTxt.Text != "") && (!evaluated))  //If not blank, and not a previously processed
                ConvertBtn.Enabled = true;              //Enable the button
            else
                ConvertBtn.Enabled = false;             //Diable button if blank or already processed
            if (e.KeyCode.Equals(Keys.Enter) && ConvertBtn.Enabled == true)  //If entering an input, and currently allowed to
                ConvertBtn_Click(sender, e);                                 //Run convert
        }
    }
}
