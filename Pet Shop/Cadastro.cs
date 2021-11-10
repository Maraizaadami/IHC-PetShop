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
    public partial class Cadastro : Form
    {


        private bool LimparCPF = true;
        private bool LimparRG = true;
        private bool LimparCEP = true;



        public Cadastro()
        {
            InitializeComponent();
            PopularEstados();
            checkBox1.Checked = true;
        }

        private void PopularEstados()
        {
            txtEstado.Items.Add("AC");
            txtEstado.Items.Add("AL");
            txtEstado.Items.Add("AP");
            txtEstado.Items.Add("AM");
            txtEstado.Items.Add("BA");
            txtEstado.Items.Add("CE");
            txtEstado.Items.Add("DF");
            txtEstado.Items.Add("ES");
            txtEstado.Items.Add("GO");
            txtEstado.Items.Add("MA");
            txtEstado.Items.Add("MT");
            txtEstado.Items.Add("MS");
            txtEstado.Items.Add("MG");
            txtEstado.Items.Add("PA");
            txtEstado.Items.Add("PB");
            txtEstado.Items.Add("PR");
            txtEstado.Items.Add("PE");
            txtEstado.Items.Add("PI");
            txtEstado.Items.Add("RJ");
            txtEstado.Items.Add("RN");
            txtEstado.Items.Add("RS");
            txtEstado.Items.Add("RO");
            txtEstado.Items.Add("RR");
            txtEstado.Items.Add("SC");
            txtEstado.Items.Add("SP");
            txtEstado.Items.Add("SE");
            txtEstado.Items.Add("TO");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LimparCEP) txtCEP.Text = "";
            if (LimparCPF) txtCEP.Text = "";
            if (LimparRG) txtCEP.Text = "";

            string msg = "";

            if (txtLogin.Text == "" || txtSenha.Text == "" || txtConfirmarSenha.Text == "" || txtNome.Text == "" || txtEmail.Text == "" || txtCPF.Text == "" || txtRG.Text == "" ||
                 txtEndereco.Text == "" || txtNumero.Text == "" || txtComplemento.Text == "" || txtCEP.Text == "" || txtEstado.Text == "" || txtBairro.Text == "" || txtCidade.Text == "")
            {
                msg += "Todos os campos precisam estar preenchidos; ";
            }
            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                msg += "Senhas precisam ser iguais; ";
            }
            if (MainForm.users.AsEnumerable().Any(r => r["login"].ToString() == txtLogin.Text))
            {
                msg += "Usuário já cadastrado; ";
            }
            if (MainForm.users.AsEnumerable().Any(r => r["Email"].ToString() == txtEmail.Text))
            {
                msg += "E-mail já cadastrado; ";
            }
            if (msg != "")
            {
                MessageBox.Show(msg);
                return;
            }

            DataRow workRow = MainForm.users.NewRow();
            workRow["Login"] = txtLogin.Text;
            workRow["Senha"] = txtSenha.Text;
            workRow["Nome"] = txtNome.Text;
            workRow["Email"] = txtEmail.Text;
            workRow["DTnascimento"] = dateTimePicker1.Value;
            workRow["CPF"] = txtCPF.Text;
            workRow["RG"] = txtRG.Text;
            workRow["Endereco"] = txtEndereco.Text;
            workRow["Numero"] = txtNumero.Text;
            workRow["Complemento"] = txtComplemento.Text;
            workRow["CEP"] = txtCEP.Text;
            workRow["Estado"] = txtEstado.Text;
            workRow["Bairro"] = txtBairro.Text;
            workRow["Cidade"] = txtCidade.Text;
            workRow["ADM"] = checkBox1.Checked;

            MainForm.users.Rows.Add(workRow);
            MessageBox.Show("Usuário criado com sucesso!");
            Close();
        }


        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (LimparCPF)
            {
                if (txtCPF.Text.Trim() != "" || txtCPF.Text != null)

                {

                    txtCPF.Text = "";

                }
                LimparCPF = false;
            }
        }

        private void txtRG_Enter(object sender, EventArgs e)
        {

            if (LimparRG)
            {
                if (txtRG.Text.Trim() != "" || txtRG.Text != null)

                {

                    txtRG.Text = "";

                }
                LimparRG = false;
            }
        }

        private void txtCEP_Enter(object sender, EventArgs e)
        {

            if (LimparCEP)
            {
                if (txtCEP.Text.Trim() != "" || txtCEP.Text != null)

                {

                    txtCEP.Text = "";

                }
                LimparCEP = false;
            }
        }
    }
}
