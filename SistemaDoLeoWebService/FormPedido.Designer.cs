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
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
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
            BtnAvancar.Location = new Point(421, 541);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 64;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(385, 541);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 63;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(603, 531);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 62;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(500, 531);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 61;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(809, 531);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 60;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(706, 531);
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 20);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 65;
            label1.Text = "ID";
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(182, 54);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(41, 23);
            BtnCliente.TabIndex = 70;
            BtnCliente.Text = "->";
            BtnCliente.UseVisualStyleBackColor = true;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(102, 54);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(74, 23);
            TxtCliente.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 58);
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 87);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 71;
            label3.Text = "Forma PGTO";
            // 
            // TxtValor
            // 
            TxtValor.Location = new Point(872, 22);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(100, 23);
            TxtValor.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(818, 25);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 74;
            label4.Text = "Valor";
            // 
            // TxtDesconto
            // 
            TxtDesconto.Location = new Point(872, 55);
            TxtDesconto.Name = "TxtDesconto";
            TxtDesconto.Size = new Size(100, 23);
            TxtDesconto.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(818, 93);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 76;
            label5.Text = "Total";
            // 
            // TxtValorFinal
            // 
            TxtValorFinal.Location = new Point(872, 90);
            TxtValorFinal.Name = "TxtValorFinal";
            TxtValorFinal.Size = new Size(100, 23);
            TxtValorFinal.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(809, 62);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 78;
            label6.Text = "Desconto";
            // 
            // MTxtData
            // 
            MTxtData.Location = new Point(102, 112);
            MTxtData.Mask = "00/00/0000";
            MTxtData.Name = "MTxtData";
            MTxtData.Size = new Size(74, 23);
            MTxtData.TabIndex = 80;
            MTxtData.ValidatingType = typeof(DateTime);
            // 
            // BtnLiberarPedido
            // 
            BtnLiberarPedido.Location = new Point(991, 20);
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
            GridViewItens.Location = new Point(23, 199);
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
            // 
            // NomeProduto
            // 
            NomeProduto.DataPropertyName = "getSetItemNomeProduto";
            NomeProduto.HeaderText = "Nome";
            NomeProduto.Name = "NomeProduto";
            NomeProduto.ReadOnly = true;
            // 
            // Valor
            // 
            Valor.DataPropertyName = "getSetItemValor";
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "getSetQuantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // Desconto
            // 
            Desconto.DataPropertyName = "getSetItemDesconto";
            Desconto.HeaderText = "Desconto(%)";
            Desconto.Name = "Desconto";
            Desconto.ReadOnly = true;
            // 
            // ValorTotal
            // 
            ValorTotal.DataPropertyName = "getSetItemValorTotal";
            ValorTotal.HeaderText = "Valor Total";
            ValorTotal.Name = "ValorTotal";
            ValorTotal.ReadOnly = true;
            // 
            // TxtClienteNome
            // 
            TxtClienteNome.Location = new Point(229, 55);
            TxtClienteNome.Name = "TxtClienteNome";
            TxtClienteNome.Size = new Size(354, 23);
            TxtClienteNome.TabIndex = 97;
            // 
            // TxtFormaPGTONome
            // 
            TxtFormaPGTONome.Location = new Point(229, 85);
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
            groupBox1.Location = new Point(706, 199);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(505, 308);
            groupBox1.TabIndex = 99;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(333, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(140, 155);
            groupBox2.TabIndex = 111;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estoque";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(41, 97);
            label15.Name = "label15";
            label15.Size = new Size(81, 15);
            label15.TabIndex = 3;
            label15.Text = "Novo Estoque";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 74);
            label14.Name = "label14";
            label14.Size = new Size(77, 15);
            label14.TabIndex = 2;
            label14.Text = "______________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 59);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 1;
            label13.Text = "- Quantidade";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(44, 30);
            label12.Name = "label12";
            label12.Size = new Size(80, 15);
            label12.TabIndex = 0;
            label12.Text = "Estoque Atual";
            // 
            // TxtNomeProduto
            // 
            TxtNomeProduto.Enabled = false;
            TxtNomeProduto.Location = new Point(251, 29);
            TxtNomeProduto.Name = "TxtNomeProduto";
            TxtNomeProduto.Size = new Size(240, 23);
            TxtNomeProduto.TabIndex = 110;
            // 
            // BtnAdicionarItem
            // 
            BtnAdicionarItem.Location = new Point(189, 192);
            BtnAdicionarItem.Name = "BtnAdicionarItem";
            BtnAdicionarItem.Size = new Size(97, 35);
            BtnAdicionarItem.TabIndex = 109;
            BtnAdicionarItem.Text = "Adicionar";
            BtnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // BtnRemoverItem
            // 
            BtnRemoverItem.Location = new Point(76, 192);
            BtnRemoverItem.Name = "BtnRemoverItem";
            BtnRemoverItem.Size = new Size(97, 35);
            BtnRemoverItem.TabIndex = 108;
            BtnRemoverItem.Text = "Excluir";
            BtnRemoverItem.UseVisualStyleBackColor = true;
            // 
            // TxtQuantidadeItem
            // 
            TxtQuantidadeItem.Location = new Point(139, 99);
            TxtQuantidadeItem.Name = "TxtQuantidadeItem";
            TxtQuantidadeItem.Size = new Size(100, 23);
            TxtQuantidadeItem.TabIndex = 107;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(64, 102);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 106;
            label11.Text = "Quantidade";
            // 
            // TxtValorFinalItem
            // 
            TxtValorFinalItem.Location = new Point(139, 163);
            TxtValorFinalItem.Name = "TxtValorFinalItem";
            TxtValorFinalItem.Size = new Size(100, 23);
            TxtValorFinalItem.TabIndex = 105;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 131);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 104;
            label8.Text = "Desconto";
            // 
            // TxtDescontoItem
            // 
            TxtDescontoItem.Location = new Point(139, 128);
            TxtDescontoItem.Name = "TxtDescontoItem";
            TxtDescontoItem.Size = new Size(100, 23);
            TxtDescontoItem.TabIndex = 103;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(85, 166);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 102;
            label9.Text = "Total";
            // 
            // TxtValorItem
            // 
            TxtValorItem.Location = new Point(139, 69);
            TxtValorItem.Name = "TxtValorItem";
            TxtValorItem.Size = new Size(100, 23);
            TxtValorItem.TabIndex = 101;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(85, 72);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 100;
            label10.Text = "Valor";
            // 
            // BtnProduto
            // 
            BtnProduto.Location = new Point(198, 29);
            BtnProduto.Name = "BtnProduto";
            BtnProduto.Size = new Size(41, 23);
            BtnProduto.TabIndex = 99;
            BtnProduto.Text = "->";
            BtnProduto.UseVisualStyleBackColor = true;
            // 
            // TxtProduto
            // 
            TxtProduto.Location = new Point(85, 29);
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(100, 23);
            TxtProduto.TabIndex = 98;
            TxtProduto.TextChanged += TxtProduto_TextChanged;
            TxtProduto.KeyPress += TxtProduto_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 33);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 97;
            label7.Text = "Produto";
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 589);
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
            Name = "FormPedido";
            Text = "FormPedido";
            Load += FormPedido_Load;
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
        private DataGridViewTextBoxColumn IDItemPedido;
        private DataGridViewTextBoxColumn PedidoID;
        private DataGridViewTextBoxColumn IDProduto;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Desconto;
        private DataGridViewTextBoxColumn ValorTotal;
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
        private Label label13;
        private Label label12;
        private Label label15;
        private Label label14;
    }
}