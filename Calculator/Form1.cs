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

        int r=255, g=0, b=0;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txb_display_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                string equation = txb_display.Text;
                List<string> numbers = new List<string>(equation.Split('+', '-', '*', '/'));
                List<char> operators = new List<char>();
                foreach (char c in equation)
                {
                    if (c == '+' || c == '-' || c == '*' || c == '/')
                    {
                        operators.Add(c);
                    }
                }

                for (int i = 0; i < operators.Count; i++)
                {
                    if (operators[i] == '*' || operators[i] == '/')
                    {
                        double left = double.Parse(numbers[i]);
                        double right = double.Parse(numbers[i + 1]);
                        double res = 0;
                        if (operators[i] == '*')
                        {
                            res = left * right;
                        }
                        else if (operators[i] == '/')
                        {
                            res = left / right;
                        }

                        numbers[i] = res.ToString();
                        numbers.RemoveAt(i + 1);
                        operators.RemoveAt(i);
                        i--;
                    }
                }

                double finalresult = double.Parse(numbers[0]);
                for (int i = 0; i < operators.Count; i++)
                {
                    double nextnum = double.Parse(numbers[i + 1]);
                    if (operators[i] == '+')
                    {
                        finalresult += nextnum;
                    }
                    else if (operators[i] == '-')
                    {
                        finalresult -= nextnum;
                    }
                }

                txb_display.Text = finalresult.ToString();

            
            }

            catch (Exception)
            {
                txb_display.Text="Error";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txb_display.Text += b.Text;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DimGray;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(60,60,60);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (r>0 && b==0 ) { r-- ; g++ ; }
            else if (g>0 && r==0) { g-- ; b++ ; }
            else if (b>0 && g==0) { b-- ; r++ ; }
            label1.ForeColor = Color.FromArgb(r, g, b);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
