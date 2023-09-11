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

        public Operador getSetOperador{
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
                // TELA DE ENTRADA
                quantiaTelas--;
            }

            // SE NÃO TIVER NENHUMA TELA LIBERADA, LIBERA A TELA DE PEDIDOS
            if (quantiaTelas < 0)
            {
                // LIBERAR TELA DE PEDIDOS
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
            FormPedido form = new FormPedido(operador);
            form.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormPedido>().Count() > 0)
            {
                // FORM JÁ ABERTO
                Application.OpenForms["FormCadastroProdutos"].BringToFront();
            }
            else
            {
                form.Show();
            }
        }

        private void configuraçõesGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracoesGerais formConfiguracoesGerais = new FormConfiguracoesGerais();
            //formConfiguracoesGerais.MdiParent = this;

            // VALIDA SE O FORM JÁ ESTÁ ABERTO
            if (Application.OpenForms.OfType<FormConfiguracoesGerais>().Count() > 0)
            {
                // FORM JÁ ABERTO
            }
            else
            {
                formConfiguracoesGerais.Show();
            }
        }

        private void MenuMainCadastroProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroProdutos formCadastroProdutos = new FormCadastroProdutos();
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
            FormCadastroClientes form = new FormCadastroClientes();
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
            FormCadastroFormaPGTO form = new FormCadastroFormaPGTO();
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
            FormCadastroCategoria form = new FormCadastroCategoria();
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
    }
}
