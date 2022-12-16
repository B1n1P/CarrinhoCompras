using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaXPTO
{
    public class Produtos
    {
        private int codigo;
        private string nomeProduto;
        private int categoria;
        private double preco;

        public Produtos (int codigo, string nomeProduto, int categoria, double preco)
        {
            this.codigo = codigo;
            this.nomeProduto = nomeProduto;
            this.categoria = categoria;
            this.preco = preco;
        }

        public int getCodigo()
        {
            return codigo;
        }
        public string getnomeProduto()
        {
            return nomeProduto;
        }
        public int getCategoria()
        {
            return categoria;
        }
        public double getPreco()
        {
            return preco;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public void setnomeProduto(string nomeProduto)
        {
            this.nomeProduto = nomeProduto; 
        }
        public void setCategoria(int categoria)
        {
            this.categoria = categoria;
        }
        public void setPreco(int preco)
        {
            this.preco = preco;
        }
    }
}
