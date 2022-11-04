using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        public string operacao = "";
        double acumula = 0, resultado = 0;
         

        private void button3_Click(object sender, EventArgs e)
        {
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "7";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "8";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "0";
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += ",";
        }

        private void buttonMais_Click(object sender, EventArgs e)
        {
           if (label1.Text != "")
            {
                acumula = Convert.ToDouble(label1.Text);
                label1.Text = "0";
                operacao = "+";
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
             
}

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                acumula += Convert.ToDouble(label1.Text);
                label1.Text = "0";
                operacao = "-";
            }
        }

        private void buttonVezes_Click(object sender, EventArgs e)
        {
            if(label1.Text != "0")
            {
                acumula += Convert.ToDouble(label1.Text);
                label1.Text = "0";
                operacao = "*";
            }
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0")
            {
                acumula += Convert.ToDouble(label1.Text);
                label1.Text = "0";
                operacao = "/";
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            acumula = 0;
            label1.Text = "0";
        }

        private void ButtonMaisMenos(object sender, EventArgs e)
        {
            label1.Text = (Convert.ToDouble(label1.Text) * (-1)).ToString();
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White;
        }

        private void button7_MouseHouver(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonIgual_Click_1(object sender, EventArgs e)
        {
          switch(operacao)
            {
                case "+":
                    resultado = acumula + Convert.ToDouble(label1.Text);
                    label1.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = acumula - Convert.ToDouble(label1.Text);
                    label1.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = acumula / Convert.ToDouble(label1.Text);
                    label1.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = acumula * Convert.ToDouble(label1.Text);
                    label1.Text = resultado.ToString();
                    break;

                default: label1.Text = "3";
                    break;
            }
        }
    }

}
