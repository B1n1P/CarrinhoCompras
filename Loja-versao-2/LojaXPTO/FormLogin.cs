using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaXPTO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //encerrar o formulário
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os dados dos campos
            txtUser.ResetText();
            txtNome.Clear();
            txtPassword.Text = "";
            txtUser.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //tratamento de exceções
            try
            {
                if (txtUser.Text=="" && txtPassword.Text=="")
                {
                    throw new Exception("Digite as suas credenciais (Utilizador e Senha).");
                }

                if (txtUser.Text=="")
                {
                    throw new Exception("Digite o seu login de Utilizador.");
                }

                if (txtPassword.Text == "")
                {
                    throw new Exception("Digite a sua Senha.");
                }

                if (!txtUser.Text.Equals("admin") && !txtPassword.Text.Equals("admin"))
                {
                    throw new Exception("As suas credenciais não são válidas.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);

                txtUser.Focus();
                return;
            }

            Form1.utilizador = txtUser.Text;
            Form1 pobjForm = (Form1)this.MdiParent;
            pobjForm.MostrarLogin(txtUser.Text);
            pobjForm.MostrarMenus(1);
            pobjForm.MostrarTools(1);

            this.Close();


        }
    }
}
