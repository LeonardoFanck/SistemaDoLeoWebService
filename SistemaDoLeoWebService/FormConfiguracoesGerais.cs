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
    public partial class FormConfiguracoesGerais : Form
    {
        private FormMain formMain;

        public FormConfiguracoesGerais()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void FormConfiguracoesGerais_Load(object sender, EventArgs e)
        {
            // PEGA A REFERENCIA DO WEB SERVICE
            var WebReference = new ServiceReference1.Service1Client();

            // CHAMA A FUNÇÃO PARA PEGAR AS INFORMAÇÕES E ARMAZENA ELAS
            ConfiguracoesGerais configuracoesGerais = WebReference.GetDadosConfiguracoesGeraisAsync().Result;

            // PREENCHE TXT MAX DESCONTO PEDIDO
            if (configuracoesGerais.getSetMaxDescontoPedido == -1)
            {
                TxtMaxDescPedido.Text = 0.ToString();
                ChkBoxPedido.Checked = true;
            }
            else
            {
                TxtMaxDescPedido.Text = configuracoesGerais.getSetMaxDescontoPedido.ToString();
            }

            // PREENCHE TXT MAX DESCONTO ITENS PEDIDO
            if (configuracoesGerais.getSetMaxDescontoItensPedido == -1)
            {
                TxtMaxDescItemPedido.Text = 0.ToString();
                ChkBoxItemPedido.Checked = true;
            }
            else
            {
                TxtMaxDescItemPedido.Text = configuracoesGerais.getSetMaxDescontoItensPedido.ToString();
            }

            // PREENCHE O CHK BOX PERMITE VENDA ESTOQUE NEGATIVO
            if (configuracoesGerais.getSetVendaItemNegativo == true)
            {
                ChkBoxVendaEstoqueNegativo.Checked = true;
            }
            else
            {
                ChkBoxVendaEstoqueNegativo.Checked = false;
            }

            // PREENCHE O CHK BOX PERMITE ALTERAR VALOR ITEM
            if (configuracoesGerais.getSetAlterarValorItem == true)
            {
                ChkBoxAlterarValorItens.Checked = true;
            }
            else
            {
                ChkBoxAlterarValorItens.Checked = false;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Vai gravar as alterações no banco!");
            int validacao;

            // VALIDA SE OS CAMPOS ESTÃO INFORMADOS
            if (!validarCampos())
            {
                MessageBox.Show("Necessário informar um valor!");
            }
            else
            {
                // PEGA A REFERENCIA DO WEB SERVICE
                var WebReference = new ServiceReference1.Service1Client();

                ConfiguracoesGerais config = new ConfiguracoesGerais();

                config.getSetMaxDescontoPedido = validarChkBox("DescontoPedido", ChkBoxPedido.Checked);
                config.getSetMaxDescontoItensPedido = validarChkBox("DescontoItensPedido", ChkBoxItemPedido.Checked);
                config.getSetVendaItemNegativo = Convert.ToBoolean(ChkBoxVendaEstoqueNegativo.Checked);
                config.getSetAlterarValorItem = Convert.ToBoolean(ChkBoxAlterarValorItens.Checked);

                validacao = WebReference.SalvarConfiguracoesGeraisAsync(config).Result;

                validarRetornoSave(validacao);
            }
        }

        private double validarChkBox(string ChkBoxNome, bool ChkBox)
        {
            double retorno = -1;

            if (ChkBox)
            {
                return -1;
            }
            else
            {
                if (ChkBoxNome.Equals("DescontoPedido"))
                {
                    retorno = Convert.ToDouble(TxtMaxDescPedido.Text);
                }
                else if (ChkBoxNome.Equals("DescontoItensPedido"))
                {
                    retorno = Convert.ToDouble(TxtMaxDescItemPedido.Text);
                }
            }

            return retorno;
        }

        private void validarRetornoSave(int validacao)
        {
            if (validacao == 0)
            {
                MessageBox.Show("Configurações Atualizadas!");
                this.Close();
            }
            else if (validacao == 1)
            {
                MessageBox.Show("Configurações Cadastradas!");
                this.Close();
            }
            else if (validacao == -1)
            {
                MessageBox.Show("Ocorreu um erro ao tentar salvar as Configurações!");
            }
        }

        private bool validarCampos()
        {
            if (TxtMaxDescPedido.Text.Equals(""))
            {
                TxtMaxDescPedido.Focus();

                return false;
            }

            if (TxtMaxDescItemPedido.Text.Equals(""))
            {
                TxtMaxDescItemPedido.Focus();

                return false;
            }

            return true;
        }

        private void TxtMaxDescPedido_TextChanged(object sender, EventArgs e)
        {
            if (TxtMaxDescPedido.Text != "")
            {
                if (Convert.ToDouble(TxtMaxDescPedido.Text) > 100)
                {
                    TxtMaxDescPedido.Text = "100,00";
                }

                if (Convert.ToDouble(TxtMaxDescPedido.Text) < 0)
                {
                    TxtMaxDescPedido.Text = "0,00";
                }
            }
        }

        private void TxtMaxDescPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Valor -> " + ((byte)e.KeyChar)); // PEGA O VALOR DA TECLA


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
        }

        private void ChkBoxPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxPedido.Checked)
            {
                TxtMaxDescPedido.Enabled = false;
            }
            else
            {
                TxtMaxDescPedido.Enabled = true;
            }
        }

        private void ChkBoxItemPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBoxItemPedido.Checked)
            {
                TxtMaxDescItemPedido.Enabled = false;
            }
            else
            {
                TxtMaxDescItemPedido.Enabled = true;
            }
        }

        private void TxtMaxDescItemPedido_TextChanged(object sender, EventArgs e)
        {
            if (TxtMaxDescItemPedido.Text != "")
            {
                if (Convert.ToDouble(TxtMaxDescItemPedido.Text) > 100)
                {
                    TxtMaxDescItemPedido.Text = "100,00";
                }

                if (Convert.ToDouble(TxtMaxDescItemPedido.Text) < 0)
                {
                    TxtMaxDescItemPedido.Text = "0,00";
                }
            }
        }

        private void FormConfiguracoesGerais_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
