namespace SistemaDoLeoWebService
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            MenuMainTelasDeAcesso = new ToolStripMenuItem();
            MenuMainPedidos = new ToolStripMenuItem();
            MenuMainCadastroClienteFornecedor = new ToolStripMenuItem();
            MenuMainCadastroProdutos = new ToolStripMenuItem();
            MenuMainCadastroFormaPGTO = new ToolStripMenuItem();
            MenuMainCadastroCategoria = new ToolStripMenuItem();
            MenuMainCadastroOperador = new ToolStripMenuItem();
            MenuMainRelatorios = new ToolStripMenuItem();
            relatorioGeralDePedidosToolStripMenuItem = new ToolStripMenuItem();
            MenuMainConfiguraçõesDoSistema = new ToolStripMenuItem();
            configuraçõesGeraisToolStripMenuItem = new ToolStripMenuItem();
            MenuMainSobre = new ToolStripMenuItem();
            MenuMainInfoSistemaDoLeo = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuMainTelasDeAcesso, MenuMainRelatorios, MenuMainConfiguraçõesDoSistema, MenuMainSobre });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1160, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "MenuMain";
            // 
            // MenuMainTelasDeAcesso
            // 
            MenuMainTelasDeAcesso.DropDownItems.AddRange(new ToolStripItem[] { MenuMainPedidos, MenuMainCadastroClienteFornecedor, MenuMainCadastroProdutos, MenuMainCadastroFormaPGTO, MenuMainCadastroCategoria, MenuMainCadastroOperador });
            MenuMainTelasDeAcesso.Name = "MenuMainTelasDeAcesso";
            MenuMainTelasDeAcesso.Size = new Size(100, 20);
            MenuMainTelasDeAcesso.Text = "Telas de Acesso";
            // 
            // MenuMainPedidos
            // 
            MenuMainPedidos.Name = "MenuMainPedidos";
            MenuMainPedidos.Size = new Size(226, 22);
            MenuMainPedidos.Text = "Pedidos";
            MenuMainPedidos.Visible = false;
            MenuMainPedidos.Click += MenuMainPedidos_Click;
            // 
            // MenuMainCadastroClienteFornecedor
            // 
            MenuMainCadastroClienteFornecedor.Name = "MenuMainCadastroClienteFornecedor";
            MenuMainCadastroClienteFornecedor.Size = new Size(226, 22);
            MenuMainCadastroClienteFornecedor.Text = "Cadastro Cliente/Fornecedor";
            MenuMainCadastroClienteFornecedor.Visible = false;
            MenuMainCadastroClienteFornecedor.Click += MenuMainCadastroClienteFornecedor_Click;
            // 
            // MenuMainCadastroProdutos
            // 
            MenuMainCadastroProdutos.Name = "MenuMainCadastroProdutos";
            MenuMainCadastroProdutos.Size = new Size(226, 22);
            MenuMainCadastroProdutos.Text = "Cadastro Produtos";
            MenuMainCadastroProdutos.Visible = false;
            MenuMainCadastroProdutos.Click += MenuMainCadastroProdutos_Click;
            // 
            // MenuMainCadastroFormaPGTO
            // 
            MenuMainCadastroFormaPGTO.Name = "MenuMainCadastroFormaPGTO";
            MenuMainCadastroFormaPGTO.Size = new Size(226, 22);
            MenuMainCadastroFormaPGTO.Text = "Cadastro FormaPGTO";
            MenuMainCadastroFormaPGTO.Visible = false;
            MenuMainCadastroFormaPGTO.Click += MenuMainCadastroFormaPGTO_Click;
            // 
            // MenuMainCadastroCategoria
            // 
            MenuMainCadastroCategoria.Name = "MenuMainCadastroCategoria";
            MenuMainCadastroCategoria.Size = new Size(226, 22);
            MenuMainCadastroCategoria.Text = "Cadastro Categoria";
            MenuMainCadastroCategoria.Visible = false;
            MenuMainCadastroCategoria.Click += MenuMainCadastroCategoria_Click;
            // 
            // MenuMainCadastroOperador
            // 
            MenuMainCadastroOperador.Name = "MenuMainCadastroOperador";
            MenuMainCadastroOperador.Size = new Size(226, 22);
            MenuMainCadastroOperador.Text = "Cadastro Operador";
            MenuMainCadastroOperador.Visible = false;
            MenuMainCadastroOperador.Click += MenuMainCadastroOperador_Click;
            // 
            // MenuMainRelatorios
            // 
            MenuMainRelatorios.DropDownItems.AddRange(new ToolStripItem[] { relatorioGeralDePedidosToolStripMenuItem });
            MenuMainRelatorios.Name = "MenuMainRelatorios";
            MenuMainRelatorios.Size = new Size(71, 20);
            MenuMainRelatorios.Text = "Relatórios";
            // 
            // relatorioGeralDePedidosToolStripMenuItem
            // 
            relatorioGeralDePedidosToolStripMenuItem.Name = "relatorioGeralDePedidosToolStripMenuItem";
            relatorioGeralDePedidosToolStripMenuItem.Size = new Size(212, 22);
            relatorioGeralDePedidosToolStripMenuItem.Text = "Relatorio Geral de Pedidos";
            // 
            // MenuMainConfiguraçõesDoSistema
            // 
            MenuMainConfiguraçõesDoSistema.DropDownItems.AddRange(new ToolStripItem[] { configuraçõesGeraisToolStripMenuItem });
            MenuMainConfiguraçõesDoSistema.Name = "MenuMainConfiguraçõesDoSistema";
            MenuMainConfiguraçõesDoSistema.Size = new Size(157, 20);
            MenuMainConfiguraçõesDoSistema.Text = "Configurações do Sistema";
            // 
            // configuraçõesGeraisToolStripMenuItem
            // 
            configuraçõesGeraisToolStripMenuItem.Name = "configuraçõesGeraisToolStripMenuItem";
            configuraçõesGeraisToolStripMenuItem.Size = new Size(186, 22);
            configuraçõesGeraisToolStripMenuItem.Text = "Configurações Gerais";
            configuraçõesGeraisToolStripMenuItem.Click += configuraçõesGeraisToolStripMenuItem_Click;
            // 
            // MenuMainSobre
            // 
            MenuMainSobre.DropDownItems.AddRange(new ToolStripItem[] { MenuMainInfoSistemaDoLeo });
            MenuMainSobre.Name = "MenuMainSobre";
            MenuMainSobre.Size = new Size(49, 20);
            MenuMainSobre.Text = "Sobre";
            // 
            // MenuMainInfoSistemaDoLeo
            // 
            MenuMainInfoSistemaDoLeo.Name = "MenuMainInfoSistemaDoLeo";
            MenuMainInfoSistemaDoLeo.Size = new Size(181, 22);
            MenuMainInfoSistemaDoLeo.Text = "Info. Sistema do Leo";
            MenuMainInfoSistemaDoLeo.Click += infoSistemaDoLeoToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 626);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuMainTelasDeAcesso;
        private ToolStripMenuItem MenuMainPedidos;
        private ToolStripMenuItem MenuMainRelatorios;
        private ToolStripMenuItem relatorioGeralDePedidosToolStripMenuItem;
        private ToolStripMenuItem MenuMainConfiguraçõesDoSistema;
        private ToolStripMenuItem configuraçõesGeraisToolStripMenuItem;
        private ToolStripMenuItem MenuMainSobre;
        private ToolStripMenuItem MenuMainInfoSistemaDoLeo;
        private ToolStripMenuItem MenuMainCadastroClienteFornecedor;
        private ToolStripMenuItem MenuMainCadastroProdutos;
        private ToolStripMenuItem MenuMainCadastroFormaPGTO;
        private ToolStripMenuItem MenuMainCadastroCategoria;
        private ToolStripMenuItem MenuMainCadastroOperador;
    }
}