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
    public partial class FormCadastroProdutos : Form
    {
        public FormCadastroProdutos()
        {
            InitializeComponent();
        }

        private void BtnID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionou");
        }

        private void TxtID_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("->" + (byte)e.KeyValue);
            if (e.KeyValue == 115) // F4
            {
                BtnID_Click(sender, e);
            }
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("->" + (byte)e.KeyChar);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
        }

        private void TxtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
        }

        private void FormCadastroProdutos_Load(object sender, EventArgs e)
        {
            validarAcoes(2);  // 0 -> Novo | 1 -> Edição | 2 -> Visualização
        }

        private void validarAcoes(int state)  // 0 -> Novo | 1 -> Edição | 2 -> Visualização
        {
            if (state == 0)
            {
                // BOTÕES
                BtnNovo.Enabled = false;
                BtnAlterar.Enabled = false;
                BtnAvancar.Enabled = false;
                BtnVoltar.Enabled = false;
                BtnID.Enabled = false;

                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = false;

                // CAMPOS
                TxtID.Enabled = false;

                TxtNome.Enabled = true;
                TxtValor.Enabled = true;
                TxtCusto.Enabled = true;
                ChkBoxInativo.Enabled = true;
            }
            else if (state == 1)
            {
                BtnNovo.Enabled = false;
                BtnAlterar.Enabled = false;
                BtnAvancar.Enabled = false;
                BtnVoltar.Enabled = false;
                BtnID.Enabled = false;

                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = false;

                // CAMPOS
                TxtID.Enabled = false;

                TxtNome.Enabled = true;
                TxtValor.Enabled = true;
                TxtCusto.Enabled = true;
                ChkBoxInativo.Enabled = true;
            }
            else if (state == 2)
            {
                BtnNovo.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnAvancar.Enabled = true;
                BtnVoltar.Enabled = true;
                BtnID.Enabled = true;
                BtnCancelar.Enabled = true;

                BtnSalvar.Enabled = false;

                // CAMPOS
                TxtID.Enabled = true;

                TxtNome.Enabled = false;
                TxtValor.Enabled = false;
                TxtCusto.Enabled = false;
                ChkBoxInativo.Enabled = false;
            }

            preencherDados(state);
        }

        private void preencherDados(int state)
        {
            // 0 -> Novo | 1 -> Edição | 2 -> Visualização
            if (state == 0)
            {
                // PEGAR O ID DO PRODUTO
                // SELECT MAX + 1
                TxtID.Text = string.Empty;
                TxtNome.Text = string.Empty;
                TxtValor.Text = string.Empty;
                TxtCusto.Text = string.Empty;
                TxtEstoque.Text = string.Empty;
            }
            else if (state == 2) {
                 // PREENCHE COM AS INFORMAÇÕES DO PRODUTO
                 // SELECT * FROM PRODUTO WHERE (ID PRODUTO)
                 // EXECUTE CALCULA ESTOQUE (ID PRODUTO)
            }
        }
    }
}
