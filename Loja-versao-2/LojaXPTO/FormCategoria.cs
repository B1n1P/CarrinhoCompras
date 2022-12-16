using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LojaXPTO
{
    public partial class FormCategoria : Form
    {

        private const int Max_Categoria = 100;
        private readonly Produtos[] Categoria;
        private int num_Categoria;

        public FormCategoria()
        {
            Categoria = new Produtos[Max_Categoria];
            num_Categoria = 0;

            InitializeComponent();
        }
        private void limpar()
        {
            txtCategoria.ResetText();
            txtCodigo.ResetText();
            txtFila.ResetText();
            txtPrateleira.ResetText();
            txtZona.ResetText();
            txtCodigo.Focus();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;

            grelha.ColumnCount = 5;
            grelha.Columns[0].Name = "Codigo";
            grelha.Columns[1].Name = "Categoria";
            grelha.Columns[1].Width = 250;
            grelha.Columns[2].Name = "Zona";
            grelha.Columns[3].Name = "Fila";
            grelha.Columns[4].Name = "Prateleira";

            grelha.Rows.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
                int x;
                try
                {
                    //verificar o código da categoria
                    if (!int.TryParse(txtCodigo.Text, out x))
                    {
                        txtCodigo.Focus();
                        throw new Exception("Insira um código numérico");
                    }
                    else if (Convert.ToInt32(txtCodigo.Text) <= 1)
                    {
                        txtCodigo.Focus();
                        throw new Exception("Insira um código superior a 0");
                    }
                    //verificar o nome da categoria
                    if (txtCategoria.Text.Equals(" ") ||
                    /*(txtCategoria.Text.Length < 3)*/ txtCategoria.Text.Length > 50)
                    {
                        txtCategoria.Focus();
                        throw new Exception("Insira a descrição da categoria (até 50 carácters)");
                    }

                    if (txtZona.Text.Equals("") ||
                    txtZona.Text.Length < 1 || !System.Text.RegularExpressions.Regex.IsMatch(txtZona.Text, "^[a-zA-Z ]"))
                    {
                        txtZona.Focus();
                        throw new Exception("Escolha a zona (A a Z)");

                    }
                    //verificar fila
                    if (!int.TryParse(txtFila.Text, out x))
                    {
                        txtFila.Focus();
                        throw new Exception("Insira a Fila");
                    }
                    else if (Convert.ToInt32(txtFila.Text) <= 1 || Convert.ToInt32(txtFila.Text) > 100)
                    {
                        txtFila.Focus();
                        throw new Exception("Insira uma fila de 1 a 100");
                    }

                    //verificar prateleiras
                    if (!int.TryParse(txtPrateleira.Text, out x))
                    {
                        txtPrateleira.Focus();
                        throw new Exception("Insira um código numérico");
                    }
                    else if (Convert.ToInt32(txtPrateleira.Text) <= 1 || Convert.ToInt32(txtPrateleira.Text) > 10)
                    {
                        txtPrateleira.Focus();
                        throw new Exception("Insira uma prateleira de 1 a 10");
                    }

                    //fim das verificações

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


            grelha.Rows.Add(txtCodigo.Text, txtCategoria.Text, txtFila.Text, txtZona.Text, txtPrateleira.Text);

                statusMsg.Text = "Adicinado um novo produto";
            limpar();
        }

        private int posLista = -1;
        private void grelha_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            posLista = grelha.CurrentCell.RowIndex;
            if (posLista != -1)
            {
                txtCodigo.Text = grelha.Rows[posLista].Cells[0].Value.ToString();
                txtCategoria.Text = grelha.Rows[posLista].Cells[1].Value.ToString();
                txtFila.Text = grelha.Rows[posLista].Cells[2].Value.ToString();
                txtZona.Text = grelha.Rows[posLista].Cells[3].Value.ToString();
                txtPrateleira.Text = grelha.Rows[posLista].Cells[4].Value.ToString();
                txtCodigo.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (posLista != -1)
            {
                grelha.Rows.RemoveAt(posLista);
                posLista = -1;
                statusMsg.Text = "Eliminado um produto";
                limpar();
            }
        }
    }
}
