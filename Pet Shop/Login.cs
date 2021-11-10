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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainForm.users.AsEnumerable().Any(p => p["Login"].ToString() == txtLogin.Text && p["Senha"].ToString() == txtSenha.Text))
            {
                MainForm.UsuarioLogado = MainForm.users.AsEnumerable().First(p => p["Login"].ToString() == txtLogin.Text && p["Senha"].ToString() == txtSenha.Text);
                MessageBox.Show("Bem vindo(a) " + MainForm.UsuarioLogado["Nome"] + "!");
                Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }


        }
    }
}
