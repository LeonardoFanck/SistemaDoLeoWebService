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

        public FormMain()
        {
            //this.ID = ID;

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

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
            // ABRIR TELA DE PEDIDOS

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
    }
}
