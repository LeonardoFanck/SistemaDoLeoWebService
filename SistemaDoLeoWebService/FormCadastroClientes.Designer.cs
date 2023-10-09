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
            label7 = new Label();
            TxtCEP = new MaskedTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(81, 376);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 40;
            BtnAvancar.TabStop = false;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(45, 376);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 39;
            BtnVoltar.TabStop = false;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(260, 371);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 38;
            BtnAlterar.TabStop = false;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(157, 371);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 37;
            BtnNovo.TabStop = false;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(466, 371);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 20;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(363, 371);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 19;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnID
            // 
            BtnID.Location = new Point(195, 21);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 1;
            BtnID.TabStop = false;
            BtnID.Text = "<-";
            BtnID.UseVisualStyleBackColor = true;
            BtnID.Click += BtnID_Click;
            // 
            // CBoxUF
            // 
            CBoxUF.DropDownStyle = ComboBoxStyle.DropDownList;
            CBoxUF.FormattingEnabled = true;
            CBoxUF.Location = new Point(196, 200);
            CBoxUF.Name = "CBoxUF";
            CBoxUF.Size = new Size(51, 23);
            CBoxUF.TabIndex = 8;
            CBoxUF.KeyPress += CBoxUF_KeyPress;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(77, 166);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(289, 23);
            TxtEmail.TabIndex = 6;
            TxtEmail.KeyPress += TxtEmail_KeyPress;
            TxtEmail.Leave += TxtEmail_Leave;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(77, 70);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(369, 23);
            TxtNome.TabIndex = 3;
            TxtNome.KeyPress += TxtNome_KeyPress;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(77, 21);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 0;
            TxtID.KeyDown += TxtID_KeyDown;
            TxtID.KeyPress += TxtID_KeyPress;
            TxtID.Leave += TxtID_Leave;
            // 
            // ChkBoxInativo
            // 
            ChkBoxInativo.AutoSize = true;
            ChkBoxInativo.Location = new Point(488, 21);
            ChkBoxInativo.Name = "ChkBoxInativo";
            ChkBoxInativo.Size = new Size(62, 19);
            ChkBoxInativo.TabIndex = 26;
            ChkBoxInativo.TabStop = false;
            ChkBoxInativo.Text = "Inativo";
            ChkBoxInativo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 169);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 25;
            label5.Text = "Email";
            // 
            // LblDocumento
            // 
            LblDocumento.AutoSize = true;
            LblDocumento.Location = new Point(109, 116);
            LblDocumento.Name = "LblDocumento";
            LblDocumento.Size = new Size(28, 15);
            LblDocumento.TabIndex = 24;
            LblDocumento.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 203);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 23;
            label3.Text = "UF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 73);
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
            TxtMDocumento.Location = new Point(146, 113);
            TxtMDocumento.Name = "TxtMDocumento";
            TxtMDocumento.Size = new Size(114, 23);
            TxtMDocumento.TabIndex = 5;
            TxtMDocumento.KeyPress += TxtMDocumento_KeyPress;
            TxtMDocumento.Leave += TxtMDocumento_Leave;
            // 
            // ComboDocumento
            // 
            ComboDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDocumento.FormattingEnabled = true;
            ComboDocumento.Location = new Point(35, 113);
            ComboDocumento.Name = "ComboDocumento";
            ComboDocumento.Size = new Size(68, 23);
            ComboDocumento.TabIndex = 4;
            ComboDocumento.SelectedIndexChanged += ComboDocumento_SelectedIndexChanged;
            ComboDocumento.KeyPress += ComboDocumento_KeyPress;
            // 
            // TxtMDtNasc
            // 
            TxtMDtNasc.InsertKeyMode = InsertKeyMode.Overwrite;
            TxtMDtNasc.Location = new Point(333, 20);
            TxtMDtNasc.Mask = "00/00/0000";
            TxtMDtNasc.Name = "TxtMDtNasc";
            TxtMDtNasc.Size = new Size(71, 23);
            TxtMDtNasc.TabIndex = 2;
            TxtMDtNasc.Enter += TxtMDtNasc_Enter;
            TxtMDtNasc.KeyPress += TxtMDtNasc_KeyPress;
            TxtMDtNasc.Leave += TxtMDtNasc_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 24);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 43;
            label4.Text = "Nascimento";
            // 
            // TxtCidade
            // 
            TxtCidade.Location = new Point(77, 236);
            TxtCidade.Name = "TxtCidade";
            TxtCidade.Size = new Size(289, 23);
            TxtCidade.TabIndex = 9;
            TxtCidade.KeyPress += TxtCidade_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 238);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 47;
            label8.Text = "Cidade";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(77, 295);
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(289, 23);
            TxtEndereco.TabIndex = 11;
            TxtEndereco.KeyPress += TxtEndereco_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 297);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 49;
            label9.Text = "Endereço";
            // 
            // TxtNumero
            // 
            TxtNumero.Location = new Point(77, 324);
            TxtNumero.Name = "TxtNumero";
            TxtNumero.Size = new Size(95, 23);
            TxtNumero.TabIndex = 12;
            TxtNumero.KeyPress += TxtNumero_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 326);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 51;
            label10.Text = "Numero";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBtnApart);
            groupBox1.Controls.Add(RBtnCasa);
            groupBox1.Location = new Point(472, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(125, 130);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Moradia";
            // 
            // RBtnApart
            // 
            RBtnApart.AutoSize = true;
            RBtnApart.Location = new Point(17, 68);
            RBtnApart.Name = "RBtnApart";
            RBtnApart.Size = new Size(95, 19);
            RBtnApart.TabIndex = 15;
            RBtnApart.TabStop = true;
            RBtnApart.Text = "Apartamento";
            RBtnApart.UseVisualStyleBackColor = true;
            RBtnApart.KeyPress += RBtnApart_KeyPress;
            // 
            // RBtnCasa
            // 
            RBtnCasa.AutoSize = true;
            RBtnCasa.Location = new Point(17, 36);
            RBtnCasa.Name = "RBtnCasa";
            RBtnCasa.Size = new Size(50, 19);
            RBtnCasa.TabIndex = 14;
            RBtnCasa.TabStop = true;
            RBtnCasa.Text = "Casa";
            RBtnCasa.UseVisualStyleBackColor = true;
            RBtnCasa.KeyPress += RBtnCasa_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ChkBoxFornecedor);
            groupBox2.Controls.Add(ChkBoxCliente);
            groupBox2.Location = new Point(472, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(125, 130);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo";
            // 
            // ChkBoxFornecedor
            // 
            ChkBoxFornecedor.AutoSize = true;
            ChkBoxFornecedor.Location = new Point(21, 74);
            ChkBoxFornecedor.Name = "ChkBoxFornecedor";
            ChkBoxFornecedor.Size = new Size(86, 19);
            ChkBoxFornecedor.TabIndex = 18;
            ChkBoxFornecedor.Text = "Fornecedor";
            ChkBoxFornecedor.UseVisualStyleBackColor = true;
            ChkBoxFornecedor.KeyPress += ChkBoxFornecedor_KeyPress;
            // 
            // ChkBoxCliente
            // 
            ChkBoxCliente.AutoSize = true;
            ChkBoxCliente.Location = new Point(21, 37);
            ChkBoxCliente.Name = "ChkBoxCliente";
            ChkBoxCliente.Size = new Size(63, 19);
            ChkBoxCliente.TabIndex = 17;
            ChkBoxCliente.Text = "Cliente";
            ChkBoxCliente.UseVisualStyleBackColor = true;
            ChkBoxCliente.KeyPress += ChkBoxCliente_KeyPress;
            // 
            // TxtBairro
            // 
            TxtBairro.Location = new Point(77, 266);
            TxtBairro.Name = "TxtBairro";
            TxtBairro.Size = new Size(289, 23);
            TxtBairro.TabIndex = 10;
            TxtBairro.KeyPress += TxtBairro_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 268);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 59;
            label6.Text = "Bairro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 203);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 61;
            label7.Text = "CEP";
            // 
            // TxtCEP
            // 
            TxtCEP.InsertKeyMode = InsertKeyMode.Overwrite;
            TxtCEP.Location = new Point(77, 200);
            TxtCEP.Mask = "00,000-000";
            TxtCEP.Name = "TxtCEP";
            TxtCEP.Size = new Size(73, 23);
            TxtCEP.TabIndex = 7;
            TxtCEP.Enter += TxtCEP_Enter;
            TxtCEP.KeyPress += TxtCEP_KeyPress;
            TxtCEP.Leave += TxtCEP_Leave;
            // 
            // FormCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 424);
            Controls.Add(TxtCEP);
            Controls.Add(label7);
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
            KeyDown += FormCadastroClientes_KeyDown;
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
        private Label label7;
        private MaskedTextBox TxtCEP;
    }
}