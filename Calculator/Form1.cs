using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalculator calculator;
        static int situation = 1;
        static double Number1 = 0;
        static double Number2 = 0;
        static string operation;
        bool IsCalculated = false;
        bool IsFraction = false;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = System.Drawing.Color.Black;
        }
        private void click_calculator(int situation)
        {

        }
        
        private double Operator(string operation, double Number1, double Number2)
        {
            double result;
            switch (operation)
            {
                case "Plus":
                    {
                        result = calculator.Plus(Number1, Number2);
                        situation = 1;
                        return result;

                    }
                case "Power":
                    {
                        result = calculator.Power(Number1, Number2);
                        situation = 1;
                        return result;

                    }
                case "Divide":
                    {
                        result = calculator.Divide(Number1, Number2);
                        situation = 1;
                        return result;

                    }
                case "Minus":
                    {
                        result = calculator.Minus(Number1, Number2);
                        situation = 1;
                        return result;
                    }
                case "Multiple":
                    {
                        result = calculator.Multiple(Number1, Number2);
                        situation = 1;
                        return result;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }
        private void Plusbtn_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                textShow.Text = $"{Number1} + ";
                situation = 2;
                txtNumber1.Text = "0";
                
                operation = "Plus";
            }
            switch (situation)
            {
                case 1:
                    {
                        Number1 = Convert.ToDouble(txtNumber1.Text);
                        textShow.Text = $"{txtNumber1.Text} + ";
                        txtNumber1.Text = "0";
                        situation = 2;
                        operation = "Plus";

                        break;
                    }
                case 3:
                    {
                        Number2 = Convert.ToDouble(txtNumber1.Text);

                        Number1 = Operator(operation, Number1, Number2);
                        textShow.Text = $"{Number1} +";
                        txtNumber1.Text = "0";
                        situation = 2;
                        operation = "Plus";
                        break;
                    }
            }

        }
        private void Minusbtn_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                textShow.Text = $"{Number1} - ";
                situation = 2;
                txtNumber1.Text = "0";
                
                operation = "Minus";
            }
            switch (situation)
            {
                case 1:
                    {
                        Number1 = Convert.ToDouble(txtNumber1.Text);
                        textShow.Text += $"{txtNumber1.Text} - ";
                        txtNumber1.Text = "0";
                        situation = 2;
                        operation = "Minus";

                        break;
                    }
                case 3:
                    {
                        Number2 = Convert.ToDouble(txtNumber1.Text);
                        Number1 = Operator(operation, Number1, Number2);
                        textShow.Text = $"{Number1} - ";
                        txtNumber1.Text = "0";
                        situation = 2;
                        operation = "Minus";
                        break;
                    }
            }
        }

        private void Multiplebtn_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                textShow.Text = $"{Number1} × ";
                situation = 2;
                txtNumber1.Text = "0";
                
                operation = "Multiple";
            }
            switch (situation)
            {
                case 1:
                    {
                        Number1 = Convert.ToDouble(txtNumber1.Text);
                        textShow.Text += $"{txtNumber1.Text} × ";
                        txtNumber1.Text = "0";
                        situation = 2;
                        operation = "Multiple";

                        break;
                    }
                case 3:
                    {
                        Number2 = Convert.ToDouble(txtNumber1.Text);
                        Number1 = Operator(operation, Number1, Number2);
                        textShow.Text = $"{Number1} × ";
                        txtNumber1.Text = "0";
                        situation = 2;
                        operation = "Multiple";
                        break;
                    }
            }
        }

        private void Dividebtn_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                textShow.Text = $"{Number1} ÷ ";
                situation = 2;
                txtNumber1.Text = "0";
                
                operation = "Divide";
            }
            if (Number2 != 0)
            {
                switch (situation)
                {
                    case 1:
                        {
                            Number1 = Convert.ToDouble(txtNumber1.Text);
                            textShow.Text += $"{txtNumber1.Text} ÷ ";
                            txtNumber1.Text = "0";
                            situation = 2;
                            operation = "Divide";

                            break;
                        }
                    case 3:
                        {
                            Number2 = Convert.ToDouble(txtNumber1.Text);
                            Number1 = Operator(operation, Number1, Number2);
                            textShow.Text = $"{Number1} ÷ ";
                            txtNumber1.Text = "0";
                            situation = 2;
                            operation = "Divide";
                            break;
                        }
                }
            }
            else
            {
                MessageBox.Show("The divisor can't be zero in divison.");
            }
        }

        private void Powerbtn_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                textShow.Text = $"{Number1} ^ ";
                situation = 2;
                txtNumber1.Text = "0";
                
                operation = "Power";
            }
            switch (situation)
            {
                case 1:
                    {
                        Number1 = Convert.ToDouble(txtNumber1.Text);
                        textShow.Text += $"{txtNumber1.Text} ^ ";
                        txtNumber1.Text = "0";
                        situation = 2;
                        operation = "Power";
                        txtNumber1.Text = "0";

                        break;
                    }
                case 3:
                    {
                        Number2 = Convert.ToDouble(txtNumber1.Text);
                        Number1 = Operator(operation, Number1, Number2);
                        textShow.Text = $"{Number1} ^ ";
                        txtNumber1.Text = "0";
                        situation = 2;
                        operation = "Power";
                        break;
                    }
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            NumberInput((int)txtNumber2.Value);
        }
        private void NumberInput(int number)
        {
            switch (situation)
            {
                case 1:
                    {
                        if (!IsFraction)
                        {
                            Number1 = Number1 * 10 + number;
                        }
                        else
                        {
                            string fraction = (Number1 % 1).ToString();
                            int DigitCount = (fraction.Length) - 2;
                            Number1 += number * Math.Pow(0.1, DigitCount + 1);
                        }
                        if (txtNumber1.Text != "0" && txtNumber1.Text != "")
                        {
                            txtNumber1.Text += number.ToString();
                        }
                        else if (txtNumber1.Text != "0" || txtNumber1.Text != "")
                        {
                            txtNumber1.Text = number.ToString();
                        }
                        else
                        {
                            txtNumber1.Text = "0";
                        }
                        txtNumber2.Value = 0;

                        break;
                    }
                case 2:
                    {
                        if (!IsFraction)
                        {
                            Number2 = Number2 * 10 + number;
                        }
                        else
                        {
                            string fraction = (Number2 % 1).ToString();
                            int DigitCount = (fraction.Length) - 2;
                            Number2 += number * Math.Pow(0.1, DigitCount + 1);
                        }
                        if (txtNumber1.Text != "0" && txtNumber1.Text != "")
                        {
                            txtNumber1.Text += number.ToString();
                        }
                        else if (txtNumber1.Text != "0" || txtNumber1.Text != "")
                        {
                            txtNumber1.Text = number.ToString();

                        }
                        else
                        {
                            txtNumber1.Text = "0";
                        }
                        situation = 3;
                        txtNumber2.Value = 0;
                        break;
                    }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number = 1;
            NumberInput(number);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int number = 2;
            NumberInput(number);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int number = 3;
            NumberInput(number);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int number = 4;
            NumberInput(number);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int number = 5;
            NumberInput(number);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int number = 6;
            NumberInput(number);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int number = 7;
            NumberInput(number);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int number = 8;
            NumberInput(number);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int number = 9;
            NumberInput(number);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int number = 0;
            NumberInput(number);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Number2 = Convert.ToDouble(txtNumber1.Text);
            Number1 = Operator(operation, Number1, Number2);
            textShow.Text += $"{txtNumber1.Text} =";
            txtNumber1.Text = Number1.ToString();
            
            //Number2 = 0;
            IsCalculated = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtNumber1.Text += ".";
            IsFraction = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (IsCalculated)
            {
                textShow.Text = "";
                
            }
            else if (IsFraction)
            { 
                if (txtNumber1.Text[txtNumber1.TextLength - 1] == '.')
                {
                    IsFraction = false;
                }
                else
                {
                    switch (situation)
                    {
                        case 1:
                            {
                                Number1 *= 10;
                                break;
                            }
                        case 3:
                            {
                                Number2 *= 10;
                                break;
                            }
                    }
                }
                try
                {
                    txtNumber1.Text = txtNumber1.Text.Substring(0, txtNumber1.TextLength-1);
                }
                catch{ }
            }
            else if(txtNumber1.TextLength ==1)
            {
                txtNumber1.Text = "0";
            }
            else
            {
                txtNumber1.Text = txtNumber1.Text.Substring(0, txtNumber1.TextLength-1);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textShow.Text = "";
            txtNumber1.Text = "";
            //Number2 = 0;
            Number1 = 0;
            txtNumber2.Value = 0;
            IsFraction = false;
            IsCalculated = false;
            situation = 1;
            operation = "";
        }
    }
}
