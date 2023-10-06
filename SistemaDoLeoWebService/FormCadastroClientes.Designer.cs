namespace SistemaDoLeoWebService
{
    partial class FormCadastroClientes
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
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            BtnID = new Button();
            CBoxUF = new ComboBox();
            TxtEmail = new TextBox();
            TxtNome = new TextBox();
            TxtID = new TextBox();
            ChkBoxInativo = new CheckBox();
            label5 = new Label();
            LblDocumento = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TxtMDocumento = new MaskedTextBox();
            ComboDocumento = new ComboBox();
            TxtMDtNasc = new MaskedTextBox();
            label4 = new Label();
            TxtCidade = new TextBox();
            label8 = new Label();
            TxtEndereco = new TextBox();
            label9 = new Label();
            TxtNumero = new TextBox();
            label10 = new Label();
            groupBox1 = new GroupBox();
            RBtnApart = new RadioButton();
            RBtnCasa = new RadioButton();
            groupBox2 = new GroupBox();
            ChkBoxFornecedor = new CheckBox();
            ChkBoxCliente = new CheckBox();
            TxtBairro = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(474, 496);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 40;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(438, 496);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 39;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(656, 486);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 38;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(553, 486);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 37;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(862, 486);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 36;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(759, 486);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 35;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnID
            // 
            BtnID.Location = new Point(77, 20);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 34;
            BtnID.Text = "->";
            BtnID.UseVisualStyleBackColor = true;
            BtnID.Click += BtnID_Click;
            // 
            // CBoxUF
            // 
            CBoxUF.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxUF.FormattingEnabled = true;
            CBoxUF.Location = new Point(56, 266);
            CBoxUF.Name = "CBoxUF";
            CBoxUF.Size = new Size(51, 23);
            CBoxUF.TabIndex = 33;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(69, 182);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(289, 23);
            TxtEmail.TabIndex = 30;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(73, 77);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(369, 23);
            TxtNome.TabIndex = 28;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(138, 21);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 27;
            TxtID.KeyDown += TxtID_KeyDown;
            TxtID.KeyPress += TxtID_KeyPress;
            TxtID.Leave += TxtID_Leave;
            // 
            // ChkBoxInativo
            // 
            ChkBoxInativo.AutoSize = true;
            ChkBoxInativo.Location = new Point(850, 25);
            ChkBoxInativo.Name = "ChkBoxInativo";
            ChkBoxInativo.Size = new Size(62, 19);
            ChkBoxInativo.TabIndex = 26;
            ChkBoxInativo.Text = "Inativo";
            ChkBoxInativo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 185);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 25;
            label5.Text = "Email";
            // 
            // LblDocumento
            // 
            LblDocumento.AutoSize = true;
            LblDocumento.Location = new Point(101, 132);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new Size(28, 15);
            LblDocumento.TabIndex = 24;
            LblDocumento.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 269);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 23;
            label3.Text = "UF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 80);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 22;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // TxtMDocumento
            // 
            TxtMDocumento.Location = new Point(138, 129);
            TxtMDocumento.Name = "TxtMDocumento";
            TxtMDocumento.Size = new Size(114, 23);
            TxtMDocumento.TabIndex = 41;
            // 
            // ComboDocumento
            // 
            ComboDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDocumento.FormattingEnabled = true;
            ComboDocumento.Location = new Point(27, 129);
            ComboDocumento.Name = "ComboDocumento";
            ComboDocumento.Size = new Size(68, 23);
            ComboDocumento.TabIndex = 42;
            ComboDocumento.SelectedIndexChanged += ComboDocumento_SelectedIndexChanged;
            // 
            // TxtMDtNasc
            // 
            TxtMDtNasc.Location = new Point(101, 224);
            TxtMDtNasc.Mask = "00/00/0000";
            TxtMDtNasc.Name = "TxtMDtNasc";
            TxtMDtNasc.Size = new Size(71, 23);
            TxtMDtNasc.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 227);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 43;
            label4.Text = "Nascimento";
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(77, 311);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(289, 23);
            TxtCidade.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 314);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 47;
            label8.Text = "Cidade";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(77, 370);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(289, 23);
            TxtEndereco.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 373);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 49;
            label9.Text = "Endereço";
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(77, 399);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(289, 23);
            TxtNumero.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 402);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 51;
            label10.Text = "Numero";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBtnApart);
            groupBox1.Controls.Add(RBtnCasa);
            groupBox1.Location = new Point(834, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(125, 130);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "Moradia";
            // 
            // RBtnApart
            // 
            RBtnApart.AutoSize = true;
            RBtnApart.Location = new Point(17, 68);
            RBtnApart.Name = "RBtnApart";
            RBtnApart.Size = new Size(95, 19);
            RBtnApart.TabIndex = 56;
            RBtnApart.TabStop = true;
            RBtnApart.Text = "Apartamento";
            RBtnApart.UseVisualStyleBackColor = true;
            // 
            // RBtnCasa
            // 
            RBtnCasa.AutoSize = true;
            RBtnCasa.Location = new Point(17, 36);
            RBtnCasa.Name = "RBtnCasa";
            RBtnCasa.Size = new Size(50, 19);
            RBtnCasa.TabIndex = 55;
            RBtnCasa.TabStop = true;
            RBtnCasa.Text = "Casa";
            RBtnCasa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ChkBoxFornecedor);
            groupBox2.Controls.Add(ChkBoxCliente);
            groupBox2.Location = new Point(834, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(125, 130);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo";
            // 
            // ChkBoxFornecedor
            // 
            ChkBoxFornecedor.AutoSize = true;
            ChkBoxFornecedor.Location = new Point(21, 74);
            ChkBoxFornecedor.Name = "ChkBoxFornecedor";
            ChkBoxFornecedor.Size = new Size(86, 19);
            ChkBoxFornecedor.TabIndex = 58;
            ChkBoxFornecedor.Text = "Fornecedor";
            ChkBoxFornecedor.UseVisualStyleBackColor = true;
            // 
            // ChkBoxCliente
            // 
            ChkBoxCliente.AutoSize = true;
            ChkBoxCliente.Location = new Point(21, 37);
            ChkBoxCliente.Name = "ChkBoxCliente";
            ChkBoxCliente.Size = new Size(63, 19);
            ChkBoxCliente.TabIndex = 57;
            ChkBoxCliente.Text = "Cliente";
            ChkBoxCliente.UseVisualStyleBackColor = true;
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(77, 341);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(289, 23);
            TxtBairro.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 344);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 59;
            label6.Text = "Bairro";
            // 
            // FormCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 533);
            Controls.Add(TxtBairro);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(TxtNumero);
            Controls.Add(label10);
            Controls.Add(TxtEndereco);
            Controls.Add(label9);
            Controls.Add(TxtCidade);
            Controls.Add(label8);
            Controls.Add(TxtMDtNasc);
            Controls.Add(label4);
            Controls.Add(ComboDocumento);
            Controls.Add(TxtMDocumento);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnID);
            Controls.Add(CBoxUF);
            Controls.Add(TxtEmail);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Controls.Add(ChkBoxInativo);
            Controls.Add(label5);
            Controls.Add(LblDocumento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "FormCadastroClientes";
            Text = "FormCadastroClientes";
            Load += FormCadastroClientes_Load;
            KeyPress += FormCadastroClientes_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAvancar;
        private Button BtnVoltar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private Button BtnID;
        private ComboBox CBoxUF;
        private TextBox TxtEmail;
        private TextBox TxtNome;
        private TextBox TxtID;
        private CheckBox ChkBoxInativo;
        private Label label5;
        private Label LblDocumento;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox TxtMDocumento;
        private ComboBox ComboDocumento;
        private MaskedTextBox TxtMDtNasc;
        private Label label4;
        private TextBox TxtCidade;
        private Label label8;
        private TextBox TxtEndereco;
        private Label label9;
        private TextBox TxtNumero;
        private Label label10;
        private GroupBox groupBox1;
        private RadioButton RBtnApart;
        private RadioButton RBtnCasa;
        private GroupBox groupBox2;
        private CheckBox ChkBoxFornecedor;
        private CheckBox ChkBoxCliente;
        private TextBox TxtBairro;
        private Label label6;
    }
}