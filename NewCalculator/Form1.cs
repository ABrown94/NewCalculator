using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculator
{
    public partial class Calculator : Form
    {
        string operation = "";
        double total = 0;
        double currentNum = 0;
        //bool clearscreen = false;
        bool specialOp = false;
        bool on = false;
        //List<string> input = new List<string>();

        public Calculator()
        {
            InitializeComponent();
        }
        private void ON_Click(object sender, EventArgs e)
        {
            on = true;
            TextBox.Text = "0";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            /*if (clearscreen == true)
            {
                TextBox.Text = "";
                clearscreen = false;
            }*/
            if(on)
            {
                Button number = sender as Button;
                if (TextBox.Text == "0")
                    TextBox.Text = number.Text;
                else
                    TextBox.Text += number.Text;
            }
            
        }
        //basic operations
        private void basicOp_Click(object sender, EventArgs e)
        {
            //clearscreen = true;
            //input.Add(total.ToString());
            total = Convert.ToDouble(TextBox.Text);
            
            if (sender == basicOp)//PLUS
                operation = "+";

            if (sender == minus)
                operation = "-";

            if (sender == multiply)
                operation = "*";

            if (sender == divide)
                operation = "÷";
            if (sender == PWR)
                operation = "^";

            //input.Add(operation);
            TextBox.Text += " " + operation + " ";

        }
        //SPECIAL OPERATIONS
        private void SQRT_Click(object sender, EventArgs e)
        {
            //input.Add(total.ToString());
            total = Convert.ToDouble(TextBox.Text);
            specialOp = true;

            if (sender == SQRT)
                operation = "√";

            if (sender == SQR)
                operation = "x²";

            if (sender == PWR)
                operation = "^";

            if (sender == LOG)
                operation = "log";

            if (sender == LN)
                operation = "ln";

            if (sender == SIN)
                operation = "sin";

            if (sender == COS)
                operation = "cos";

            if (sender == TAN)
                operation = "tan";

            //input.Add(operation);
        }
        private void equals_Click(object sender, EventArgs e)
        {
            //input.Add(currentNum.ToString());
            
            //currentNum = Convert.ToDouble(TextBox.Text);
            currentNum = Convert.ToDouble(TextBox.Text.Split(' ').Last());
            //clearscreen = true;
            if (specialOp)
                CalculateSpecialOp(total, operation);         
            else
                CalculateBasicOp(total, currentNum, operation);


        }
        public void CalculateBasicOp(double total, double currentNum, string operation)
        {
            switch (operation)
            {
                case "+":
                    total += currentNum;
                    TextBox.Text = total.ToString();
                    break;
                case "-":
                    total -= currentNum;
                    TextBox.Text = total.ToString();
                    break;
                case "*":
                    total *= currentNum;
                    TextBox.Text = total.ToString();
                    break;
                case "/":
                    total /= currentNum;
                    TextBox.Text = total.ToString();
                    break;
                case "^":
                    TextBox.Text = Math.Pow(total, currentNum).ToString();
                    break;
            }
            /*double result = total;
            for(int i = 0; i < input.Count; i++)
            {
                switch (operation)
                {
                    case "+":
                        result += Convert.ToDouble(input[i - 1]) + Convert.ToDouble(input[i + 1]); 
                        //total += currentNum;
                        //TextBox.Text = total.ToString();
                        break;
                    case "-":
                        result += Convert.ToDouble(input[i - 1]) - Convert.ToDouble(input[i + 1]);
                        //total -= currentNum;
                        //TextBox.Text = total.ToString();
                        break;
                    case "*":
                        total *= currentNum;
                        TextBox.Text = total.ToString();
                        break;
                    case "/":
                        total /= currentNum;
                        TextBox.Text = total.ToString();
                        break;
                    case "^":
                        TextBox.Text = Math.Pow(total, currentNum).ToString();
                        break;
                }
            }
            TextBox.Text = result.ToString();*/
        }
        public void CalculateSpecialOp(double total, string operation)
        {
            switch (operation)
            {
                case "√":
                    //TextBox.AppendText(Environment.NewLine + Math.Sqrt(total).ToString());
                    //TextBox.SelectionAlignment = HorizontalAlignment.Right;
                    TextBox.Text = Math.Sqrt(total).ToString();
                    break;
                case "x²":
                    TextBox.Text = (total*total).ToString();
                    break;
                case "log":                  
                    TextBox.Text = Math.Log10(total).ToString();
                    break;
                case "ln":
                    TextBox.Text = Math.Log(total).ToString();
                    break;
                case "sin":
                    TextBox.Text = Math.Sin(total).ToString();
                    break;
                case "cos":
                    TextBox.Text = Math.Cos(total).ToString();
                    break;
                case "tan":
                    TextBox.Text = Math.Tan(total).ToString();
                    break;
            }
        }

        private void CLR_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.EndsWith(" "))
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 2, 2);

            else
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1, 1);
        }
        
    }
}
