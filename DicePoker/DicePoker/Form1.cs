using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicePoker
{
    public partial class chkDados : Form
    {
        public chkDados()
        {
            InitializeComponent();
        }

        private const int cRolarTempo = 5;

        private const string ctituloBarra = "Dice Poker";

        private bool cListaDados = false;

        private int creditos = 20;

        private int nrJogadas;

        private int contador;
        private int dado1;
        private int dado2;
        private int dado3;
        private int dado4;
        private int dado5;
        private int dado6;

        private void chkDados_Load(object sender, EventArgs e)
        {
            pbDado1.Image = imageList1.Images[0];
            pbDado2.Image = imageList1.Images[0];
            pbDado3.Image = imageList1.Images[0];
            pbDado4.Image = imageList1.Images[0];
            pbDado5.Image = imageList1.Images[0];

            txtOutput.Text = "Bem vindo! \n Está pronto para jogar?" + "\nTem?" + creditos.ToString() + "creditos.";
        }

        private void btnRolar_Click(object sender, EventArgs e)
        {
            if (nrJogadas == 2)
            {
                btnRolar.Text = "Rolar os Dados";
                nrJogadas = 0;
            }
            if  (btnRolar.Text == "Rolar os Dados")
            {
                cListaDados = false;
                nrJogadas += 1;
            }
            else
            {
                cListaDados = true;
                nrJogadas += 1;
            }
        }
    }
}
