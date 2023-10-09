namespace SistemaDoLeoWebService
{
    partial class FormCadastroProdutos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ChkBoxInativo = new CheckBox();
            TxtID = new TextBox();
            TxtNome = new TextBox();
            TxtValor = new TextBox();
            TxtCusto = new TextBox();
            CBoxCategoria = new ComboBox();
            BtnID = new Button();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            BtnNovo = new Button();
            BtnAlterar = new Button();
            BtnVoltar = new Button();
            BtnAvancar = new Button();
            Estoque = new GroupBox();
            TxtEstoque = new TextBox();
            Estoque.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 29);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 107);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 146);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 183);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Custo";
            // 
            // ChkBoxInativo
            // 
            ChkBoxInativo.AutoSize = true;
            ChkBoxInativo.Location = new Point(257, 29);
            ChkBoxInativo.Name = "ChkBoxInativo";
            ChkBoxInativo.Size = new Size(62, 19);
            ChkBoxInativo.TabIndex = 99;
            ChkBoxInativo.TabStop = false;
            ChkBoxInativo.Text = "Inativo";
            ChkBoxInativo.UseVisualStyleBackColor = true;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(78, 26);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 0;
            TxtID.KeyDown += TxtID_KeyDown;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(78, 69);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(369, 23);
            TxtNome.TabIndex = 2;
            TxtNome.KeyPress += TxtNome_KeyPress;
            // 
            // TxtValor
            // 
            TxtValor.Location = new Point(78, 143);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(100, 23);
            TxtValor.TabIndex = 4;
            TxtValor.KeyPress += TxtValor_KeyPress;
            TxtValor.Leave += TxtValor_Leave;
            // 
            // TxtCusto
            // 
            TxtCusto.Location = new Point(78, 180);
            TxtCusto.Name = "TxtCusto";
            TxtCusto.Size = new Size(100, 23);
            TxtCusto.TabIndex = 5;
            TxtCusto.KeyPress += TxtCusto_KeyPress;
            TxtCusto.Leave += TxtCusto_Leave;
            // 
            // CBoxCategoria
            // 
            CBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxCategoria.FormattingEnabled = true;
            CBoxCategoria.Location = new Point(78, 104);
            CBoxCategoria.Name = "CBoxCategoria";
            CBoxCategoria.Size = new Size(257, 23);
            CBoxCategoria.TabIndex = 3;
            CBoxCategoria.KeyPress += CBoxCategoria_KeyPress;
            // 
            // BtnID
            // 
            BtnID.Location = new Point(191, 26);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 1;
            BtnID.Text = "<-";
            BtnID.UseVisualStyleBackColor = true;
            BtnID.Click += BtnID_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(358, 238);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 6;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(461, 238);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(152, 238);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 17;
            BtnNovo.TabStop = false;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(255, 238);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 18;
            BtnAlterar.TabStop = false;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(49, 243);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 19;
            BtnVoltar.TabStop = false;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(85, 243);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 20;
            BtnAvancar.TabStop = false;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // Estoque
            // 
            Estoque.Controls.Add(TxtEstoque);
            Estoque.Location = new Point(422, 120);
            Estoque.Name = "Estoque";
            Estoque.Size = new Size(116, 83);
            Estoque.TabIndex = 21;
            Estoque.TabStop = false;
            Estoque.Text = "Estoque";
            // 
            // TxtEstoque
            // 
            TxtEstoque.Enabled = false;
            TxtEstoque.Location = new Point(27, 33);
            TxtEstoque.Name = "TxtEstoque";
            TxtEstoque.Size = new Size(64, 23);
            TxtEstoque.TabIndex = 13;
            TxtEstoque.TabStop = false;
            TxtEstoque.TextChanged += TxtEstoque_TextChanged;
            // 
            // FormCadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 301);
            Controls.Add(Estoque);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnID);
            Controls.Add(CBoxCategoria);
            Controls.Add(TxtCusto);
            Controls.Add(TxtValor);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Controls.Add(ChkBoxInativo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProdutos";
            Text = "FormCadastroProdutos";
            Load += FormCadastroProdutos_Load;
            KeyDown += FormCadastroProdutos_KeyDown;
            KeyPress += FormCadastroProdutos_KeyPress;
            Estoque.ResumeLayout(false);
            Estoque.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox ChkBoxInativo;
        private TextBox TxtID;
        private TextBox TxtNome;
        private TextBox TxtValor;
        private TextBox TxtCusto;
        private ComboBox CBoxCategoria;
        private Button BtnID;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private Button BtnNovo;
        private Button BtnAlterar;
        private Button BtnVoltar;
        private Button BtnAvancar;
        private GroupBox Estoque;
        private TextBox TxtEstoque;
    }
}