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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            BtnProduto = new Button();
            TxtProduto = new TextBox();
            label7 = new Label();
            TxtValorFinalItem = new TextBox();
            label8 = new Label();
            TxtDescontoItem = new TextBox();
            label9 = new Label();
            TxtValorItem = new TextBox();
            label10 = new Label();
            TxtQuantidadeItem = new TextBox();
            label11 = new Label();
            BtnRemoverItem = new Button();
            BtnAdicionarItem = new Button();
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
            TxtNomeProduto = new TextBox();
            TxtClienteNome = new TextBox();
            TxtFormaPGTONome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridViewItens).BeginInit();
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
            // BtnProduto
            // 
            BtnProduto.Location = new Point(866, 221);
            BtnProduto.Name = "BtnProduto";
            BtnProduto.Size = new Size(41, 23);
            BtnProduto.TabIndex = 83;
            BtnProduto.Text = "->";
            BtnProduto.UseVisualStyleBackColor = true;
            // 
            // TxtProduto
            // 
            TxtProduto.Location = new Point(753, 221);
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(100, 23);
            TxtProduto.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(690, 225);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 81;
            label7.Text = "Produto";
            // 
            // TxtValorFinalItem
            // 
            TxtValorFinalItem.Location = new Point(807, 355);
            TxtValorFinalItem.Name = "TxtValorFinalItem";
            TxtValorFinalItem.Size = new Size(100, 23);
            TxtValorFinalItem.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(736, 323);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 88;
            label8.Text = "Desconto";
            // 
            // TxtDescontoItem
            // 
            TxtDescontoItem.Location = new Point(807, 320);
            TxtDescontoItem.Name = "TxtDescontoItem";
            TxtDescontoItem.Size = new Size(100, 23);
            TxtDescontoItem.TabIndex = 87;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(753, 358);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 86;
            label9.Text = "Total";
            // 
            // TxtValorItem
            // 
            TxtValorItem.Location = new Point(807, 261);
            TxtValorItem.Name = "TxtValorItem";
            TxtValorItem.Size = new Size(100, 23);
            TxtValorItem.TabIndex = 85;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(753, 264);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 84;
            label10.Text = "Valor";
            // 
            // TxtQuantidadeItem
            // 
            TxtQuantidadeItem.Location = new Point(807, 291);
            TxtQuantidadeItem.Name = "TxtQuantidadeItem";
            TxtQuantidadeItem.Size = new Size(100, 23);
            TxtQuantidadeItem.TabIndex = 91;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(732, 294);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 90;
            label11.Text = "Quantidade";
            // 
            // BtnRemoverItem
            // 
            BtnRemoverItem.Location = new Point(744, 384);
            BtnRemoverItem.Name = "BtnRemoverItem";
            BtnRemoverItem.Size = new Size(97, 35);
            BtnRemoverItem.TabIndex = 92;
            BtnRemoverItem.Text = "Excluir";
            BtnRemoverItem.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionarItem
            // 
            BtnAdicionarItem.Location = new Point(857, 384);
            BtnAdicionarItem.Name = "BtnAdicionarItem";
            BtnAdicionarItem.Size = new Size(97, 35);
            BtnAdicionarItem.TabIndex = 93;
            BtnAdicionarItem.Text = "Adicionar";
            BtnAdicionarItem.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            GridViewItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            GridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewItens.Columns.AddRange(new DataGridViewColumn[] { IDItemPedido, PedidoID, IDProduto, NomeProduto, Valor, Quantidade, Desconto, ValorTotal });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            GridViewItens.DefaultCellStyle = dataGridViewCellStyle5;
            GridViewItens.GridColor = SystemColors.Window;
            GridViewItens.Location = new Point(23, 199);
            GridViewItens.Name = "GridViewItens";
            GridViewItens.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            GridViewItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            // TxtNomeProduto
            // 
            TxtNomeProduto.Location = new Point(919, 221);
            TxtNomeProduto.Name = "TxtNomeProduto";
            TxtNomeProduto.Size = new Size(240, 23);
            TxtNomeProduto.TabIndex = 96;
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
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 589);
            Controls.Add(TxtFormaPGTONome);
            Controls.Add(TxtClienteNome);
            Controls.Add(TxtNomeProduto);
            Controls.Add(GridViewItens);
            Controls.Add(BtnLiberarPedido);
            Controls.Add(BtnAdicionarItem);
            Controls.Add(BtnRemoverItem);
            Controls.Add(TxtQuantidadeItem);
            Controls.Add(label11);
            Controls.Add(TxtValorFinalItem);
            Controls.Add(label8);
            Controls.Add(TxtDescontoItem);
            Controls.Add(label9);
            Controls.Add(TxtValorItem);
            Controls.Add(label10);
            Controls.Add(BtnProduto);
            Controls.Add(TxtProduto);
            Controls.Add(label7);
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
        private Button BtnProduto;
        private TextBox TxtProduto;
        private Label label7;
        private TextBox TxtValorFinalItem;
        private Label label8;
        private TextBox TxtDescontoItem;
        private Label label9;
        private TextBox TxtValorItem;
        private Label label10;
        private TextBox TxtQuantidadeItem;
        private Label label11;
        private Button BtnRemoverItem;
        private Button BtnAdicionarItem;
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
        private TextBox TxtNomeProduto;
        private TextBox TxtClienteNome;
        private TextBox TxtFormaPGTONome;
    }
}