namespace SistemaDoLeoWebService
{
    partial class FormCadastroOperador
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
            BtnID = new Button();
            TxtID = new TextBox();
            label1 = new Label();
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            tabControl1 = new TabControl();
            TabDados = new TabPage();
            ChkAdmin = new CheckBox();
            ChkInativo = new CheckBox();
            ChkVerificarSenha = new CheckBox();
            TxtSenha = new TextBox();
            label3 = new Label();
            TabTelas = new TabPage();
            ChkTabelaUsuarios = new CheckBox();
            ChkEntrada = new CheckBox();
            ChkFormaPGTO = new CheckBox();
            ChkPedido = new CheckBox();
            ChkProduto = new CheckBox();
            ChkCliente = new CheckBox();
            ChkCategoria = new CheckBox();
            ChkOperador = new CheckBox();
            TxtNome = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            TabDados.SuspendLayout();
            TabTelas.SuspendLayout();
            SuspendLayout();
            // 
            // BtnID
            // 
            BtnID.Location = new Point(175, 21);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 1;
            BtnID.TabStop = false;
            BtnID.Text = "<-";
            BtnID.UseVisualStyleBackColor = true;
            BtnID.Click += BtnID_Click;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(49, 21);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 0;
            TxtID.KeyDown += TxtID_KeyDown;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 59;
            label1.Text = "ID";
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(186, 413);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 58;
            BtnAvancar.TabStop = false;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(150, 413);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 57;
            BtnVoltar.TabStop = false;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(368, 403);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 56;
            BtnAlterar.TabStop = false;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(265, 403);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 55;
            BtnNovo.TabStop = false;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(574, 403);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 5;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(471, 403);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 4;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabDados);
            tabControl1.Controls.Add(TabTelas);
            tabControl1.Location = new Point(12, 69);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(770, 328);
            tabControl1.TabIndex = 69;
            // 
            // TabDados
            // 
            TabDados.Controls.Add(ChkAdmin);
            TabDados.Controls.Add(ChkInativo);
            TabDados.Controls.Add(ChkVerificarSenha);
            TabDados.Controls.Add(TxtSenha);
            TabDados.Controls.Add(label3);
            TabDados.Location = new Point(4, 24);
            TabDados.Name = "TabDados";
            TabDados.Padding = new Padding(3);
            TabDados.Size = new Size(762, 300);
            TabDados.TabIndex = 0;
            TabDados.Text = "Dados";
            TabDados.UseVisualStyleBackColor = true;
            // 
            // ChkAdmin
            // 
            ChkAdmin.AutoSize = true;
            ChkAdmin.Enabled = false;
            ChkAdmin.Location = new Point(31, 101);
            ChkAdmin.Name = "ChkAdmin";
            ChkAdmin.Size = new Size(102, 19);
            ChkAdmin.TabIndex = 75;
            ChkAdmin.TabStop = false;
            ChkAdmin.Text = "Administrador";
            ChkAdmin.UseVisualStyleBackColor = true;
            // 
            // ChkInativo
            // 
            ChkInativo.AutoSize = true;
            ChkInativo.Location = new Point(31, 64);
            ChkInativo.Name = "ChkInativo";
            ChkInativo.Size = new Size(62, 19);
            ChkInativo.TabIndex = 74;
            ChkInativo.TabStop = false;
            ChkInativo.Text = "Inativo";
            ChkInativo.UseVisualStyleBackColor = true;
            // 
            // ChkVerificarSenha
            // 
            ChkVerificarSenha.AutoSize = true;
            ChkVerificarSenha.Location = new Point(434, 17);
            ChkVerificarSenha.Name = "ChkVerificarSenha";
            ChkVerificarSenha.Size = new Size(38, 19);
            ChkVerificarSenha.TabIndex = 73;
            ChkVerificarSenha.TabStop = false;
            ChkVerificarSenha.Text = "👁️";
            ChkVerificarSenha.UseVisualStyleBackColor = true;
            ChkVerificarSenha.Visible = false;
            ChkVerificarSenha.CheckedChanged += ChkVerificarSenha_CheckedChanged;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(59, 15);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(369, 23);
            TxtSenha.TabIndex = 3;
            TxtSenha.UseSystemPasswordChar = true;
            TxtSenha.KeyPress += TxtSenha_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 18);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 71;
            label3.Text = "Senha";
            // 
            // TabTelas
            // 
            TabTelas.Controls.Add(ChkTabelaUsuarios);
            TabTelas.Controls.Add(ChkEntrada);
            TabTelas.Controls.Add(ChkFormaPGTO);
            TabTelas.Controls.Add(ChkPedido);
            TabTelas.Controls.Add(ChkProduto);
            TabTelas.Controls.Add(ChkCliente);
            TabTelas.Controls.Add(ChkCategoria);
            TabTelas.Controls.Add(ChkOperador);
            TabTelas.Location = new Point(4, 24);
            TabTelas.Name = "TabTelas";
            TabTelas.Padding = new Padding(3);
            TabTelas.Size = new Size(762, 300);
            TabTelas.TabIndex = 1;
            TabTelas.Text = "Telas";
            TabTelas.UseVisualStyleBackColor = true;
            // 
            // ChkTabelaUsuarios
            // 
            ChkTabelaUsuarios.AutoSize = true;
            ChkTabelaUsuarios.Location = new Point(10, 144);
            ChkTabelaUsuarios.Name = "ChkTabelaUsuarios";
            ChkTabelaUsuarios.Size = new Size(123, 19);
            ChkTabelaUsuarios.TabIndex = 8;
            ChkTabelaUsuarios.TabStop = false;
            ChkTabelaUsuarios.Text = "Tabela de Usuários";
            ChkTabelaUsuarios.UseVisualStyleBackColor = true;
            // 
            // ChkEntrada
            // 
            ChkEntrada.AutoSize = true;
            ChkEntrada.Location = new Point(10, 194);
            ChkEntrada.Name = "ChkEntrada";
            ChkEntrada.Size = new Size(66, 19);
            ChkEntrada.TabIndex = 6;
            ChkEntrada.TabStop = false;
            ChkEntrada.Text = "Entrada";
            ChkEntrada.UseVisualStyleBackColor = true;
            // 
            // ChkFormaPGTO
            // 
            ChkFormaPGTO.AutoSize = true;
            ChkFormaPGTO.Location = new Point(10, 119);
            ChkFormaPGTO.Name = "ChkFormaPGTO";
            ChkFormaPGTO.Size = new Size(142, 19);
            ChkFormaPGTO.TabIndex = 5;
            ChkFormaPGTO.TabStop = false;
            ChkFormaPGTO.Text = "Cadastro Forma PGTO";
            ChkFormaPGTO.UseVisualStyleBackColor = true;
            // 
            // ChkPedido
            // 
            ChkPedido.AutoSize = true;
            ChkPedido.Location = new Point(10, 169);
            ChkPedido.Name = "ChkPedido";
            ChkPedido.Size = new Size(68, 19);
            ChkPedido.TabIndex = 4;
            ChkPedido.TabStop = false;
            ChkPedido.Text = "Pedidos";
            ChkPedido.UseVisualStyleBackColor = true;
            // 
            // ChkProduto
            // 
            ChkProduto.AutoSize = true;
            ChkProduto.Location = new Point(10, 94);
            ChkProduto.Name = "ChkProduto";
            ChkProduto.Size = new Size(119, 19);
            ChkProduto.TabIndex = 3;
            ChkProduto.TabStop = false;
            ChkProduto.Text = "Cadastro Produto";
            ChkProduto.UseVisualStyleBackColor = true;
            // 
            // ChkCliente
            // 
            ChkCliente.AutoSize = true;
            ChkCliente.Location = new Point(10, 70);
            ChkCliente.Name = "ChkCliente";
            ChkCliente.Size = new Size(113, 19);
            ChkCliente.TabIndex = 2;
            ChkCliente.TabStop = false;
            ChkCliente.Text = "Cadastro Cliente";
            ChkCliente.UseVisualStyleBackColor = true;
            // 
            // ChkCategoria
            // 
            ChkCategoria.AutoSize = true;
            ChkCategoria.Location = new Point(10, 45);
            ChkCategoria.Name = "ChkCategoria";
            ChkCategoria.Size = new Size(127, 19);
            ChkCategoria.TabIndex = 1;
            ChkCategoria.TabStop = false;
            ChkCategoria.Text = "Cadastro Categoria";
            ChkCategoria.UseVisualStyleBackColor = true;
            // 
            // ChkOperador
            // 
            ChkOperador.AutoSize = true;
            ChkOperador.Location = new Point(10, 21);
            ChkOperador.Name = "ChkOperador";
            ChkOperador.Size = new Size(126, 19);
            ChkOperador.TabIndex = 0;
            ChkOperador.TabStop = false;
            ChkOperador.Text = "Cadastro Operador";
            ChkOperador.UseVisualStyleBackColor = true;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(312, 20);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(369, 23);
            TxtNome.TabIndex = 2;
            TxtNome.KeyPress += TxtNome_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 23);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 73;
            label2.Text = "Nome";
            // 
            // FormCadastroOperador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtNome);
            Controls.Add(label2);
            Controls.Add(tabControl1);
            Controls.Add(BtnID);
            Controls.Add(TxtID);
            Controls.Add(label1);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            KeyPreview = true;
            Name = "FormCadastroOperador";
            Text = "FormCadastroOperador";
            FormClosing += FormCadastroOperador_FormClosing;
            Load += FormCadastroOperador_Load;
            KeyDown += FormCadastroOperador_KeyDown;
            KeyPress += FormCadastroOperador_KeyPress;
            tabControl1.ResumeLayout(false);
            TabDados.ResumeLayout(false);
            TabDados.PerformLayout();
            TabTelas.ResumeLayout(false);
            TabTelas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnID;
        private TextBox TxtID;
        private Label label1;
        private Button BtnAvancar;
        private Button BtnVoltar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private TabControl tabControl1;
        private TabPage TabDados;
        private CheckBox ChkAdmin;
        private CheckBox ChkInativo;
        private CheckBox ChkVerificarSenha;
        private TextBox TxtSenha;
        private Label label3;
        private TabPage TabTelas;
        private CheckBox ChkOperador;
        private TextBox TxtNome;
        private Label label2;
        private CheckBox ChkProduto;
        private CheckBox ChkCliente;
        private CheckBox ChkCategoria;
        private CheckBox ChkFormaPGTO;
        private CheckBox ChkEntrada;
        private CheckBox ChkTabelaUsuarios;
        private CheckBox checkBox5;
        private CheckBox ChkPedido;
    }
}