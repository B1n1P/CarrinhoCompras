using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CongtroloTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelMensagem.Visible = false;
            TextBoxNome.Focus();

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            LabelMensagem.Visible = true;
            LabelMensagem.Text = "";

            if (string.IsNullOrEmpty(TextBoxNome.Text))
            {
                LabelMensagem.Visible = true;
                LabelMensagem.Text = "Insira o seu Nome.";
            }
            else
            {
                if (string.IsNullOrEmpty(TextBoxUtilizador.Text))
                {
                    LabelMensagem.Visible = true;
                    LabelMensagem.Text = "Insira o Utilizador.";
                }
                 else if (string.IsNullOrEmpty(TextBoxSenha.Text))
                 {
                    LabelMensagem.Visible = true;
                    LabelMensagem.Text = "Insira o seu Password.";
                }
                else
                {
                    //verefica senha
                    if (TextBoxSenha.Text.Equals("Bananas"))
                    {
                        MessageBox.Show("Login com sucesso.", "Aviso ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }else
                    {
                        TextBoxNome.Clear();
                        TextBoxUtilizador.Clear();
                        TextBoxSenha.Clear();
                    }
                }
                
            }
        }
    }
}
