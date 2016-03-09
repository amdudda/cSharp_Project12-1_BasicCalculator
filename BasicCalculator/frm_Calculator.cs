using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class frm_Calculator : Form
    {
        // initialize a variable to store the calculator
        Calculator myCalculator = new Calculator();

        public frm_Calculator()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button) sender;
            txtResult.Text += Convert.ToString(clickedButton.Tag);
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            decimal toNegate = Convert.ToDecimal(txtResult.Text);
            toNegate = -toNegate;
            txtResult.Text = toNegate.ToString();
        }

        // set operator and store the most recently entered number
        /*
         * This is kludgy IMO.  It'd be more elegant to have a single method that reads the button's Tag
         * attribute and sets the operator to that after updating the values to do math on.  The Project
         * specs say we're supposed to have these four methods, so here they are.
         */ 
        private void btnDivide_Click(object sender, EventArgs e)
        {
            // store our number and clear the text box
            myCalculator.EnterValue(0,Convert.ToDecimal(txtResult.Text));
            txtResult.Text += " / ";
            myCalculator.CurrentValue = txtResult.Text;
            // and set the operator that has been selected
            myCalculator.Divide();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // store our number and clear the text box
            myCalculator.EnterValue(0, Convert.ToDecimal(txtResult.Text));
            txtResult.Text += " * ";
            myCalculator.CurrentValue = txtResult.Text;
            // and set the operator that has been selected
            myCalculator.Multiply();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            // store our number and clear the text box
            myCalculator.EnterValue(0, Convert.ToDecimal(txtResult.Text));
            txtResult.Text += " - ";
            myCalculator.CurrentValue = txtResult.Text;
            // and set the operator that has been selected
            myCalculator.Subtract();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // store our number and clear the text box
            myCalculator.EnterValue(0, Convert.ToDecimal(txtResult.Text));
            txtResult.Text += " + ";
            myCalculator.CurrentValue = txtResult.Text;
            // and set the operator that has been selected
            myCalculator.Add();
        }

        // and a method to deal with clicking the = button.
        private void btnEquals_Click(object sender, EventArgs e)
        {
            // store our second number and clear the text box
            int chars2strip = myCalculator.CurrentValue.Length;
            string whatEntered = txtResult.Text.Substring(chars2strip);
            myCalculator.EnterValue(1, Convert.ToDecimal(whatEntered));
            txtResult.Text = "";
            // work out our answer
            decimal answer = myCalculator.Equals();
            txtResult.Text = answer.ToString();
            // and then reset calculator's CurrentValue.  
            myCalculator.CurrentValue = answer.ToString();
            // I also want to move this to the first entry in the array so my operators act sensibly
            // as per the spec
            myCalculator.EnterValue(1, answer);
        }

        // method to clear the info stored in the myCalculator object.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            myCalculator.Clear();
        }


    }
}
