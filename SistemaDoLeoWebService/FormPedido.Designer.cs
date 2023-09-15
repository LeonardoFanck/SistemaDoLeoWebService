namespace SistemaDoLeoWebService
{
    partial class FormPedido
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
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            BtnID = new Button();
            TxtID = new TextBox();
            label1 = new Label();
            BtnCliente = new Button();
            TxtCliente = new TextBox();
            label2 = new Label();
            BtnFormaPGTO = new Button();
            TxtFormaPGTO = new TextBox();
            label3 = new Label();
            TxtValor = new TextBox();
            label4 = new Label();
            TxtDesconto = new TextBox();
            label5 = new Label();
            TxtValorFinal = new TextBox();
            label6 = new Label();
            MTxtData = new MaskedTextBox();
            BtnLiberarPedido = new Button();
            GridViewItens = new DataGridView();
            IDItemPedido = new DataGridViewTextBoxColumn();
            PedidoID = new DataGridViewTextBoxColumn();
            IDProduto = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Desconto = new DataGridViewTextBoxColumn();
            ValorTotal = new DataGridViewTextBoxColumn();
            TxtClienteNome = new TextBox();
            TxtFormaPGTONome = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            LblNovoEstoque = new Label();
            LblLinhaSoma = new Label();
            LblQuantidadeVenda = new Label();
            LblEstoqueAtual = new Label();
            TxtNomeProduto = new TextBox();
            BtnAdicionarItem = new Button();
            BtnRemoverItem = new Button();
            TxtQuantidadeItem = new TextBox();
            label11 = new Label();
            TxtValorFinalItem = new TextBox();
            label8 = new Label();
            TxtDescontoItem = new TextBox();
            label9 = new Label();
            TxtValorItem = new TextBox();
            label10 = new Label();
            BtnProduto = new Button();
            TxtProduto = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridViewItens).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(408, 12);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 64;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(372, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 63;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(858, 402);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 62;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(755, 402);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 61;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(1064, 402);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 60;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(961, 402);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 59;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnID
            // 
            BtnID.Location = new Point(182, 16);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 67;
            BtnID.Text = "->";
            BtnID.UseVisualStyleBackColor = true;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(102, 16);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(74, 23);
            TxtID.TabIndex = 66;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 19);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 65;
            label1.Text = "ID";
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(182, 49);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(41, 23);
            BtnCliente.TabIndex = 70;
            BtnCliente.Text = "->";
            BtnCliente.UseVisualStyleBackColor = true;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(102, 49);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(74, 23);
            TxtCliente.TabIndex = 69;
            TxtCliente.KeyPress += TxtCliente_KeyPress;
            TxtCliente.Leave += TxtCliente_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 52);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 68;
            label2.Text = "Cliente";
            // 
            // BtnFormaPGTO
            // 
            BtnFormaPGTO.Location = new Point(182, 83);
            BtnFormaPGTO.Name = "BtnFormaPGTO";
            BtnFormaPGTO.Size = new Size(41, 23);
            BtnFormaPGTO.TabIndex = 73;
            BtnFormaPGTO.Text = "->";
            BtnFormaPGTO.UseVisualStyleBackColor = true;
            // 
            // TxtFormaPGTO
            // 
            TxtFormaPGTO.Location = new Point(102, 83);
            TxtFormaPGTO.Name = "TxtFormaPGTO";
            TxtFormaPGTO.Size = new Size(74, 23);
            TxtFormaPGTO.TabIndex = 72;
            TxtFormaPGTO.KeyPress += TxtFormaPGTO_KeyPress;
            TxtFormaPGTO.Leave += TxtFormaPGTO_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 86);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 71;
            label3.Text = "Forma PGTO";
            // 
            // TxtValor
            // 
            TxtValor.Location = new Point(1054, 22);
            TxtValor.MaxLength = 10;
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(100, 23);
            TxtValor.TabIndex = 75;
            TxtValor.KeyPress += TxtValor_KeyPress;
            TxtValor.Leave += TxtValor_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1000, 25);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 74;
            label4.Text = "Valor";
            // 
            // TxtDesconto
            // 
            TxtDesconto.Location = new Point(1054, 55);
            TxtDesconto.MaxLength = 10;
            TxtDesconto.Name = "TxtDesconto";
            TxtDesconto.Size = new Size(100, 23);
            TxtDesconto.TabIndex = 77;
            TxtDesconto.KeyPress += TxtDesconto_KeyPress;
            TxtDesconto.Leave += TxtDesconto_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1000, 93);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 76;
            label5.Text = "Total";
            // 
            // TxtValorFinal
            // 
            TxtValorFinal.Location = new Point(1054, 90);
            TxtValorFinal.MaxLength = 10;
            TxtValorFinal.Name = "TxtValorFinal";
            TxtValorFinal.ReadOnly = true;
            TxtValorFinal.Size = new Size(100, 23);
            TxtValorFinal.TabIndex = 79;
            TxtValorFinal.KeyPress += TxtValorFinal_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(991, 62);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 78;
            label6.Text = "Desconto";
            // 
            // MTxtData
            // 
            MTxtData.Location = new Point(265, 15);
            MTxtData.Mask = "00/00/0000";
            MTxtData.Name = "MTxtData";
            MTxtData.Size = new Size(69, 23);
            MTxtData.TabIndex = 80;
            MTxtData.ValidatingType = typeof(DateTime);
            MTxtData.KeyPress += MTxtData_KeyPress;
            MTxtData.Leave += MTxtData_Leave;
            // 
            // BtnLiberarPedido
            // 
            BtnLiberarPedido.Location = new Point(1164, 21);
            BtnLiberarPedido.Name = "BtnLiberarPedido";
            BtnLiberarPedido.Size = new Size(28, 23);
            BtnLiberarPedido.TabIndex = 94;
            BtnLiberarPedido.Text = "$";
            BtnLiberarPedido.UseVisualStyleBackColor = true;
            BtnLiberarPedido.Visible = false;
            // 
            // GridViewItens
            // 
            GridViewItens.AllowUserToAddRows = false;
            GridViewItens.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            GridViewItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            GridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewItens.Columns.AddRange(new DataGridViewColumn[] { IDItemPedido, PedidoID, IDProduto, NomeProduto, Valor, Quantidade, Desconto, ValorTotal });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            GridViewItens.DefaultCellStyle = dataGridViewCellStyle2;
            GridViewItens.GridColor = SystemColors.Window;
            GridViewItens.Location = new Point(14, 129);
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
            GridViewItens.TabIndex = 95;
            // 
            // IDItemPedido
            // 
            IDItemPedido.DataPropertyName = "getSetItemID";
            IDItemPedido.HeaderText = "IDItemPedido";
            IDItemPedido.Name = "IDItemPedido";
            IDItemPedido.ReadOnly = true;
            IDItemPedido.Visible = false;
            // 
            // PedidoID
            // 
            PedidoID.DataPropertyName = "getSetPedidoID";
            PedidoID.HeaderText = "PedidoID";
            PedidoID.Name = "PedidoID";
            PedidoID.ReadOnly = true;
            PedidoID.Visible = false;
            // 
            // IDProduto
            // 
            IDProduto.DataPropertyName = "getSetProduto";
            IDProduto.HeaderText = "Produto";
            IDProduto.Name = "IDProduto";
            IDProduto.ReadOnly = true;
            IDProduto.Width = 70;
            // 
            // NomeProduto
            // 
            NomeProduto.DataPropertyName = "getSetItemNomeProduto";
            NomeProduto.HeaderText = "Nome";
            NomeProduto.Name = "NomeProduto";
            NomeProduto.ReadOnly = true;
            NomeProduto.Width = 200;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "getSetItemValor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 90;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "getSetQuantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 80;
            // 
            // Desconto
            // 
            Desconto.DataPropertyName = "getSetItemDesconto";
            Desconto.HeaderText = "Desconto(%)";
            Desconto.Name = "Desconto";
            Desconto.ReadOnly = true;
            Desconto.Width = 80;
            // 
            // ValorTotal
            // 
            ValorTotal.DataPropertyName = "getSetItemValorTotal";
            ValorTotal.HeaderText = "Valor Total";
            ValorTotal.Name = "ValorTotal";
            ValorTotal.ReadOnly = true;
            ValorTotal.Width = 97;
            // 
            // TxtClienteNome
            // 
            TxtClienteNome.Enabled = false;
            TxtClienteNome.Location = new Point(229, 49);
            TxtClienteNome.Name = "TxtClienteNome";
            TxtClienteNome.Size = new Size(354, 23);
            TxtClienteNome.TabIndex = 97;
            // 
            // TxtFormaPGTONome
            // 
            TxtFormaPGTONome.Enabled = false;
            TxtFormaPGTONome.Location = new Point(229, 83);
            TxtFormaPGTONome.Name = "TxtFormaPGTONome";
            TxtFormaPGTONome.Size = new Size(354, 23);
            TxtFormaPGTONome.TabIndex = 98;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(TxtNomeProduto);
            groupBox1.Controls.Add(BtnAdicionarItem);
            groupBox1.Controls.Add(BtnRemoverItem);
            groupBox1.Controls.Add(TxtQuantidadeItem);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(TxtValorFinalItem);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(TxtDescontoItem);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(TxtValorItem);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(BtnProduto);
            groupBox1.Controls.Add(TxtProduto);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(721, 129);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 250);
            groupBox1.TabIndex = 99;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LblNovoEstoque);
            groupBox2.Controls.Add(LblLinhaSoma);
            groupBox2.Controls.Add(LblQuantidadeVenda);
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
            // LblQuantidadeVenda
            // 
            LblQuantidadeVenda.Location = new Point(23, 59);
            LblQuantidadeVenda.Name = "LblQuantidadeVenda";
            LblQuantidadeVenda.Size = new Size(101, 15);
            LblQuantidadeVenda.TabIndex = 1;
            LblQuantidadeVenda.Text = "- Quantidade";
            LblQuantidadeVenda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblEstoqueAtual
            // 
            LblEstoqueAtual.Location = new Point(35, 38);
            LblEstoqueAtual.Name = "LblEstoqueAtual";
            LblEstoqueAtual.Size = new Size(89, 15);
            LblEstoqueAtual.TabIndex = 0;
            LblEstoqueAtual.Text = "Estoque Atual";
            LblEstoqueAtual.TextAlign = ContentAlignment.MiddleRight;
            LblEstoqueAtual.Click += LblEstoqueAtual_Click;
            // 
            // TxtNomeProduto
            // 
            TxtNomeProduto.Enabled = false;
            TxtNomeProduto.Location = new Point(193, 22);
            TxtNomeProduto.Name = "TxtNomeProduto";
            TxtNomeProduto.Size = new Size(269, 23);
            TxtNomeProduto.TabIndex = 110;
            // 
            // BtnAdicionarItem
            // 
            BtnAdicionarItem.Location = new Point(140, 200);
            BtnAdicionarItem.Name = "BtnAdicionarItem";
            BtnAdicionarItem.Size = new Size(97, 35);
            BtnAdicionarItem.TabIndex = 109;
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
            TxtQuantidadeItem.TabIndex = 107;
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
            // TxtValorFinalItem
            // 
            TxtValorFinalItem.Location = new Point(110, 156);
            TxtValorFinalItem.Name = "TxtValorFinalItem";
            TxtValorFinalItem.ReadOnly = true;
            TxtValorFinalItem.Size = new Size(100, 23);
            TxtValorFinalItem.TabIndex = 105;
            TxtValorFinalItem.TextChanged += TxtValorFinalItem_TextChanged;
            TxtValorFinalItem.KeyPress += TxtValorFinalItem_KeyPress;
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
            TxtDescontoItem.TabIndex = 103;
            TxtDescontoItem.TextChanged += TxtDescontoItem_TextChanged;
            TxtDescontoItem.KeyPress += TxtDescontoItem_KeyPress;
            TxtDescontoItem.Leave += TxtDescontoItem_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 159);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 102;
            label9.Text = "Total (R$)";
            // 
            // TxtValorItem
            // 
            TxtValorItem.Location = new Point(110, 62);
            TxtValorItem.MaxLength = 10;
            TxtValorItem.Name = "TxtValorItem";
            TxtValorItem.Size = new Size(100, 23);
            TxtValorItem.TabIndex = 101;
            TxtValorItem.Text = "                                                                                        ";
            TxtValorItem.TextChanged += TxtValorItem_TextChanged;
            TxtValorItem.KeyPress += TxtValorItem_KeyPress;
            TxtValorItem.Leave += TxtValorItem_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 65);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 100;
            label10.Text = "Valor (R$)";
            // 
            // BtnProduto
            // 
            BtnProduto.Location = new Point(146, 22);
            BtnProduto.Name = "BtnProduto";
            BtnProduto.Size = new Size(41, 23);
            BtnProduto.TabIndex = 99;
            BtnProduto.Text = "->";
            BtnProduto.UseVisualStyleBackColor = true;
            // 
            // TxtProduto
            // 
            TxtProduto.Location = new Point(56, 22);
            TxtProduto.MaxLength = 9;
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(84, 23);
            TxtProduto.TabIndex = 98;
            TxtProduto.TextChanged += TxtProduto_TextChanged;
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
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 455);
            Controls.Add(groupBox1);
            Controls.Add(TxtFormaPGTONome);
            Controls.Add(TxtClienteNome);
            Controls.Add(GridViewItens);
            Controls.Add(BtnLiberarPedido);
            Controls.Add(MTxtData);
            Controls.Add(TxtValorFinal);
            Controls.Add(label6);
            Controls.Add(TxtDesconto);
            Controls.Add(label5);
            Controls.Add(TxtValor);
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
            Name = "FormPedido";
            Text = "FormPedido";
            FormClosing += FormPedido_FormClosing;
            Load += FormPedido_Load;
            KeyDown += FormPedido_KeyDown;
            KeyPress += FormPedido_KeyPress;
            ((System.ComponentModel.ISupportInitialize)GridViewItens).EndInit();
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
        private TextBox TxtID;
        private Label label1;
        private Button BtnCliente;
        private TextBox TxtCliente;
        private Label label2;
        private Button BtnFormaPGTO;
        private TextBox TxtFormaPGTO;
        private Label label3;
        private TextBox TxtValor;
        private Label label4;
        private TextBox TxtDesconto;
        private Label label5;
        private TextBox TxtValorFinal;
        private Label label6;
        private MaskedTextBox MTxtData;
        private Button BtnLiberarPedido;
        private DataGridView GridViewItens;
        private TextBox TxtClienteNome;
        private TextBox TxtFormaPGTONome;
        private GroupBox groupBox1;
        private TextBox TxtNomeProduto;
        private Button BtnAdicionarItem;
        private Button BtnRemoverItem;
        private TextBox TxtQuantidadeItem;
        private Label label11;
        private TextBox TxtValorFinalItem;
        private Label label8;
        private TextBox TxtDescontoItem;
        private Label label9;
        private TextBox TxtValorItem;
        private Label label10;
        private Button BtnProduto;
        private TextBox TxtProduto;
        private Label label7;
        private GroupBox groupBox2;
        private Label LblQuantidadeVenda;
        private Label LblEstoqueAtual;
        private Label LblNovoEstoque;
        private Label LblLinhaSoma;
        private DataGridViewTextBoxColumn IDItemPedido;
        private DataGridViewTextBoxColumn PedidoID;
        private DataGridViewTextBoxColumn IDProduto;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Desconto;
        private DataGridViewTextBoxColumn ValorTotal;
    }
}