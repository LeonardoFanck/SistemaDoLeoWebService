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
            TxtEstoque = new TextBox();
            label6 = new Label();
            CBoxCategoria = new ComboBox();
            BtnID = new Button();
            BtnSalvar = new Button();
            BtnCancelar = new Button();
            BtnNovo = new Button();
            BtnAlterar = new Button();
            BtnVoltar = new Button();
            BtnAvancar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 83);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 154);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 217);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 287);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Custo";
            // 
            // ChkBoxInativo
            // 
            ChkBoxInativo.AutoSize = true;
            ChkBoxInativo.Location = new Point(654, 58);
            ChkBoxInativo.Name = "ChkBoxInativo";
            ChkBoxInativo.Size = new Size(62, 19);
            ChkBoxInativo.TabIndex = 5;
            ChkBoxInativo.Text = "Inativo";
            ChkBoxInativo.UseVisualStyleBackColor = true;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(134, 24);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 6;
            TxtID.KeyDown += TxtID_KeyDown;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(95, 83);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(369, 23);
            TxtNome.TabIndex = 7;
            // 
            // TxtValor
            // 
            TxtValor.Location = new Point(95, 214);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(100, 23);
            TxtValor.TabIndex = 9;
            TxtValor.KeyPress += TxtValor_KeyPress;
            // 
            // TxtCusto
            // 
            TxtCusto.Location = new Point(95, 287);
            TxtCusto.Name = "TxtCusto";
            TxtCusto.Size = new Size(100, 23);
            TxtCusto.TabIndex = 10;
            TxtCusto.KeyPress += TxtCusto_KeyPress;
            // 
            // TxtEstoque
            // 
            TxtEstoque.Enabled = false;
            TxtEstoque.Location = new Point(679, 319);
            TxtEstoque.Name = "TxtEstoque";
            TxtEstoque.Size = new Size(100, 23);
            TxtEstoque.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(700, 290);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 11;
            label6.Text = "Estoque";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CBoxCategoria
            // 
            CBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxCategoria.FormattingEnabled = true;
            CBoxCategoria.Location = new Point(95, 151);
            CBoxCategoria.Name = "CBoxCategoria";
            CBoxCategoria.Size = new Size(257, 23);
            CBoxCategoria.TabIndex = 13;
            // 
            // BtnID
            // 
            BtnID.Location = new Point(73, 23);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 14;
            BtnID.Text = "->";
            BtnID.UseVisualStyleBackColor = true;
            BtnID.Click += BtnID_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(358, 403);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 15;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(461, 403);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 16;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(152, 403);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 17;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(255, 403);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 18;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(37, 413);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 19;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(73, 413);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 20;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // FormCadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnID);
            Controls.Add(CBoxCategoria);
            Controls.Add(TxtEstoque);
            Controls.Add(label6);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroProdutos";
            Text = "FormCadastroProdutos";
            Load += FormCadastroProdutos_Load;
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
        private TextBox TxtEstoque;
        private Label label6;
        private ComboBox CBoxCategoria;
        private Button BtnID;
        private Button BtnSalvar;
        private Button BtnCancelar;
        private Button BtnNovo;
        private Button BtnAlterar;
        private Button BtnVoltar;
        private Button BtnAvancar;
    }
}