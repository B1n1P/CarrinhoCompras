using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        int creditos = 10;
        int ticks;
        int Ticks;
        int numero;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonSpin.Visible = true;
            buttonExit.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            labelNumCreditos.Visible = true;
            labelCreditos.Visible = true;
            pictureBox1.Visible = false;
            buttonStart.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Tem a certeza?", "Confirmar",
                MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonSpin_Click(object sender, EventArgs e)
        {

            if (creditos == 0)
            {
                DialogResult dialog;
                dialog = MessageBox.Show("Nao Podes usar mais o spin", "ERRO",
                MessageBoxButtons.OK);
                buttonSpin.Enabled = false;
                return;
             }
            creditos--;
            labelNumCreditos.Text = creditos.ToString();





            pictureBox2.Visible = false;
            Random rnd = new Random();

            label1.Text = (rnd.Next(1, 10)).ToString();
            label2.Text = (rnd.Next(1, 10)).ToString();
            label3.Text = (rnd.Next(1, 10)).ToString();

            if (Convert.ToInt32(label1.Text) == 7 ||
               Convert.ToInt32(label2.Text) == 7 ||
               Convert.ToInt32(label3.Text) == 7)
            {
                creditos= creditos +1;
                pictureBox2.Visible = true;
                MessageBox.Show("Voce é um vencedor!!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
                //SystemSounds.Beep.Play();

            }
        


            private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            this.Text = ticks.ToString();
            Random rnd = new Random();
            numero = rnd.Next(1, 10);
            label1.Text = numero.ToString();
            if (ticks == 10)
            {
                this.Text = ticks.ToString();
                numero = rnd.Next(1, 10);
                label1.Text = numero.ToString();
                ticks = 0;
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Ticks++;
            label5.Text = Ticks.ToString();
            Random rnd = new Random();
            numero = rnd.Next(1, 10);
            label2.Text = numero.ToString();
            if (Ticks == 10)
            {
                label5.Text = ticks.ToString();
                numero = rnd.Next(1, 10);
                label2.Text = numero.ToString();
                Ticks = 0;
                timer2.Stop();
            }
        }
    }
}