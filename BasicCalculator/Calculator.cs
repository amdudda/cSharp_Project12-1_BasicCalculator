using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Calculator
    {
        /* 
         * The spec says this should be a class, but I wonder if it this shouldn't actually be a structure.
         * Since I'm a little wibbly on that, I'm going to play it safe and keep this as a class.
         */

        public string CurrentValue;
        private string operation;
        private decimal[] enterValue;
        private static bool clearinput; // tracks whether we need to clear input - sets to true after enter key is pressed

        // basic constructor
        public Calculator() {
            this.enterValue = new decimal[2];
            clearinput = false; 
        }

        // methods to set current operator
        public void Add() { this.operation = "add"; }
        public void Subtract() { this.operation = "subtract"; }
        public void Multiply() { this.operation = "multiply"; }
        public void Divide() { this.operation = "divide"; }

        // method to add operator and operand
        public void EnterValue(int index, decimal num)
        {
            // not quite sure what Andy wants here??????
            this.enterValue[index] = num;
        }

        public decimal EnterValue(int index)
        {
            return this.enterValue[index];
        }

        // methods to perform operations
        public decimal Equals()
        {
            // calculates basic operations
            decimal result = 0;
            if (this.operation == "add")
            {
                result = enterValue[0] + enterValue[1];
            }
            else if (this.operation == "subtract")
            {
                result = enterValue[0] - enterValue[1];
            }
            else if (this.operation == "multiply")
            {
                result = enterValue[0] * enterValue[1];
            }
            else // (this.operation == "divide")
            {
                result = enterValue[0] / enterValue[1];
            }
            return result;
        }

        public decimal SquareRoot(decimal toRoot) //decimal num)
        {
            // returns a square root - check for negative numbers!
            if (toRoot < 0)
            {
                System.Windows.Forms.MessageBox.Show("Cannot retrieve square root of negative number!","Invalid Entry",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
                return toRoot;
            }
            else
            {
                return Convert.ToDecimal(Math.Sqrt((double)toRoot));
            }
        }

        public decimal Reciprocal(decimal toflip) //decimal num)
        {
            // returns a reciprocal
            return (1 / toflip);
        }

        public decimal Negative(decimal toSign)
        {
            return -toSign;
        }

        // a method to clear the information in the calculator
        public void Clear()
        {
            this.CurrentValue = "";
            this.operation = "";
            Array.Clear(enterValue,0,enterValue.Length);
        }

        public bool Clearinput()
        {
                return clearinput;
        }

        public void Clearinput(bool needscleared)
        {
            clearinput = needscleared;
        }

    }
}
