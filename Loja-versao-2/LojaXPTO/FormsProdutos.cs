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
    public partial class FormsProdutos : Form
    {
        private const int Max_Produtos = 100;
        private readonly Produtos[] produtos;
        private int num_produtos;

        
        public FormsProdutos()
        {
            produtos = new Produtos[Max_Produtos];
            num_produtos = 0;

            InitializeComponent();
            cbCategoria.Items.Clear();
            cbCategoria.Items.Add("Software");
            cbCategoria.Items.Add("Hardware");
            cbCategoria.SelectedIndex = -1;
        }

        private void limpar()
        {
            txtCodigo.ResetText();
            txtProduto.ResetText();
            txtPreco.ResetText();
            cbCategoria.SelectedIndex = -1;
            txtCodigo.Focus();
        }

        private void FormsProdutos_Load(object sender, EventArgs e)
        {
            statusMsg.Text = "";
            limpar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void AdicionaProduto(Produtos p )
        {
            if (num_produtos < Max_Produtos)
            {
                produtos[num_produtos] = p;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            int x;
            double y;
            try
            {
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um Código Numérico.");
                }
                
                else if(Convert.ToInt32(txtCodigo.Text)< 99)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um´código com 3 ou mais dígitos");
                }

                if (txtProduto.Text.Equals("") || (txtProduto.Text.Length) < 3 || txtProduto.Text.Length > 50)
                {
                    txtProduto.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 caracteres)");
                }

                if (cbCategoria.SelectedIndex==-1)
                {
                    throw new Exception("Escolha a categoria do Produto");
                }

                if (!double.TryParse(txtCodigo.Text, out y))
                {
                    txtPreco.Focus();
                    throw new Exception("Insira um preço Numérico.");
                }
                else if (Convert.ToDouble(txtPreco.Text) <= 0)
                {
                    txtPreco.Focus();
                    throw new Exception("Insira um´preço superior a 0");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,"Aviso",MessageBoxButtons.OK , MessageBoxIcon.Warning);

                return;
            }

            string Linha = txtCodigo.Text.ToString() + " | " + txtProduto.Text + " | " + cbCategoria.SelectedItem + " | " + txtPreco.Text.ToString();

            

            statusMsg.Text = "Adicinado um novo produto";
            limpar();
        }

        public int posLista = -1;

        private void lstProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedIndex != -1)
            {
                posLista = lstProdutos.SelectedIndex;

                string[] campos = lstProdutos.SelectedItem.ToString().Split('|');

                txtCodigo.Text = campos[0].Trim();
                txtProduto.Text = campos[1].Trim();
                switch (campos[2].Trim())
                {
                    case "Hardware": cbCategoria.SelectedIndex = 0; break;
                    case "Sofware": cbCategoria.SelectedIndex = 1; break;
                    default: cbCategoria.SelectedIndex = -1 ; break;
                }
                txtPreco.Text = campos[3].Trim();
                txtCodigo.Focus();

            }
        }


        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int x;
            double y;
            try
            {
                if (!int.TryParse(txtCodigo.Text, out x))
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um Código Numérico.");
                }

                else if (Convert.ToInt32(txtCodigo.Text) < 99)
                {
                    txtCodigo.Focus();
                    throw new Exception("Insira um");
                }

                if (txtProduto.Text.Equals("") || (txtProduto.Text.Length) < 3 || txtProduto.Text.Length > 50)
                {
                    txtProduto.Focus();
                    throw new Exception("Insira a descrição do produto (3 a 50 caracteres)");
                }

                if (!double.TryParse(txtCodigo.Text, out y))
                {
                    txtPreco.Focus();
                    throw new Exception("Insira um preço Numérico.");
                }
                else if (Convert.ToDouble(txtPreco.Text) <= 0)
                {
                    txtPreco.Focus();
                    throw new Exception("Insira um´preço superior a 0");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            string Linha = txtCodigo.Text.ToString() + " | " + txtProduto.Text + " | " + cbCategoria.SelectedItem + " | " + txtPreco.Text.ToString();

            lstProdutos.Items.RemoveAt(posLista);
            lstProdutos.Items.Insert(posLista , Linha);
            posLista = -1;

            statusMsg.Text = "Atualizado com sucesso!";
            limpar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (posLista != -1)
            {
                lstProdutos.Items.RemoveAt(posLista);
                posLista = -1;
                statusMsg.Text = "Eliminado um produto";
                limpar();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach(var item in lstProdutos.Items)
            {
                string[] campos = item.ToString().Split('|');

                int codigo = Convert.ToInt32(campos[0].Trim());

                string nomeProduto = campos[1].Trim();
                int categoria = 1;
                if (campos[2].Trim().Equals("Software"))
                {
                    categoria = 2;
                }
                double preco = Convert.ToDouble(campos[3]);

                AdicionaProduto(new Produtos(codigo, nomeProduto, categoria, preco));
            }
            this.Close();
        }
    }
}
