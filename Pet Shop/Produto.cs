using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop
{
    public class Produto
    {
        private static int IDcount = 0;
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public Image Foto { get; set; }
        public int Estoque { get; set; }

        public Produto(string Nome, decimal Preco, string Descricao, Image Foto, int Estoque)
        {
            IDcount++;
            this.ID = IDcount;
            this.Nome = Nome;
            this.Preco = Preco;
            this.Descricao = Descricao;
            this.Foto = Foto;
            this.Estoque = Estoque;
        }

        public bool EstaDisponivel()
        {
            return Estoque > 0;
        }

        public void AdicionarEstoque(int quantidade)
        {
            Estoque += quantidade;
        }

        public void Comprar(int quantidade)
        {
            Estoque -= quantidade;
        }

    }
}
