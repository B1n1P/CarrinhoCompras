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
    public partial class FormListarProdutos : Form
    {
        private Produtos[] produtos;
        private int num_produtos = 0;

        public FormListarProdutos()
        {
            InitializeComponent();
        }

        public FormListarProdutos(Produtos[] produtos, int num_produtos) { 

            this.produtos = produtos;
            this.num_produtos = num_produtos;
            InitializeComponent();
        }

        private void FormListarProdutos_Load(object sender, EventArgs e)
        {
            grelha.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grelha.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grelha.AllowUserToAddRows = false;
            grelha.AllowUserToDeleteRows = false;
            grelha.AllowUserToResizeColumns = false;

            grelha.ColumnCount = 4;
            grelha.Columns[0].Name = "Codigo";
            grelha.Columns[1].Name = "Designacao";
            grelha.Columns[2].Name = "Categoria";
            grelha.Columns[3].Name = "Preco";

            grelha.Rows.Clear();

            for (int i = 0; i < num_produtos; i++)
            {
                grelha.Rows.Add(
                    this.produtos[i].getCodigo().ToString(),
                    this.produtos[i].getnomeProduto(),
                    this.produtos[i].Equals(1) ? "Hardware" : "Software",
                    this.produtos[i].getPreco().ToString()
                    );
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
