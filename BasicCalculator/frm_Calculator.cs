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


    }
}
