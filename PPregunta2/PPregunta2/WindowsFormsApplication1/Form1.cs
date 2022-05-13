using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool sw;bool sw1=false;
        double a,b;
        string c;
        string txt = "";
        string txt1="";
        private void clean() {
            sw = true;
            label1.Text = "";
            sw1 = false;
            label2.Text = "";
            label3.Text = "";
            txt = "";
            txt1 = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string val = ((Button)sender).Text;
            if (sw1==false) {
                if (txt == "" || sw)
                {
                    sw = false;
                    txt = val;
                }
                else
                {
                    txt = txt + val;
                }
                textBox1.Text = txt;
            }
            if (sw1) {
                if (txt1 == "" || sw)
                {
                    sw = false;
                    txt1 = val;
                }
                else
                {
                    txt1 = txt1 + val;
                }
                textBox1.Text = txt1;
            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = this.textBox1.Text;
            a = Convert.ToDouble(txt);
            b = Convert.ToDouble(txt1);

            switch (c)
            {
                case "+":
                    this.textBox1.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    this.textBox1.Text = Convert.ToString(a - b);
                    break;

                case "X":
                    this.textBox1.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.textBox1.Text = Convert.ToString(a / b);
                    break;
            }
            clean();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = txt;
            c = ((Button)sender).Text;
            sw1 = true;
            label3.Text = c;
            this.textBox1.Clear();
            this.textBox1.Focus();
        }


    }
}
