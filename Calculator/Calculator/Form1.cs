using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement; 

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar < 48 || e.KeyChar > 57) && number != 8 && (e.KeyChar < 42 || e.KeyChar > 44) && number != 45 && number != 47 && number != 61) //калькулятор
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "1";
            else tbMain.Text = "1";
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                if (tbMain.Text.Length != 1)
                    tbMain.Text = tbMain.Text.Remove(tbMain.Text.Length - 1);
                else tbMain.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "2";
            else tbMain.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "3";
            else tbMain.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "4";
            else tbMain.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "5";
            else tbMain.Text = "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "6";
            else tbMain.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "7";
            else tbMain.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "8";
            else tbMain.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "9";
            else tbMain.Text = "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "0")
                tbMain.Text += "0";
            else tbMain.Text = "0";
            labelError.Visible = false;
        }

        private void buttonDelimiter_Click(object sender, EventArgs e)
        {
            labelError.Visible = false;
            char[] mathsigns = { '+', '-', '/', '*' };
            int mathsign_index = tbMain.Text.IndexOfAny(mathsigns);
            //Console.WriteLine(mathsign_index);
            //string first_number = tbMain.Text.Substring(0, mathsign_index);
            //string second_number = tbMain.Text.Substring(mathsign_index + 1);
            if (tbMain.Text == "")
                tbMain.Text = "0,";
            if (mathsign_index != -1 && !tbMain.Text.Substring(0, mathsign_index).Contains(',') || !tbMain.Text.Substring(mathsign_index + 1).Contains(','))
                tbMain.Text += ",";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            tbMain.Clear();
            tbMain.Text = "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "" && !tbMain.Text.Contains('+'))
                tbMain.Text += "+";
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivision.Enabled = false;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            buttonPlus.Enabled = true;
            buttonMinus.Enabled = true;
            buttonMultiply.Enabled = true;
            buttonDivision.Enabled = true;

            //int expression = int.Parse(tbMain.Text);
            char[] mathsigns = { '+', '-', '/', '*' };
            char[] mathsigns_wo_minus = { '+', '/', '*' };
            int mathsign_index = tbMain.Text.IndexOfAny(mathsigns);
            string first_number = "";
            string second_number = "";
            if (tbMain.Text.StartsWith("-"))
                mathsign_index = tbMain.Text.IndexOfAny(mathsigns_wo_minus);
            if (mathsign_index > 0)
            {
                first_number = tbMain.Text.Substring(0, mathsign_index);
                second_number = tbMain.Text.Substring(mathsign_index + 1);
            }
            else mathsign_index = 0;

            //double result;
            //Console.WriteLine(mathsign_index);
            if (tbMain.Text.Contains('+'))
            {
                double result = double.Parse(first_number) + double.Parse(second_number);
                tbMain.Text = result.ToString();
            }
            if (tbMain.Text.Contains('-') & !tbMain.Text.StartsWith("-"))
            {
                double result = double.Parse(first_number) - double.Parse(second_number);
                tbMain.Text = result.ToString();
            }
            if (tbMain.Text.Contains('*'))
            {
                double result = double.Parse(first_number) * double.Parse(second_number);
                tbMain.Text = result.ToString();
            }
            if (tbMain.Text.Contains('/'))
            {
                if (double.Parse(second_number) != 0)
                {
                    double result = double.Parse(first_number) / double.Parse(second_number);
                    tbMain.Text = result.ToString();
                }
                else labelError.Visible = true;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            char[] mathsigns = { '+', '/', '*' };
            int mathsign_index = tbMain.Text.IndexOfAny(mathsigns);

            if (!tbMain.Text.Contains('-'))
                tbMain.Text += "-";
            //if (mathsign_index != -1 && !tbMain.Text.Substring(0, mathsign_index).Contains('-') || !tbMain.Text.Substring(mathsign_index + 1).Contains('-'))
            //tbMain.Text += "-";
            //buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            //buttonMultiply.Enabled = false;
            //buttonDivision.Enabled = false;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "" && !tbMain.Text.Contains('*'))
                tbMain.Text += "*";
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivision.Enabled = false;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (tbMain.Text != "" && !tbMain.Text.Contains('/'))
                tbMain.Text += "/";
            labelError.Visible = false;
            buttonPlus.Enabled = false;
            buttonMinus.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonDivision.Enabled = false;
        }
    }
}