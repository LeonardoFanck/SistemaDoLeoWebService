using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDoLeoWebService
{
    public partial class FormMain : Form
    {
        private int ID;
        private Operador operador;

        public Operador getSetOperador
        {
            get { return operador; }
            set { operador = value; }
        }

        public FormMain(Operador operador)
        {
            this.operador = operador;

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            validarTelas();
        }

        public void validarTelas()
        {
            int quantiaTelas = 0;

            if (operador.getSetCadastroOperador)
            {
                MenuMainCadastroOperador.Visible = true;
                quantiaTelas--;
            }

            if (operador.getSetCadastroCategoria)
            {
                MenuMainCadastroCategoria.Visible = true;
                quantiaTelas--;
            }

            if (operador.getSetCadastroCliente)
            {
                MenuMainCadastroClienteFornecedor.Visible = true;
                quantiaTelas--;
            }

            if (operador.getSetCadastroProduto)
            {
                MenuMainCadastroProdutos.Visible = true;
                quantiaTelas--;
            }

            if (operador.getSetCadastroFormaPGTO)
            {
                MenuMainCadastroFormaPGTO.Visible = true;
                quantiaTelas--;
            }

            if (operador.getSetTabelaUsuario)
            {
                // TABELA DE USUÁRIOS (VER SE SERÁ FEITO)
                quantiaTelas--;
            }

            if (operador.getSetPedidos)
            {
                MenuMainPedidos.Visible = true;
                quantiaTelas--;
            }

            if (operador.getSetEntrada)
            {
                MenuMainEntradas.Visible = true;
                quantiaTelas--;
            }

            // SE NÃO TIVER NENHUMA TELA LIBERADA, LIBERA A TELA DE PEDIDOS
            if (quantiaTelas < 0)
            {
                MenuMainPedidos.Visible = true;
            }
        }

        private void infoSistemaDoLeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MOSTRA MENSAGEM DE INFORMAÇÃO DO SISTEMA
            MessageBox.Show("Sistema do Leo 2.0 - Versão C# \n" +
                            "----------------------------------------- \n" +
                            "Atualmente em Desenvolvimento",
                            "Sistema do Leo - Info.");
        }

        private void MenuMainPedidos_Click(object sender, EventArgs e)
        {
            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormPedido>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormPedido"].BringToFront();
            }
            else
            {
                FormPedido form = new FormPedido(this.operador, this);
                form.MdiParent = this;

                form.Show();
            }
        }

        private void configuraçõesGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (operador.getSetAdmin)
            {
                abrirConfiguracoes();
            }
            else
            {
                FormValidacaoOperador form = new FormValidacaoOperador(this);

                // FUNÇÃO PARA QUANDO FECHAR O CONFIGURAÇÕES GERAIS, ATIVAR NOVAMENTE O FORMA MAIN
                form.FormClosed += (sender, e) =>
                {
                    this.Enabled = true;
                };

                // INATIVA O FORM MAIN
                this.Enabled = false;

                form.Show();
            }
            
        }

        public void abrirConfiguracoes()
        {
            FormConfiguracoesGerais formConfiguracoesGerais = new FormConfiguracoesGerais();
            //formConfiguracoesGerais.MdiParent = this;

            // FUNÇÃO PARA QUANDO FECHAR O CONFIGURAÇÕES GERAIS, ATIVAR NOVAMENTE O FORMA MAIN
            formConfiguracoesGerais.FormClosed += (sender, e) =>
            {
                this.Enabled = true;
            };

            // INATIVA O FORM MAIN
            this.Enabled = false;
            formConfiguracoesGerais.Show();
        }

        private void MenuMainCadastroProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroProdutos formCadastroProdutos = new FormCadastroProdutos(this.operador, this);
            formCadastroProdutos.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormCadastroProdutos>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormCadastroProdutos"].BringToFront();
            }
            else
            {
                formCadastroProdutos.Show();
            }
        }

        private void MenuMainCadastroClienteFornecedor_Click(object sender, EventArgs e)
        {
            FormCadastroClientes form = new FormCadastroClientes(this.operador, this);
            form.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormCadastroClientes>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormCadastroClientes"].BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void MenuMainCadastroFormaPGTO_Click(object sender, EventArgs e)
        {
            FormCadastroFormaPGTO form = new FormCadastroFormaPGTO(this.operador, this);
            form.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormCadastroFormaPGTO>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormCadastroFormaPGTO"].BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void MenuMainCadastroCategoria_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria form = new FormCadastroCategoria(this.operador, this);
            form.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormCadastroCategoria>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormCadastroCategoria"].BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void MenuMainCadastroOperador_Click(object sender, EventArgs e)
        {
            FormCadastroOperador form = new FormCadastroOperador(this.operador, this);
            form.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormCadastroOperador>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormCadastroOperador"].BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void relatorioGeralDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorioPedidos form = new FormRelatorioPedidos(this.operador, this);
            form.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormRelatorioPedidos>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormRelatorioPedidos"].BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void MenuMainEntradas_Click(object sender, EventArgs e)
        {
            FormEntrada form = new FormEntrada(this.operador, this);
            form.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormEntrada>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormEntrada"].BringToFront();
            }
            else
            {
                form.Show();
            }
        }
    }
}
