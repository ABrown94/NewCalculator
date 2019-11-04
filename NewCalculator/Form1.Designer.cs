namespace NewCalculator
{
    partial class Calculator
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
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ON = new System.Windows.Forms.Button();
            this.CLR = new System.Windows.Forms.Button();
            this.SQRT = new System.Windows.Forms.Button();
            this.SQR = new System.Windows.Forms.Button();
            this.PWR = new System.Windows.Forms.Button();
            this.LOG = new System.Windows.Forms.Button();
            this.SIN = new System.Windows.Forms.Button();
            this.LN = new System.Windows.Forms.Button();
            this.COS = new System.Windows.Forms.Button();
            this.TAN = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.basicOp = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TextBox.Location = new System.Drawing.Point(46, 33);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(234, 51);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            // 
            // ON
            // 
            this.ON.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ON.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ON.ForeColor = System.Drawing.SystemColors.Control;
            this.ON.Location = new System.Drawing.Point(221, 125);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(59, 32);
            this.ON.TabIndex = 1;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = false;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // CLR
            // 
            this.CLR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CLR.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLR.ForeColor = System.Drawing.SystemColors.Control;
            this.CLR.Location = new System.Drawing.Point(46, 125);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(59, 32);
            this.CLR.TabIndex = 2;
            this.CLR.Text = "CLR";
            this.CLR.UseVisualStyleBackColor = false;
            this.CLR.Click += new System.EventHandler(this.CLR_Click);
            // 
            // SQRT
            // 
            this.SQRT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SQRT.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQRT.ForeColor = System.Drawing.SystemColors.Control;
            this.SQRT.Location = new System.Drawing.Point(26, 172);
            this.SQRT.Name = "SQRT";
            this.SQRT.Size = new System.Drawing.Size(45, 28);
            this.SQRT.TabIndex = 3;
            this.SQRT.Text = "√";
            this.SQRT.UseVisualStyleBackColor = false;
            this.SQRT.Click += new System.EventHandler(this.SQRT_Click);
            // 
            // SQR
            // 
            this.SQR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SQR.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQR.ForeColor = System.Drawing.SystemColors.Control;
            this.SQR.Location = new System.Drawing.Point(96, 173);
            this.SQR.Name = "SQR";
            this.SQR.Size = new System.Drawing.Size(45, 28);
            this.SQR.TabIndex = 4;
            this.SQR.Text = "x²";
            this.SQR.UseVisualStyleBackColor = false;
            this.SQR.Click += new System.EventHandler(this.SQRT_Click);
            // 
            // PWR
            // 
            this.PWR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PWR.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWR.ForeColor = System.Drawing.SystemColors.Control;
            this.PWR.Location = new System.Drawing.Point(172, 173);
            this.PWR.Name = "PWR";
            this.PWR.Size = new System.Drawing.Size(45, 28);
            this.PWR.TabIndex = 5;
            this.PWR.Text = "^";
            this.PWR.UseVisualStyleBackColor = false;
            this.PWR.Click += new System.EventHandler(this.basicOp_Click);
            // 
            // LOG
            // 
            this.LOG.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LOG.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOG.ForeColor = System.Drawing.SystemColors.Control;
            this.LOG.Location = new System.Drawing.Point(245, 173);
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(45, 28);
            this.LOG.TabIndex = 6;
            this.LOG.Text = "log";
            this.LOG.UseVisualStyleBackColor = false;
            this.LOG.Click += new System.EventHandler(this.SQRT_Click);
            // 
            // SIN
            // 
            this.SIN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SIN.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIN.ForeColor = System.Drawing.SystemColors.Control;
            this.SIN.Location = new System.Drawing.Point(96, 211);
            this.SIN.Name = "SIN";
            this.SIN.Size = new System.Drawing.Size(45, 28);
            this.SIN.TabIndex = 7;
            this.SIN.Text = "sin";
            this.SIN.UseVisualStyleBackColor = false;
            // 
            // LN
            // 
            this.LN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LN.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.ForeColor = System.Drawing.SystemColors.Control;
            this.LN.Location = new System.Drawing.Point(26, 211);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(45, 28);
            this.LN.TabIndex = 8;
            this.LN.Text = "ln";
            this.LN.UseVisualStyleBackColor = false;
            // 
            // COS
            // 
            this.COS.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.COS.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COS.ForeColor = System.Drawing.SystemColors.Control;
            this.COS.Location = new System.Drawing.Point(172, 211);
            this.COS.Name = "COS";
            this.COS.Size = new System.Drawing.Size(45, 28);
            this.COS.TabIndex = 9;
            this.COS.Text = "cos";
            this.COS.UseVisualStyleBackColor = false;
            // 
            // TAN
            // 
            this.TAN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TAN.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAN.ForeColor = System.Drawing.SystemColors.Control;
            this.TAN.Location = new System.Drawing.Point(245, 211);
            this.TAN.Name = "TAN";
            this.TAN.Size = new System.Drawing.Size(45, 28);
            this.TAN.TabIndex = 10;
            this.TAN.Text = "tan";
            this.TAN.UseVisualStyleBackColor = false;
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DELETE.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.ForeColor = System.Drawing.SystemColors.Control;
            this.DELETE.Location = new System.Drawing.Point(134, 125);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(59, 32);
            this.DELETE.TabIndex = 11;
            this.DELETE.Text = "DEL";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.seven.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.SystemColors.Control;
            this.seven.Location = new System.Drawing.Point(26, 259);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(57, 41);
            this.seven.TabIndex = 12;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.Button1_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.eight.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.ForeColor = System.Drawing.SystemColors.Control;
            this.eight.Location = new System.Drawing.Point(96, 259);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(57, 41);
            this.eight.TabIndex = 13;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.Button1_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nine.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.ForeColor = System.Drawing.SystemColors.Control;
            this.nine.Location = new System.Drawing.Point(162, 259);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(57, 41);
            this.nine.TabIndex = 14;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.Button1_Click);
            // 
            // basicOp
            // 
            this.basicOp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.basicOp.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicOp.ForeColor = System.Drawing.SystemColors.Control;
            this.basicOp.Location = new System.Drawing.Point(233, 259);
            this.basicOp.Name = "basicOp";
            this.basicOp.Size = new System.Drawing.Size(57, 41);
            this.basicOp.TabIndex = 15;
            this.basicOp.Text = "+";
            this.basicOp.UseVisualStyleBackColor = false;
            this.basicOp.Click += new System.EventHandler(this.basicOp_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.minus.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.ForeColor = System.Drawing.SystemColors.Control;
            this.minus.Location = new System.Drawing.Point(233, 306);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(57, 41);
            this.minus.TabIndex = 19;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.basicOp_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.six.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.SystemColors.Control;
            this.six.Location = new System.Drawing.Point(162, 306);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(57, 41);
            this.six.TabIndex = 18;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.Button1_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.five.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.SystemColors.Control;
            this.five.Location = new System.Drawing.Point(96, 306);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(57, 41);
            this.five.TabIndex = 17;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.MouseCaptureChanged += new System.EventHandler(this.Button1_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.four.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.SystemColors.Control;
            this.four.Location = new System.Drawing.Point(26, 306);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(57, 41);
            this.four.TabIndex = 16;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.Button1_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.divide.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.ForeColor = System.Drawing.SystemColors.Control;
            this.divide.Location = new System.Drawing.Point(233, 353);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(57, 41);
            this.divide.TabIndex = 23;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.basicOp_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.three.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.SystemColors.Control;
            this.three.Location = new System.Drawing.Point(162, 353);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(57, 41);
            this.three.TabIndex = 22;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.Button1_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.two.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.SystemColors.Control;
            this.two.Location = new System.Drawing.Point(96, 353);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(57, 41);
            this.two.TabIndex = 21;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button1.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.SystemColors.Control;
            this.Button1.Location = new System.Drawing.Point(26, 353);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(57, 41);
            this.Button1.TabIndex = 20;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.multiply.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.ForeColor = System.Drawing.SystemColors.Control;
            this.multiply.Location = new System.Drawing.Point(233, 400);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(57, 41);
            this.multiply.TabIndex = 27;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.basicOp_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.equals.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.ForeColor = System.Drawing.SystemColors.Control;
            this.equals.Location = new System.Drawing.Point(162, 400);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(57, 41);
            this.equals.TabIndex = 26;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.zero.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.ForeColor = System.Drawing.SystemColors.Control;
            this.zero.Location = new System.Drawing.Point(96, 400);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(57, 41);
            this.zero.TabIndex = 25;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dec
            // 
            this.dec.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dec.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.ForeColor = System.Drawing.SystemColors.Control;
            this.dec.Location = new System.Drawing.Point(26, 400);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(57, 41);
            this.dec.TabIndex = 24;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = false;
            this.dec.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(322, 459);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.basicOp);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.TAN);
            this.Controls.Add(this.COS);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.SIN);
            this.Controls.Add(this.LOG);
            this.Controls.Add(this.PWR);
            this.Controls.Add(this.SQR);
            this.Controls.Add(this.SQRT);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.ON);
            this.Controls.Add(this.TextBox);
            this.Name = "Calculator";
            this.Text = "Scientific Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button CLR;
        private System.Windows.Forms.Button SQRT;
        private System.Windows.Forms.Button SQR;
        private System.Windows.Forms.Button PWR;
        private System.Windows.Forms.Button LOG;
        private System.Windows.Forms.Button SIN;
        private System.Windows.Forms.Button LN;
        private System.Windows.Forms.Button COS;
        private System.Windows.Forms.Button TAN;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button basicOp;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dec;
    }
}

