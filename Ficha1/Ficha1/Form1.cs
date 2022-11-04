using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Tem de selecionar uma opção");
            }
            if (comboBox1.SelectedIndex == 1)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Windows 10");
                listBox1.Items.Add("Windows 11");
                listBox1.Items.Add("Linux Ubuntu");
                listBox1.Items.Add("Office 2022");
                listBox1.Items.Add("Visual Studio Enterprise");
            }
            if (comboBox1.SelectedIndex == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Monitor");
                listBox1.Items.Add("Teclado");
                listBox1.Items.Add("Rato");
                listBox1.Items.Add("Impressora");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
            {
                MessageBox.Show("Tem de selecionar uma opção");
            }
            else
            {
                listBox2.Items.Add(listBox1.SelectedItem);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
            {
                MessageBox.Show("Tem de selecionar uma opção");
            }
            else
            {
            listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
             listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int nitem = listBox2.Items.Count;
            string nome;
            int[] preco = new int[9]{20, 30, 40, 50, 60, 70, 80, 90, 100};
            string[] nomes = new string[9] { "Monitor", "Teclado", "Rato", "Impressora", 
            "Windows 10", "Windows 11", "linux Ubuntu", "Office 2022", "Visual Studio Enterprise" };

            listBox2.Items.ToString();

            for (int i = 0; i < nitem; i++)
            {
                nome = listBox2.Items[i].ToString();

                for (int j = 0; j < preco.Length; j++)
                {

                }
            }
        }
    }
}
    
