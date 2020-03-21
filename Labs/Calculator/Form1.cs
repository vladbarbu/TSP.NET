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
        Double Result_Value = 0;
        String Operator_Performed = " ";
        bool PerformedOp = false;


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(getKey);
        }

        private void getKey(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            Button keyPressed = new Button();
            keyPressed.Text = e.KeyChar.ToString();
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '.':
                    button15_Click(keyPressed, e);
                    break;
                case '+':
                case '-':
                case '*':
                case '/':
                    Operator_click_Event(keyPressed, e);
                    break;
                case '=':
                    button16_Click(keyPressed, e);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // numbers button and point
            if (textBox_Result.Text == "0" || PerformedOp)
                textBox_Result.Clear();
            Console.WriteLine(sender);
            PerformedOp = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text += button.Text;
            }
            else
            {
                textBox_Result.Text += button.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Operator_click_Event(object sender, EventArgs e)
        {
            // +, -, *, / operators
            
            Button button = (Button)sender;

            if (Result_Value != 0)
            {
                button16.PerformClick();
                Operator_Performed = button.Text;
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
            else
            {

                Operator_Performed = button.Text;
                Result_Value = Double.Parse(textBox_Result.Text);
                label_Show_Op.Text = Result_Value + " " + Operator_Performed;
                PerformedOp = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CLEAR ENTRY BUTTON
            textBox_Result.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON
            textBox_Result.Text = "0";
            Result_Value = 0;
            label_Show_Op.Text = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // EQUALS BUTTON
            switch (Operator_Performed)
            {
                case "+":
                    textBox_Result.Text = (Result_Value + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (Result_Value - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (Result_Value * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (Result_Value / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
            Result_Value = Double.Parse(textBox_Result.Text);
            label_Show_Op.Text = " ";
        }
    }
}
