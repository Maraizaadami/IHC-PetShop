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
    public partial class MainForm : Form
    {
        public static DataTable users = new DataTable();
        
        public static List<Produto> produtos = new List<Produto>();

        public static DataRow UsuarioLogado = null;

        public static List<int> itensCarrinho = new List<int>();

        public MainForm()
        {
            InitializeComponent();

            users.Columns.Add("Login", typeof(string));
            users.Columns.Add("Senha", typeof(string));
            users.Columns.Add("Nome", typeof(string));
            users.Columns.Add("Email", typeof(string));
            users.Columns.Add("DTnascimento", typeof(DateTime));
            users.Columns.Add("CPF", typeof(string));
            users.Columns.Add("RG", typeof(string));
            users.Columns.Add("Endereco", typeof(string));
            users.Columns.Add("Numero", typeof(string));
            users.Columns.Add("Complemento", typeof(string));
            users.Columns.Add("CEP", typeof(string));
            users.Columns.Add("Estado", typeof(string));
            users.Columns.Add("Bairro", typeof(string));
            users.Columns.Add("Cidade", typeof(string));
            users.Columns.Add("ADM", typeof(bool));
            VerificarAcessos();
            prepararDT(produtos);
        }

        private void prepararDT(List<Produto> lista)
        {
            int iterador = 0;
            int tamanhoColuna = 0;
            dataGridView1.Rows.Clear();
            foreach(Produto p in lista)
            {
                if (p.EstaDisponivel())
                {
                    if (p.Foto.Width > tamanhoColuna) tamanhoColuna = p.Foto.Width;
                    dataGridView1.Rows.Add(p.ID, p.Nome, p.Descricao, p.Foto, "R$: " + p.Preco, p.Estoque);
                    dataGridView1.Rows[iterador].Height = p.Foto.Height;
                    iterador++;
                }
            }
            dataGridView1.Columns["Foto"].Width = tamanhoColuna;
        }

        private void VerificarAcessos()
        {
            if(UsuarioLogado == null)
            {
                btnAddItens.Visible = 
                btnSair.Visible = 
                    false;
                btnLogar.Visible =
                btnCadastro.Visible =
                    true;
            }
            else
            {
                btnSair.Visible =
                    true;
                btnLogar.Visible =
                btnCadastro.Visible =
                    false;

                btnAddItens.Visible = UsuarioLogado["ADM"].ToString() == "True"; 
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro form = new Cadastro();
            form.ShowDialog();
        }

        private void btnAddItens_Click(object sender, EventArgs e)
        {
            AddItem form = new AddItem();
            form.ShowDialog();
            prepararDT(produtos);
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            List<Produto> t = produtos.AsEnumerable().Where(r => r.Nome.Contains(txtBusca.Text.Trim())).ToList();
            prepararDT(t);
            //dataGridView1.Columns["ID"].Visible = false;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.ShowDialog();
            VerificarAcessos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Logoff", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UsuarioLogado = null;
                VerificarAcessos();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            if (e.ColumnIndex == 6)
            {
                itensCarrinho.Add(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carrinho form = new Carrinho();
            form.ShowDialog();
            prepararDT(produtos);
        }

    }
}
