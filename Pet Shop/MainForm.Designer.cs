
namespace Pet_Shop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnAddItens = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrinho = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(725, 12);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(63, 50);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Fazer Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnAddItens
            // 
            this.btnAddItens.Location = new System.Drawing.Point(93, 12);
            this.btnAddItens.Name = "btnAddItens";
            this.btnAddItens.Size = new System.Drawing.Size(75, 50);
            this.btnAddItens.TabIndex = 1;
            this.btnAddItens.Text = "Adicionar Produtos";
            this.btnAddItens.UseVisualStyleBackColor = true;
            this.btnAddItens.Click += new System.EventHandler(this.btnAddItens_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Descricao,
            this.Foto,
            this.Preco,
            this.Estoque,
            this.Carrinho});
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 535);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(88, 87);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(241, 20);
            this.txtBusca.TabIndex = 3;
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(335, 87);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 20);
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(656, 12);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(63, 50);
            this.btnLogar.TabIndex = 5;
            this.btnLogar.Text = "Fazer Login";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(725, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 50);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Carrinho";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foto.HeaderText = "";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 75;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Quantidade em Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 75;
            // 
            // Carrinho
            // 
            this.Carrinho.HeaderText = "";
            this.Carrinho.Name = "Carrinho";
            this.Carrinho.ReadOnly = true;
            this.Carrinho.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Carrinho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Carrinho.Text = "Adicionar ao Carrinho";
            this.Carrinho.UseColumnTextForButtonValue = true;
            this.Carrinho.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nome:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 682);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddItens);
            this.Controls.Add(this.btnCadastro);
            this.Name = "MainForm";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnAddItens;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewButtonColumn Carrinho;
        private System.Windows.Forms.Label label5;
    }
}