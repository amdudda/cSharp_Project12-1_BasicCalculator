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
            this.Focus();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            // we know this is going to be a button, so this explicit cast is safe to do.
            Button clickedButton = (Button) sender;
            // clear previous result from screen
            if (myCalculator.Clearinput())
            {
                txtResult.Text = "";
                myCalculator.Clearinput(false);
            }
            // if dot button and a dot already exists, return (do nothing)
            if ( clickedButton.Tag.ToString() == "." && (txtResult.Text.IndexOf(".") != -1)) return;

            // make sure that we don't generate a whole bunch of useless leading zeroes.
            bool noLeadingZeros = !(clickedButton.Tag.ToString() == "0" && txtResult.Text == "0");
            if ( noLeadingZeros) 
                txtResult.Text += Convert.ToString(clickedButton.Tag);
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            // negates the number currently displayed.
            decimal toNegate = Convert.ToDecimal(txtResult.Text);
            toNegate = -toNegate;
            txtResult.Text = toNegate.ToString();
        }

        // set operator and store the most recently entered number
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            // we know this is going to be a button, so this explicit cast is safe to do.
            Button myButton = (Button) sender;
            string buttonTag = myButton.Tag.ToString();

            // store our number and clear the text box
            myCalculator.EnterValue(0, Convert.ToDecimal(txtResult.Text));
            // process which operator was clicked and act appropriately
            // set the operator that has been selected
            if (buttonTag == "divide")
            {
                myCalculator.Divide();
                txtResult.Text += " / ";
            }
            else if (buttonTag == "multiply")
            {
                myCalculator.Multiply();
                txtResult.Text += " * ";
            }
            else if (buttonTag == "subtract")
            {
                myCalculator.Subtract();
                txtResult.Text += " - ";
            }
            else if (buttonTag == "add")
            {
                myCalculator.Add();
                txtResult.Text += " + ";
            }
            // update currentvalue and hasDot, then clear contents of txtResult
            myCalculator.CurrentValue = txtResult.Text;
            txtResult.Text = "";

        }

        // and a method to deal with clicking the = button.
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                // throw new Exception();
                DoTheMath();
            }
            catch (DivideByZeroException)
            {
                txtResult.Text = "Divide by Zero not allowed.  Clear and try again.";
            }
            catch (FormatException)
            {
                string msg = "Something is broken with your input.  Check to make sure you haven't accidentally entered extraneous characters or accidentally pressed [Enter] without inputting a second number to operate on.";
                MessageBox.Show(msg, "Can't do math!");
            }
            catch (NullReferenceException)
            {
                string msg = "You tried to do a calculation on only one value. Please make sure you have selected an operator and entered a second value.";
                MessageBox.Show(msg, "Bad Math!");
            }
            catch (Exception ex)
            {
                // TODO in a production version, we'd be more user friendly and not display the stack trace!
                string msg = "An unexpected error occurred: \n";
                msg += ex.Message + "\n" + ex.StackTrace;
                string caption = ex.GetType().ToString();
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoTheMath()
        {
            // store our second number and clear the text box
            myCalculator.EnterValue(1, Convert.ToDecimal(txtResult.Text)); 
            txtResult.Text = "";
            // work out our answer
            decimal answer = myCalculator.Equals();
            txtResult.Text = answer.ToString();
            // and then reset calculator's CurrentValue.  
            myCalculator.CurrentValue = answer.ToString();
            // I also want to move this to the first entry in the array so my operators act sensibly
            // as per the spec
            myCalculator.EnterValue(1, answer);
            // also set the form to clear if a user enters a number
            myCalculator.Clearinput(true);
        }

        // method to clear the info stored in the myCalculator object.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            myCalculator.Clear();
            txtResult.Focus();
            Console.Write("val1: " + myCalculator.EnterValue(0) + ", val2: " + myCalculator.EnterValue(1));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // clear the last character entered.
            int chars2keep = txtResult.Text.Length - 1;
            if (chars2keep >= 0) txtResult.Text = txtResult.Text.Substring(0, chars2keep);
            // TODO keep user from backing over operator?  or handle that sensibly?
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            // first set the current value of the box to the contents of the text box
            // TODO: need to fix this so it handles any previous calculations gracefully.
            myCalculator.EnterValue(0, Convert.ToDecimal(txtResult.Text));
            decimal answer = myCalculator.SquareRoot();
            txtResult.Text = answer.ToString();
            myCalculator.CurrentValue = answer.ToString();
            myCalculator.EnterValue(0, answer);
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            // first set the current value of the box to the contents of the text box
            // TODO: need to fix this so it handles any previous calculations gracefully.
            myCalculator.EnterValue(0, Convert.ToDecimal(txtResult.Text));
            decimal answer = myCalculator.Reciprocal();
            txtResult.Text = answer.ToString();
            myCalculator.CurrentValue = answer.ToString();
            myCalculator.EnterValue(0, answer);
        }

        private void frm_Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            // listens for keyboard input and acts on it as appropriate.
            // e.KeyCode is the code of the charater pressed
            // see https://msdn.microsoft.com/en-us/library/system.windows.forms.control.keydown.aspx?f=255&MSPPError=-2147217396 ffi
            // this also helped: https://msdn.microsoft.com/en-us/library/ms171538%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396

            string myCharacter = e.KeyChar.ToString();
            //MessageBox.Show("" + myCharacter);
            string digits = "0123456789.";
            string operators = "+--/*";  // we want to treat dash and minus as the same thing
            if (digits.IndexOf(myCharacter) != -1)
            {
                // process the character
                //MessageBox.Show("You typed the number: " + myCharacter);
                foreach (Control b in this.Controls)
                {
                    string myTag;
                    if (b.Tag == null) myTag = "";
                        else myTag = b.Tag.ToString();
                    if (b is Button && (myTag == myCharacter))
                    {
                        // MessageBox.Show("Processing button " + b.Tag);
                        // do the thing associated with that button
                        NumberButton_Click(b,null);
                    }
                }
            }
            else if (operators.IndexOf(myCharacter) != -1)
            {
                ProcessOperator(myCharacter);
            }
            else if ("sr=n".IndexOf(myCharacter) != -1)
            {
                if (myCharacter == "s") btnSqrt_Click(btnSqrt, null);
                else if (myCharacter == "r") btnReciprocal_Click(btnReciprocal, null);
                else if (myCharacter == "=") btnEquals_Click(btnEquals, null);
                else // negative chosen
                    btnNegative_Click(btnNegative, null);
            }
            else
            {
                // do nothing
            }

            e.Handled = true;
        }

        private void ProcessOperator(string myCharacter)
        {
            foreach (Control b in this.Controls)
            {
                string myTag;
                if (b.Text == null) myTag = "";
                else myTag = b.Text;
                if (b is Button && (myTag == myCharacter))
                {
                    OperatorButton_Click(b, null);
                } // end if b is button
            } // end foreach Control
        } // end ProcessOperator

        private void lblHints_Click(object sender, EventArgs e)
        {
            string msg = "You can use the keyboard to enter data.  \n"+
                "Use numbers and +, -, /, * for basic operations.\n" +
                "Use [=] or [enter] to trigger the calculation.\n" +
                "Square root can be accessed with [s], reciprocal with [r], and negation with [n].\n" +
                "Use Alt+B to backspace, or Alt+C to clear all input.";
            MessageBox.Show(msg,"Tips and Tricks",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


    }
}
