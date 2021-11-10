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
    public partial class AddItem : Form
    {
        private Image foto = null;
        public AddItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Selecionar aquivo de imagem";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                foto = Image.FromFile(fileOpen.FileName);
            }
            fileOpen.Dispose();
            if (foto.Width > 300 || foto.Height > 300)
            {
                MessageBox.Show("A resolução máxima da foto é de 300x300");
                return;
            }
            if (foto != null)
            {
                button2.BackColor = Color.LimeGreen;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal outPreco;
            int outEstoque;
            string msg = "";
            if (!decimal.TryParse(txtPreco.Text, out outPreco))
            {
                msg += "Preço deve estar no formato decimal; ";
            }
            if (!int.TryParse(txtEstoque.Text, out outEstoque))
            {
                msg += "Estoque deve ser um número inteiro; ";
            }
            if(button2.BackColor == Color.Red)
            {
                msg += "Deve-se selecionar uma imagem.";
            }
            if(msg != "")
            {
                MessageBox.Show(msg);
                return;
            }

            MainForm.produtos.Add(new Produto(txtNome.Text, outPreco, txtDesc.Text, foto, outEstoque));
            Close();
        }
    }
}
