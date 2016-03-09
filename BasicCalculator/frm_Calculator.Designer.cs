namespace BasicCalculator
{
    partial class frm_Calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A.M. Dudda - Project 12-1 Basic Calculator";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(13, 26);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(229, 20);
            this.txtResult.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(13, 53);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(150, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.ForeColor = System.Drawing.Color.Blue;
            this.btn7.Location = new System.Drawing.Point(13, 96);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(30, 27);
            this.btn7.TabIndex = 4;
            this.btn7.Tag = "7";
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.Color.Blue;
            this.btn8.Location = new System.Drawing.Point(54, 96);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(30, 27);
            this.btn8.TabIndex = 5;
            this.btn8.Tag = "8";
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn9
            // 
            this.btn9.ForeColor = System.Drawing.Color.Blue;
            this.btn9.Location = new System.Drawing.Point(95, 96);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(30, 27);
            this.btn9.TabIndex = 6;
            this.btn9.Tag = "9";
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn6
            // 
            this.btn6.ForeColor = System.Drawing.Color.Blue;
            this.btn6.Location = new System.Drawing.Point(95, 129);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(30, 27);
            this.btn6.TabIndex = 9;
            this.btn6.Tag = "6";
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn5
            // 
            this.btn5.ForeColor = System.Drawing.Color.Blue;
            this.btn5.Location = new System.Drawing.Point(54, 129);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(30, 27);
            this.btn5.TabIndex = 8;
            this.btn5.Tag = "5";
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn4
            // 
            this.btn4.ForeColor = System.Drawing.Color.Blue;
            this.btn4.Location = new System.Drawing.Point(13, 129);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(30, 27);
            this.btn4.TabIndex = 7;
            this.btn4.Tag = "4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn3
            // 
            this.btn3.ForeColor = System.Drawing.Color.Blue;
            this.btn3.Location = new System.Drawing.Point(95, 162);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(30, 27);
            this.btn3.TabIndex = 12;
            this.btn3.Tag = "3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn2
            // 
            this.btn2.ForeColor = System.Drawing.Color.Blue;
            this.btn2.Location = new System.Drawing.Point(54, 162);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(30, 27);
            this.btn2.TabIndex = 11;
            this.btn2.Tag = "2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btn1
            // 
            this.btn1.ForeColor = System.Drawing.Color.Blue;
            this.btn1.Location = new System.Drawing.Point(13, 162);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(30, 27);
            this.btn1.TabIndex = 10;
            this.btn1.Tag = "1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.ForeColor = System.Drawing.Color.Blue;
            this.btnDecimal.Location = new System.Drawing.Point(95, 195);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(30, 27);
            this.btnDecimal.TabIndex = 15;
            this.btnDecimal.Tag = ".";
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.ForeColor = System.Drawing.Color.Blue;
            this.btnNegative.Location = new System.Drawing.Point(54, 195);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(30, 27);
            this.btnNegative.TabIndex = 14;
            this.btnNegative.Text = "+/-";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btn0
            // 
            this.btn0.ForeColor = System.Drawing.Color.Blue;
            this.btn0.Location = new System.Drawing.Point(13, 195);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(30, 27);
            this.btn0.TabIndex = 13;
            this.btn0.Tag = "0";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.Location = new System.Drawing.Point(150, 195);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 27);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.ForeColor = System.Drawing.Color.Red;
            this.btnSubtract.Location = new System.Drawing.Point(150, 162);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(30, 27);
            this.btnSubtract.TabIndex = 18;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.Red;
            this.btnMultiply.Location = new System.Drawing.Point(150, 129);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(30, 27);
            this.btnMultiply.TabIndex = 17;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.Red;
            this.btnDivide.Location = new System.Drawing.Point(150, 96);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(30, 27);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.ForeColor = System.Drawing.Color.Blue;
            this.btnReciprocal.Location = new System.Drawing.Point(204, 129);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(38, 27);
            this.btnReciprocal.TabIndex = 21;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.Blue;
            this.btnSqrt.Location = new System.Drawing.Point(204, 96);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(38, 27);
            this.btnSqrt.TabIndex = 20;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.Red;
            this.btnEquals.Location = new System.Drawing.Point(203, 165);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(38, 56);
            this.btnEquals.TabIndex = 22;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            // 
            // frm_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 258);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnEquals;
    }
}

