﻿using System;
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

        // basic constructor
        public Calculator() {
            this.enterValue = new decimal[2];
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

        // methods to perform operations
        public decimal Equals()
        {
            // TODO: Validation before getting here!
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

        public decimal SquareRoot(decimal num)
        {
            // returns a square root;
            return Convert.ToDecimal(Math.Sqrt((double) num));
        }

        public decimal Reciprocal(decimal num)
        {
            // returns a reciprocal
            return (1 / num);
        }

        // a method to clear the information in the calculator
        public void Clear()
        {
            this.CurrentValue = "";
            this.operation = "";
            Array.Clear(enterValue,0,enterValue.Length);
        }
    }
}