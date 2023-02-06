using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyCalc
{
    public partial class MyCalc : Form
    {
        public MyCalc()
        {
            InitializeComponent();
            button0.Click += button0_Click;
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button9_Click;
            button9.Click += button9_Click;
            button_add.Click += button_add_Click;
            button_subtract.Click += button_subtract_Click;
            button_divide.Click += button_divide_Click;
            button_multiply.Click += button_multiply_Click;
            button_equals.Click += button_equals_Click;
            button_comma.Click += button_comma_Click;
            button_clear.Click += button_clear_Click;
        }
        private void button0_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "0";
            label2.Text += "0";
        }
        private void button1_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "1";
            label2.Text += "1";
        }
        private void button2_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "2";
            label2.Text += "2";
        }
        private void button3_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "3";
            label2.Text += "3";
        }
        private void button4_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "4";
            label2.Text += "4";
        }
        private void button5_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "5";
            label2.Text += "5";
        }
        private void button6_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "6";
            label2.Text += "6";
        }
        private void button7_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "7";
            label2.Text += "7";
        }
        private void button8_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "8";
            label2.Text += "8";
        }
        private void button9_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "9";
            label2.Text += "9";
        }
        private void button_add_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "+";
            label2.Text += "+";
        }
        private void button_subtract_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "-";
            label2.Text += "-";
        }
        private void button_divide_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "/";
            label2.Text += "/";
        }
        private void button_multiply_Click(object? sender, EventArgs e)
        {
            Calculations.oper += "*";
            label2.Text += "*";
        }
        private void button_comma_Click(object? sender, EventArgs e)
        {
            Calculations.oper += ".";
            label2.Text += ".";
        }
        private void button_clear_Click(object? sender, EventArgs e)
        {
            Calculations.oper = "0";
            label1.Text = "0";
            label2.Text = "";
        }
        private void button_equals_Click(object? sender, EventArgs e)
        {
            try
            {
                string res = Calculations.Calculate();
                label1.Text=res;
                //label2.Text =res;
                //Calculations.oper = res;
            }
            catch
            {
                MessageBox.Show("Invalid Input","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Calculations.oper = "0";
                if (label1.Text == "0") label2.Text = "";
            }
            
        }
        object obj;
        EventArgs e;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.NumPad0)
            {
                button0_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad1))
            {
                button1_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad2))
            {
                button2_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad3))
            {
                button3_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad4))
            {
                button4_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad5))
            {
                button5_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad6))
            {
                button6_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad7))
            {
                button7_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad8))
            {
                button8_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.NumPad9))
            {
                button9_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.Multiply))
            {
                button_multiply_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.Subtract))
            {
                button_subtract_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.Add))
            {
                button_add_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.Divide))
            {
                button_divide_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.Decimal))
            {
                button_comma_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.Enter))
            {
                button_equals_Click(obj, e);
                return true;
            }
            else if ((keyData == Keys.C))
            {
                button_clear_Click(obj, e);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MyCalc_Load(object sender, EventArgs e)
        {

        }
    }
    static class Calculations
    {
        static internal string oper;

        public static string Calculate()
        {
            DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(oper, string.Empty)).ToString();
        }
       
    }
}
