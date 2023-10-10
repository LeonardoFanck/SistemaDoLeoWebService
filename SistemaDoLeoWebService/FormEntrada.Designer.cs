namespace SistemaDoLeoWebService
{
    partial class FormEntrada
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            BtnLiberarPedido = new Button();
            groupBox2 = new GroupBox();
            LblNovoEstoque = new Label();
            LblLinhaSoma = new Label();
            LblQuantidadeCompra = new Label();
            LblEstoqueAtual = new Label();
            TxtNomeProduto = new TextBox();
            BtnAdicionarItem = new Button();
            BtnRemoverItem = new Button();
            TxtQuantidadeItem = new TextBox();
            label11 = new Label();
            TxtCustoFinalItem = new TextBox();
            label8 = new Label();
            TxtDescontoItem = new TextBox();
            label9 = new Label();
            TxtCustoItem = new TextBox();
            label10 = new Label();
            BtnProduto = new Button();
            TxtProduto = new TextBox();
            label7 = new Label();
            TxtFormaPGTONome = new TextBox();
            TxtClienteNome = new TextBox();
            GridViewItens = new DataGridView();
            MTxtData = new MaskedTextBox();
            TxtCustoFinal = new TextBox();
            label6 = new Label();
            TxtDesconto = new TextBox();
            label5 = new Label();
            TxtCusto = new TextBox();
            label4 = new Label();
            BtnFormaPGTO = new Button();
            TxtFormaPGTO = new TextBox();
            label3 = new Label();
            BtnCliente = new Button();
            TxtCliente = new TextBox();
            label2 = new Label();
            BtnID = new Button();
            TxtID = new TextBox();
            label1 = new Label();
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            BtnRecalcularValores = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewItens).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnLiberarPedido);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(TxtNomeProduto);
            groupBox1.Controls.Add(BtnAdicionarItem);
            groupBox1.Controls.Add(BtnRemoverItem);
            groupBox1.Controls.Add(TxtQuantidadeItem);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TxtCustoFinalItem);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(TxtDescontoItem);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TxtCustoItem);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(BtnProduto);
            groupBox1.Controls.Add(TxtProduto);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(722, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 250);
            groupBox1.TabIndex = 126;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // BtnLiberarPedido
            // 
            BtnLiberarPedido.Location = new Point(216, 62);
            BtnLiberarPedido.Name = "BtnLiberarPedido";
            BtnLiberarPedido.Size = new Size(28, 23);
            BtnLiberarPedido.TabIndex = 123;
            BtnLiberarPedido.TabStop = false;
            BtnLiberarPedido.Text = "$";
            BtnLiberarPedido.UseVisualStyleBackColor = true;
            BtnLiberarPedido.Visible = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LblNovoEstoque);
            groupBox2.Controls.Add(LblLinhaSoma);
            groupBox2.Controls.Add(LblQuantidadeCompra);
            groupBox2.Controls.Add(LblEstoqueAtual);
            groupBox2.Location = new Point(279, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(140, 155);
            groupBox2.TabIndex = 111;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estoque";
            // 
            // LblNovoEstoque
            // 
            LblNovoEstoque.Location = new Point(35, 97);
            LblNovoEstoque.Name = "LblNovoEstoque";
            LblNovoEstoque.Size = new Size(89, 15);
            LblNovoEstoque.TabIndex = 3;
            LblNovoEstoque.Text = "Novo Estoque";
            LblNovoEstoque.TextAlign = ContentAlignment.MiddleRight;
            LblNovoEstoque.TextChanged += LblNovoEstoque_TextChanged;
            // 
            // LblLinhaSoma
            // 
            LblLinhaSoma.AutoSize = true;
            LblLinhaSoma.Location = new Point(47, 74);
            LblLinhaSoma.Name = "LblLinhaSoma";
            LblLinhaSoma.Size = new Size(77, 15);
            LblLinhaSoma.TabIndex = 2;
            LblLinhaSoma.Text = "______________";
            // 
            // LblQuantidadeCompra
            // 
            LblQuantidadeCompra.Location = new Point(23, 59);
            LblQuantidadeCompra.Name = "LblQuantidadeCompra";
            LblQuantidadeCompra.Size = new Size(101, 15);
            LblQuantidadeCompra.TabIndex = 1;
            LblQuantidadeCompra.Text = "+ Quantidade";
            LblQuantidadeCompra.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblEstoqueAtual
            // 
            LblEstoqueAtual.Location = new Point(35, 38);
            LblEstoqueAtual.Name = "LblEstoqueAtual";
            LblEstoqueAtual.Size = new Size(89, 15);
            LblEstoqueAtual.TabIndex = 0;
            LblEstoqueAtual.Text = "Estoque Atual";
            LblEstoqueAtual.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TxtNomeProduto
            // 
            TxtNomeProduto.Enabled = false;
            TxtNomeProduto.Location = new Point(193, 22);
            TxtNomeProduto.Name = "TxtNomeProduto";
            TxtNomeProduto.Size = new Size(269, 23);
            TxtNomeProduto.TabIndex = 110;
            TxtNomeProduto.TabStop = false;
            // 
            // BtnAdicionarItem
            // 
            BtnAdicionarItem.Location = new Point(140, 200);
            BtnAdicionarItem.Name = "BtnAdicionarItem";
            BtnAdicionarItem.Size = new Size(97, 35);
            BtnAdicionarItem.TabIndex = 10;
            BtnAdicionarItem.Text = "Adicionar";
            BtnAdicionarItem.UseVisualStyleBackColor = true;
            BtnAdicionarItem.Click += BtnAdicionarItem_Click;
            // 
            // BtnRemoverItem
            // 
            BtnRemoverItem.Location = new Point(34, 200);
            BtnRemoverItem.Name = "BtnRemoverItem";
            BtnRemoverItem.Size = new Size(97, 35);
            BtnRemoverItem.TabIndex = 108;
            BtnRemoverItem.TabStop = false;
            BtnRemoverItem.Text = "Excluir";
            BtnRemoverItem.UseVisualStyleBackColor = true;
            BtnRemoverItem.Click += BtnRemoverItem_Click;
            // 
            // TxtQuantidadeItem
            // 
            TxtQuantidadeItem.Location = new Point(110, 92);
            TxtQuantidadeItem.MaxLength = 9;
            TxtQuantidadeItem.Name = "TxtQuantidadeItem";
            TxtQuantidadeItem.Size = new Size(100, 23);
            TxtQuantidadeItem.TabIndex = 7;
            TxtQuantidadeItem.TextChanged += TxtQuantidadeItem_TextChanged;
            TxtQuantidadeItem.KeyPress += TxtQuantidadeItem_KeyPress;
            TxtQuantidadeItem.Leave += TxtQuantidadeItem_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 95);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 106;
            label11.Text = "Quantidade";
            // 
            // TxtCustoFinalItem
            // 
            TxtCustoFinalItem.Location = new Point(110, 156);
            TxtCustoFinalItem.Name = "TxtCustoFinalItem";
            TxtCustoFinalItem.ReadOnly = true;
            TxtCustoFinalItem.Size = new Size(100, 23);
            TxtCustoFinalItem.TabIndex = 9;
            TxtCustoFinalItem.TextChanged += TxtCustoFinalItem_TextChanged;
            TxtCustoFinalItem.KeyPress += TxtCustoFinalItem_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 124);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 104;
            label8.Text = "Desconto (%)";
            // 
            // TxtDescontoItem
            // 
            TxtDescontoItem.Location = new Point(110, 121);
            TxtDescontoItem.MaxLength = 9;
            TxtDescontoItem.Name = "TxtDescontoItem";
            TxtDescontoItem.Size = new Size(100, 23);
            TxtDescontoItem.TabIndex = 8;
            TxtDescontoItem.TextChanged += TxtDescontoItem_TextChanged;
            TxtDescontoItem.KeyPress += TxtDescontoItem_KeyPress;
            TxtDescontoItem.Leave += TxtDescontoItem_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 159);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 102;
            label9.Text = "Custo Total (R$)";
            // 
            // TxtCustoItem
            // 
            TxtCustoItem.Location = new Point(110, 62);
            TxtCustoItem.MaxLength = 10;
            TxtCustoItem.Name = "TxtCustoItem";
            TxtCustoItem.Size = new Size(100, 23);
            TxtCustoItem.TabIndex = 6;
            TxtCustoItem.Text = "                                                                                        ";
            TxtCustoItem.KeyPress += TxtCustoItem_KeyPress;
            TxtCustoItem.Leave += TxtCustoItem_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 65);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 100;
            label10.Text = "Custo (R$)";
            // 
            // BtnProduto
            // 
            BtnProduto.Location = new Point(146, 22);
            BtnProduto.Name = "BtnProduto";
            BtnProduto.Size = new Size(41, 23);
            BtnProduto.TabIndex = 99;
            BtnProduto.TabStop = false;
            BtnProduto.Text = "->";
            BtnProduto.UseVisualStyleBackColor = true;
            BtnProduto.Click += BtnProduto_Click;
            // 
            // TxtProduto
            // 
            TxtProduto.Location = new Point(56, 22);
            TxtProduto.MaxLength = 9;
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(84, 23);
            TxtProduto.TabIndex = 5;
            TxtProduto.TextChanged += TxtProduto_TextChanged;
            TxtProduto.KeyDown += TxtProduto_KeyDown;
            TxtProduto.KeyPress += TxtProduto_KeyPress;
            TxtProduto.Leave += TxtProduto_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 26);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 97;
            label7.Text = "Produto";
            // 
            // TxtFormaPGTONome
            // 
            TxtFormaPGTONome.Enabled = false;
            TxtFormaPGTONome.Location = new Point(230, 79);
            TxtFormaPGTONome.Name = "TxtFormaPGTONome";
            TxtFormaPGTONome.Size = new Size(354, 23);
            TxtFormaPGTONome.TabIndex = 125;
            TxtFormaPGTONome.TabStop = false;
            // 
            // TxtClienteNome
            // 
            TxtClienteNome.Enabled = false;
            TxtClienteNome.Location = new Point(230, 45);
            TxtClienteNome.Name = "TxtClienteNome";
            TxtClienteNome.Size = new Size(354, 23);
            TxtClienteNome.TabIndex = 124;
            TxtClienteNome.TabStop = false;
            // 
            // GridViewItens
            // 
            GridViewItens.AllowUserToAddRows = false;
            GridViewItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            GridViewItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            GridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GridViewItens.DefaultCellStyle = dataGridViewCellStyle2;
            GridViewItens.GridColor = SystemColors.Window;
            GridViewItens.Location = new Point(15, 125);
            GridViewItens.MultiSelect = false;
            GridViewItens.Name = "GridViewItens";
            GridViewItens.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            GridViewItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            GridViewItens.RowTemplate.Height = 25;
            GridViewItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewItens.Size = new Size(660, 308);
            GridViewItens.TabIndex = 123;
            GridViewItens.TabStop = false;
            GridViewItens.CellDoubleClick += GridViewItens_CellDoubleClick;
            GridViewItens.RowPostPaint += GridViewItens_RowPostPaint_1;
            // 
            // MTxtData
            // 
            MTxtData.Location = new Point(266, 11);
            MTxtData.Mask = "00/00/0000";
            MTxtData.Name = "MTxtData";
            MTxtData.Size = new Size(69, 23);
            MTxtData.TabIndex = 101;
            MTxtData.ValidatingType = typeof(DateTime);
            MTxtData.KeyPress += MTxtData_KeyPress;
            MTxtData.Leave += MTxtData_Leave;
            // 
            // TxtCustoFinal
            // 
            TxtCustoFinal.Location = new Point(1062, 96);
            TxtCustoFinal.MaxLength = 10;
            TxtCustoFinal.Name = "TxtCustoFinal";
            TxtCustoFinal.ReadOnly = true;
            TxtCustoFinal.Size = new Size(100, 23);
            TxtCustoFinal.TabIndex = 106;
            TxtCustoFinal.KeyPress += TxtCustoFinal_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(999, 64);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 121;
            label6.Text = "Desconto";
            // 
            // TxtDesconto
            // 
            TxtDesconto.Location = new Point(1062, 61);
            TxtDesconto.MaxLength = 10;
            TxtDesconto.Name = "TxtDesconto";
            TxtDesconto.Size = new Size(100, 23);
            TxtDesconto.TabIndex = 105;
            TxtDesconto.KeyPress += TxtDesconto_KeyPress;
            TxtDesconto.Leave += TxtDesconto_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(990, 99);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 120;
            label5.Text = "Custo Total";
            // 
            // TxtCusto
            // 
            TxtCusto.Location = new Point(1062, 28);
            TxtCusto.MaxLength = 10;
            TxtCusto.Name = "TxtCusto";
            TxtCusto.Size = new Size(100, 23);
            TxtCusto.TabIndex = 104;
            TxtCusto.KeyPress += TxtCusto_KeyPress;
            TxtCusto.Leave += TxtCusto_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1018, 31);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 119;
            label4.Text = "Custo";
            // 
            // BtnFormaPGTO
            // 
            BtnFormaPGTO.Location = new Point(183, 79);
            BtnFormaPGTO.Name = "BtnFormaPGTO";
            BtnFormaPGTO.Size = new Size(41, 23);
            BtnFormaPGTO.TabIndex = 118;
            BtnFormaPGTO.TabStop = false;
            BtnFormaPGTO.Text = "->";
            BtnFormaPGTO.UseVisualStyleBackColor = true;
            BtnFormaPGTO.Click += BtnFormaPGTO_Click;
            // 
            // TxtFormaPGTO
            // 
            TxtFormaPGTO.Location = new Point(103, 79);
            TxtFormaPGTO.MaxLength = 9;
            TxtFormaPGTO.Name = "TxtFormaPGTO";
            TxtFormaPGTO.Size = new Size(74, 23);
            TxtFormaPGTO.TabIndex = 103;
            TxtFormaPGTO.KeyDown += TxtFormaPGTO_KeyDown;
            TxtFormaPGTO.KeyPress += TxtFormaPGTO_KeyPress;
            TxtFormaPGTO.Leave += TxtFormaPGTO_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 82);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 117;
            label3.Text = "Forma PGTO";
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(183, 45);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(41, 23);
            BtnCliente.TabIndex = 116;
            BtnCliente.TabStop = false;
            BtnCliente.Text = "->";
            BtnCliente.UseVisualStyleBackColor = true;
            BtnCliente.Click += BtnCliente_Click;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(103, 45);
            TxtCliente.MaxLength = 9;
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(74, 23);
            TxtCliente.TabIndex = 102;
            TxtCliente.KeyDown += TxtCliente_KeyDown;
            TxtCliente.KeyPress += TxtCliente_KeyPress;
            TxtCliente.Leave += TxtCliente_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 48);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 115;
            label2.Text = "Cliente";
            // 
            // BtnID
            // 
            BtnID.Location = new Point(183, 12);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 114;
            BtnID.TabStop = false;
            BtnID.Text = "->";
            BtnID.UseVisualStyleBackColor = true;
            BtnID.Click += BtnID_Click;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(103, 12);
            TxtID.MaxLength = 9;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(74, 23);
            TxtID.TabIndex = 100;
            TxtID.KeyDown += TxtID_KeyDown;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 15);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 113;
            label1.Text = "ID";
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(409, 8);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 112;
            BtnAvancar.TabStop = false;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(373, 8);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 111;
            BtnVoltar.TabStop = false;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(859, 398);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 110;
            BtnAlterar.TabStop = false;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(756, 398);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 109;
            BtnNovo.TabStop = false;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(1065, 398);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 108;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(962, 398);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 107;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnRecalcularValores
            // 
            BtnRecalcularValores.Location = new Point(1045, 2);
            BtnRecalcularValores.Name = "BtnRecalcularValores";
            BtnRecalcularValores.Size = new Size(117, 23);
            BtnRecalcularValores.TabIndex = 127;
            BtnRecalcularValores.TabStop = false;
            BtnRecalcularValores.Text = "Recalcular Valores";
            BtnRecalcularValores.UseVisualStyleBackColor = true;
            BtnRecalcularValores.Click += BtnRecalcularValores_Click;
            // 
            // FormEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 455);
            Controls.Add(BtnRecalcularValores);
            Controls.Add(groupBox1);
            Controls.Add(TxtFormaPGTONome);
            Controls.Add(TxtClienteNome);
            Controls.Add(GridViewItens);
            Controls.Add(MTxtData);
            Controls.Add(TxtCustoFinal);
            Controls.Add(label6);
            Controls.Add(TxtDesconto);
            Controls.Add(label5);
            Controls.Add(TxtCusto);
            Controls.Add(label4);
            Controls.Add(BtnFormaPGTO);
            Controls.Add(TxtFormaPGTO);
            Controls.Add(label3);
            Controls.Add(BtnCliente);
            Controls.Add(TxtCliente);
            Controls.Add(label2);
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
            Name = "FormEntrada";
            Text = "FormEntrada";
            FormClosing += FormEntrada_FormClosing;
            Load += FormEntrada_Load;
            KeyDown += FormEntrada_KeyDown;
            KeyPress += FormEntrada_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label LblNovoEstoque;
        private Label LblLinhaSoma;
        private Label LblQuantidadeCompra;
        private Label LblEstoqueAtual;
        private TextBox TxtNomeProduto;
        private Button BtnAdicionarItem;
        private Button BtnRemoverItem;
        private TextBox TxtQuantidadeItem;
        private Label label11;
        private TextBox TxtCustoFinalItem;
        private Label label8;
        private TextBox TxtDescontoItem;
        private Label label9;
        private TextBox TxtCustoItem;
        private Label label10;
        private Button BtnProduto;
        private TextBox TxtProduto;
        private Label label7;
        private TextBox TxtFormaPGTONome;
        private TextBox TxtClienteNome;
        private DataGridView GridViewItens;
        private Button BtnLiberarPedido;
        private MaskedTextBox MTxtData;
        private TextBox TxtCustoFinal;
        private Label label6;
        private TextBox TxtDesconto;
        private Label label5;
        private TextBox TxtCusto;
        private Label label4;
        private Button BtnFormaPGTO;
        private TextBox TxtFormaPGTO;
        private Label label3;
        private Button BtnCliente;
        private TextBox TxtCliente;
        private Label label2;
        private Button BtnID;
        private TextBox TxtID;
        private Label label1;
        private Button BtnAvancar;
        private Button BtnVoltar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private Button BtnRecalcularValores;
    }
}