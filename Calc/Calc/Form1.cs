using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();      
        public Form1()
        {
            InitializeComponent();
            display.Text = "0";
        }

        public double memory = 0;

        private void numbers_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (display.Text == "0")
                display.Clear();
            else if (display.Text == calc.result.ToString())
                display.Clear();
           
            display.Text += btn.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calc.firstNumber = double.Parse(display.Text);
            display.Text = (calc.firstNumber * (-1)).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" || display.Text == "")
                display.Text = "0,";
            else display.Text += ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            calc.firstNumber = 0;
            calc.secondNumber = 0;
            calc.result = 0;
            calc.operation = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            display.Text = display.Text.Substring(0, display.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calc.firstNumber = double.Parse(display.Text);
            display.Text = (calc.firstNumber / 100).ToString();
         }

        private void button17_Click(object sender, EventArgs e)
        {
            calc.firstNumber = double.Parse(display.Text);
            display.Text = Math.Sqrt(calc.firstNumber).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            calc.firstNumber = double.Parse(display.Text);
            display.Text = Math.Pow(calc.firstNumber, 2).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            calc.firstNumber = double.Parse(display.Text);
            display.Text = Math.Pow(calc.firstNumber, -1).ToString();
        }

        private void button25_Click(object sender, EventArgs e)//memory clear
        {
            memory = 0;
        }

        private void button26_Click(object sender, EventArgs e)//memory read
        {
            display.Text = memory.ToString();
        }

        private void button29_Click(object sender, EventArgs e)//memory save
        {
            memory = Double.Parse(display.Text);
            display.Clear();
        }

        private void button27_Click(object sender, EventArgs e)//m+
        {
            memory = (memory + Double.Parse(display.Text));
        }

        private void button28_Click(object sender, EventArgs e)//m-
        {
            memory = memory - Double.Parse(display.Text);
        }


        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            calc.firstNumber = double.Parse(display.Text);
            //display.Text = calc.firstNumber.ToString()
            //display.Text = (calc.firstNumber +  +"").ToString();
            //display.Text = calc.firstNumber.ToString() + calc.operation;
            calc.operation = btn.Text;
            display.Text = "";
        }

        private void result_click(object sender, EventArgs e)
        {
            calc.secondNumber = double.Parse(display.Text);
            calc.calculate();
            display.Text = calc.result.ToString();
        }
    }
}
