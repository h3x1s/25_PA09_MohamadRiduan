using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_PA09_Mohamad_Riduan
{
    public partial class Form1 : Form
    {
        
        private double currencyrate;
        public Form1()
        {
            InitializeComponent();
            currencyrate = 0;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currencyrate = 0.74;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            currencyrate = 81.97;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double result;
            if(double.TryParse(textBox1.Text, out result))
            {
                textBox2.Text = (result * currencyrate).ToString();
            }
            if(String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid amount!");
                return;
            }
            if(System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[-,+,/,=]"))
            {
                MessageBox.Show("Please enter a valid amount!");
                return;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
