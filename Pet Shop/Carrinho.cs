using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop
{
    public partial class Carrinho : Form
    {
        public Carrinho()
        {
            InitializeComponent();
            int iterador = 0;
            int tamanhoColuna = 0;
            foreach (int i in MainForm.itensCarrinho)
            {
                var p = MainForm.produtos.AsEnumerable().First(a => a.ID == i);
                if (p.Foto.Width > tamanhoColuna) tamanhoColuna = p.Foto.Width;
                dataGridView1.Rows.Add(p.ID, p.Nome, p.Descricao, p.Foto, "R$: " + p.Preco);
                dataGridView1.Rows[iterador].Height = p.Foto.Height;
                iterador++;
            }
            dataGridView1.Columns["Foto"].Width = tamanhoColuna;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            if (e.ColumnIndex == 6)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                MainForm.produtos.AsEnumerable().First(a => row.Cells[0].Value.Equals(a.ID)).Comprar(1);
            }
            MessageBox.Show("Compra finalizada com sucesso!");
            MainForm.itensCarrinho.Clear();
            Close();
        }
    }
}
