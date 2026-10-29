using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool newNumber = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        // Тоон товчлуурууд
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (newNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
                newNumber = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        // Үйлдлийн товчлуурууд
        private void Operator_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out firstNumber))
                return;

            Button btn = (Button)sender;
            operation = btn.Text;
            newNumber = true;
        }

        // Тэнцүү
        private void Equal_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out double secondNumber))
                return;

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("0-д хувааж болохгүй!");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;

                default:
                    return;
            }

            txtDisplay.Text = result.ToString();
            newNumber = true;
            operation = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            firstNumber = 0;
            operation = "";
            newNumber = true;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            Number_Click(sender, e);
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {

            Number_Click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            Number_Click(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            Number_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            Clear_Click(sender, e);
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            Number_Click(sender, e);
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            Equal_Click(sender, e);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

            Operator_Click(sender, e);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

            Operator_Click(sender, e);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            Operator_Click(sender, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            Operator_Click(sender, e);
        }
    }
}