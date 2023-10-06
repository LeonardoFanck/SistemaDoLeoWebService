namespace SistemaDoLeoWebService
{
    partial class FormConfiguracoesGerais
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
            Button BtnSalvar;
            TxtMaxDescPedido = new TextBox();
            TxtMaxDescItemPedido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ChkBoxPedido = new CheckBox();
            ChkBoxItemPedido = new CheckBox();
            BtnSair = new Button();
            ChkBoxVendaEstoqueNegativo = new CheckBox();
            ChkBoxAlterarValorItens = new CheckBox();
            BtnSalvar = new Button();
            SuspendLayout();
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(173, 395);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(102, 35);
            BtnSalvar.TabIndex = 7;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // TxtMaxDescPedido
            // 
            TxtMaxDescPedido.Location = new Point(176, 24);
            TxtMaxDescPedido.MaxLength = 6;
            TxtMaxDescPedido.Name = "TxtMaxDescPedido";
            TxtMaxDescPedido.Size = new Size(69, 23);
            TxtMaxDescPedido.TabIndex = 0;
            TxtMaxDescPedido.TextChanged += TxtMaxDescPedido_TextChanged;
            TxtMaxDescPedido.KeyPress += TxtMaxDescPedido_KeyPress;
            // 
            // TxtMaxDescItemPedido
            // 
            TxtMaxDescItemPedido.Location = new Point(176, 72);
            TxtMaxDescItemPedido.MaxLength = 6;
            TxtMaxDescItemPedido.Name = "TxtMaxDescItemPedido";
            TxtMaxDescItemPedido.Size = new Size(69, 23);
            TxtMaxDescItemPedido.TabIndex = 1;
            TxtMaxDescItemPedido.TextChanged += TxtMaxDescItemPedido_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 27);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 2;
            label1.Text = "Max. Desconto Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 75);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 3;
            label2.Text = "Max. Desconto Itens Pedido";
            // 
            // ChkBoxPedido
            // 
            ChkBoxPedido.AutoSize = true;
            ChkBoxPedido.Location = new Point(251, 26);
            ChkBoxPedido.Name = "ChkBoxPedido";
            ChkBoxPedido.Size = new Size(192, 19);
            ChkBoxPedido.TabIndex = 4;
            ChkBoxPedido.Text = "Utilizar valor Padrão do Sistema";
            ChkBoxPedido.UseVisualStyleBackColor = true;
            ChkBoxPedido.CheckedChanged += ChkBoxPedido_CheckedChanged;
            // 
            // ChkBoxItemPedido
            // 
            ChkBoxItemPedido.AutoSize = true;
            ChkBoxItemPedido.Location = new Point(251, 76);
            ChkBoxItemPedido.Name = "ChkBoxItemPedido";
            ChkBoxItemPedido.Size = new Size(192, 19);
            ChkBoxItemPedido.TabIndex = 6;
            ChkBoxItemPedido.Text = "Utilizar valor Padrão do Sistema";
            ChkBoxItemPedido.UseVisualStyleBackColor = true;
            ChkBoxItemPedido.CheckedChanged += ChkBoxItemPedido_CheckedChanged;
            // 
            // BtnSair
            // 
            BtnSair.Location = new Point(405, 395);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(102, 35);
            BtnSair.TabIndex = 8;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // ChkBoxVendaEstoqueNegativo
            // 
            ChkBoxVendaEstoqueNegativo.AutoSize = true;
            ChkBoxVendaEstoqueNegativo.Location = new Point(19, 139);
            ChkBoxVendaEstoqueNegativo.Name = "ChkBoxVendaEstoqueNegativo";
            ChkBoxVendaEstoqueNegativo.Size = new Size(226, 19);
            ChkBoxVendaEstoqueNegativo.TabIndex = 9;
            ChkBoxVendaEstoqueNegativo.Text = "Permitir Venda com Estoque Negativo";
            ChkBoxVendaEstoqueNegativo.UseVisualStyleBackColor = true;
            // 
            // ChkBoxAlterarValorItens
            // 
            ChkBoxAlterarValorItens.AutoSize = true;
            ChkBoxAlterarValorItens.Location = new Point(19, 175);
            ChkBoxAlterarValorItens.Name = "ChkBoxAlterarValorItens";
            ChkBoxAlterarValorItens.Size = new Size(195, 19);
            ChkBoxAlterarValorItens.TabIndex = 10;
            ChkBoxAlterarValorItens.Text = "Permitir Alterar o Valor dos Itens";
            ChkBoxAlterarValorItens.UseVisualStyleBackColor = true;
            // 
            // FormConfiguracoesGerais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 488);
            ControlBox = false;
            Controls.Add(ChkBoxAlterarValorItens);
            Controls.Add(ChkBoxVendaEstoqueNegativo);
            Controls.Add(BtnSair);
            Controls.Add(BtnSalvar);
            Controls.Add(ChkBoxItemPedido);
            Controls.Add(ChkBoxPedido);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtMaxDescItemPedido);
            Controls.Add(TxtMaxDescPedido);
            KeyPreview = true;
            Name = "FormConfiguracoesGerais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuracoes Gerais";
            Load += FormConfiguracoesGerais_Load;
            KeyPress += FormConfiguracoesGerais_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtMaxDescPedido;
        private TextBox TxtMaxDescItemPedido;
        private Label label1;
        private Label label2;
        private CheckBox ChkBoxPedido;
        private CheckBox ChkBoxItemPedido;
        private Button BtnSair;
        private CheckBox ChkBoxVendaEstoqueNegativo;
        private CheckBox ChkBoxAlterarValorItens;
    }
}