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
            TxtQuantidade = new TextBox();
            label11 = new Label();
            BtnRemoverItem = new Button();
            BtnAdicionarItem = new Button();
            BtnLiberarPedido = new Button();
            SuspendLayout();
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(158, 413);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 64;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(122, 413);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 63;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(340, 403);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 62;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(237, 403);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 61;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(546, 403);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 60;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(443, 403);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 59;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnID
            // 
            BtnID.Location = new Point(73, 16);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 67;
            BtnID.Text = "->";
            BtnID.UseVisualStyleBackColor = true;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(134, 17);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 65;
            label1.Text = "ID";
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(100, 54);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(41, 23);
            BtnCliente.TabIndex = 70;
            BtnCliente.Text = "->";
            BtnCliente.UseVisualStyleBackColor = true;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(161, 55);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(100, 23);
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
            BtnFormaPGTO.Location = new Point(100, 83);
            BtnFormaPGTO.Name = "BtnFormaPGTO";
            BtnFormaPGTO.Size = new Size(41, 23);
            BtnFormaPGTO.TabIndex = 73;
            BtnFormaPGTO.Text = "->";
            BtnFormaPGTO.UseVisualStyleBackColor = true;
            // 
            // TxtFormaPGTO
            // 
            TxtFormaPGTO.Location = new Point(161, 84);
            TxtFormaPGTO.Name = "TxtFormaPGTO";
            TxtFormaPGTO.Size = new Size(100, 23);
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
            TxtValor.Location = new Point(620, 22);
            TxtValor.Name = "TxtValor";
            TxtValor.Size = new Size(100, 23);
            TxtValor.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(566, 25);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 74;
            label4.Text = "Valor";
            // 
            // TxtDesconto
            // 
            TxtDesconto.Location = new Point(620, 55);
            TxtDesconto.Name = "TxtDesconto";
            TxtDesconto.Size = new Size(100, 23);
            TxtDesconto.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(566, 93);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 76;
            label5.Text = "Total";
            // 
            // TxtValorFinal
            // 
            TxtValorFinal.Location = new Point(620, 90);
            TxtValorFinal.Name = "TxtValorFinal";
            TxtValorFinal.Size = new Size(100, 23);
            TxtValorFinal.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(557, 62);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 78;
            label6.Text = "Desconto";
            // 
            // MTxtData
            // 
            MTxtData.Location = new Point(340, 12);
            MTxtData.Mask = "00/00/0000";
            MTxtData.Name = "MTxtData";
            MTxtData.Size = new Size(74, 23);
            MTxtData.TabIndex = 80;
            MTxtData.ValidatingType = typeof(DateTime);
            // 
            // BtnProduto
            // 
            BtnProduto.Location = new Point(559, 152);
            BtnProduto.Name = "BtnProduto";
            BtnProduto.Size = new Size(41, 23);
            BtnProduto.TabIndex = 83;
            BtnProduto.Text = "->";
            BtnProduto.UseVisualStyleBackColor = true;
            // 
            // TxtProduto
            // 
            TxtProduto.Location = new Point(620, 153);
            TxtProduto.Name = "TxtProduto";
            TxtProduto.Size = new Size(100, 23);
            TxtProduto.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(503, 156);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 81;
            label7.Text = "Produto";
            // 
            // TxtValorFinalItem
            // 
            TxtValorFinalItem.Location = new Point(620, 286);
            TxtValorFinalItem.Name = "TxtValorFinalItem";
            TxtValorFinalItem.Size = new Size(100, 23);
            TxtValorFinalItem.TabIndex = 89;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(549, 254);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 88;
            label8.Text = "Desconto";
            // 
            // TxtDescontoItem
            // 
            TxtDescontoItem.Location = new Point(620, 251);
            TxtDescontoItem.Name = "TxtDescontoItem";
            TxtDescontoItem.Size = new Size(100, 23);
            TxtDescontoItem.TabIndex = 87;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(566, 289);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 86;
            label9.Text = "Total";
            // 
            // TxtValorItem
            // 
            TxtValorItem.Location = new Point(620, 192);
            TxtValorItem.Name = "TxtValorItem";
            TxtValorItem.Size = new Size(100, 23);
            TxtValorItem.TabIndex = 85;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(566, 195);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 84;
            label10.Text = "Valor";
            // 
            // TxtQuantidade
            // 
            TxtQuantidade.Location = new Point(620, 222);
            TxtQuantidade.Name = "TxtQuantidade";
            TxtQuantidade.Size = new Size(100, 23);
            TxtQuantidade.TabIndex = 91;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(545, 225);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 90;
            label11.Text = "Quantidade";
            // 
            // BtnRemoverItem
            // 
            BtnRemoverItem.Location = new Point(557, 315);
            BtnRemoverItem.Name = "BtnRemoverItem";
            BtnRemoverItem.Size = new Size(97, 35);
            BtnRemoverItem.TabIndex = 92;
            BtnRemoverItem.Text = "Excluir";
            BtnRemoverItem.UseVisualStyleBackColor = true;
            // 
            // BtnAdicionarItem
            // 
            BtnAdicionarItem.Location = new Point(670, 315);
            BtnAdicionarItem.Name = "BtnAdicionarItem";
            BtnAdicionarItem.Size = new Size(97, 35);
            BtnAdicionarItem.TabIndex = 93;
            BtnAdicionarItem.Text = "Adicionar";
            BtnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // BtnLiberarPedido
            // 
            BtnLiberarPedido.Location = new Point(739, 20);
            BtnLiberarPedido.Name = "BtnLiberarPedido";
            BtnLiberarPedido.Size = new Size(28, 23);
            BtnLiberarPedido.TabIndex = 94;
            BtnLiberarPedido.Text = "$";
            BtnLiberarPedido.UseVisualStyleBackColor = true;
            BtnLiberarPedido.Visible = false;
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnLiberarPedido);
            Controls.Add(BtnAdicionarItem);
            Controls.Add(BtnRemoverItem);
            Controls.Add(TxtQuantidade);
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
        private TextBox TxtQuantidade;
        private Label label11;
        private Button BtnRemoverItem;
        private Button BtnAdicionarItem;
        private Button BtnLiberarPedido;
    }
}