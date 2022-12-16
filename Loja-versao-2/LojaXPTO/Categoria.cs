using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaXPTO
{
    public class Categoria
    {
        private int codigo;
        private string categoria;
        private string zona;
        private int fila;
        private int parteleira;

        public Categoria (int codigo, string categoria, string zona, int fila, int parteleira)
        {
            this.codigo = codigo;
            this.categoria = categoria;
            this.zona = zona;
            this.fila = fila;
            this.parteleira = parteleira;
        }

        public Categoria()
        {
            this.codigo = -1;
            this.categoria = string.Empty;
            this.zona = string.Empty;
            this.fila = 0;
            this.parteleira = 0;
        }

        public int getCodigo() { return codigo; }
        public string getCategoria() { return categoria; }
        public string getZona() { return zona; }
        public int getFila() { return fila; }
        public int getParteleira() { return parteleira; }

        public void setCodigo(int codigo) { this.codigo = codigo; }
        public void setCategoria(string categoria) { this.categoria = categoria; }
        public void setZona(string zona) { this.zona = zona; }
        public void setFila(int fila) { this.fila = fila; }
        public void setParteleira(int parteleira) { this.parteleira = parteleira; }


    }
}
