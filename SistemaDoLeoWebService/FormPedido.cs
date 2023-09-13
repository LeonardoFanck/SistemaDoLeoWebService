﻿using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDoLeoWebService
{
    public partial class FormPedido : Form
    {
        private string FormNome = "Pedidos";
        private Operador operadorLogado;
        private Pedido pedido;
        private Produto produto;
        private ConfiguracoesGerais configuracoes;
        private int Status;

        public FormPedido(Operador operador)
        {
            this.operadorLogado = operador;

            InitializeComponent();
        }
        public int getSetStatus
        {
            // 0 -> Novo Cadastro | 1 -> Edição | 2 -> Visualização
            get { return this.Status; }
            set { this.Status = value; }
        }

        private void FormPedido_Load(object sender, EventArgs e)
        {
            // PEGA AS CONFIGURAÇÕES GERAIS
            getConfiguracoes();

            // LIMPA OS CAMPOS DO ESTOQUE
            limpaCamposEstoque();

            getSetStatus = 2; // 2 -> Visualização
            validarAcoes();  // 0 -> Novo | 1 -> Edição | 2 -> Visualização
            ultimoRegistro();
        }

        private void validarAcoes()
        {
            if (getSetStatus == 0)
            {
                // BOTÕES
                BtnNovo.Enabled = false;
                BtnAlterar.Enabled = false;
                BtnAvancar.Enabled = false;
                BtnVoltar.Enabled = false;
                BtnID.Enabled = false;

                BtnCliente.Enabled = true;
                BtnFormaPGTO.Enabled = true;
                BtnProduto.Enabled = true;
                BtnAdicionarItem.Enabled = true;
                BtnRemoverItem.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = true;

                // CAMPOS
                TxtID.Enabled = false;

                TxtCliente.Enabled = true;
                TxtFormaPGTO.Enabled = true;
                MTxtData.Enabled = true;
                TxtValor.Enabled = true;
                TxtDesconto.Enabled = true;
                TxtValorFinal.Enabled = true;
                TxtProduto.Enabled = true;
                TxtValorItem.Enabled = true;
                TxtQuantidadeItem.Enabled = true;
                TxtDescontoItem.Enabled = true;
                TxtValorFinalItem.Enabled = true;

                // PERMISSÃO ADMIN
                if (operadorLogado.getSetAdmin == false)
                {
                    BtnLiberarPedido.Visible = true;
                }

                // VALIDAR CONFIGURAÇÕES
                if (configuracoes.getSetAlterarValorItem == false)
                {
                    TxtValorItem.ReadOnly = true;
                }

                // LIMPAR CAMPOS
                GridViewItens.Rows.Clear();
                limpaCampos();
                limpaCamposItem();
            }
            else if (getSetStatus == 1)
            {
                // BOTÕES
                BtnNovo.Enabled = false;
                BtnAlterar.Enabled = false;
                BtnAvancar.Enabled = false;
                BtnVoltar.Enabled = false;
                BtnID.Enabled = false;

                BtnCliente.Enabled = true;
                BtnFormaPGTO.Enabled = true;
                BtnProduto.Enabled = true;
                BtnAdicionarItem.Enabled = true;
                BtnRemoverItem.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = true;

                // CAMPOS
                TxtID.Enabled = false;

                TxtCliente.Enabled = true;
                TxtFormaPGTO.Enabled = true;
                MTxtData.Enabled = true;
                TxtValor.Enabled = true;
                TxtDesconto.Enabled = true;
                TxtValorFinal.Enabled = true;
                TxtProduto.Enabled = true;
                TxtValorItem.Enabled = true;
                TxtQuantidadeItem.Enabled = true;
                TxtDescontoItem.Enabled = true;
                TxtValorFinalItem.Enabled = true;

                // PERMISSÃO ADMIN
                if (operadorLogado.getSetAdmin == false)
                {
                    BtnLiberarPedido.Visible = true;
                }
            }
            else if (getSetStatus == 2)
            {
                // BOTÕES
                BtnNovo.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnAvancar.Enabled = true;
                BtnVoltar.Enabled = true;
                BtnID.Enabled = true;

                BtnCliente.Enabled = false;
                BtnFormaPGTO.Enabled = false;
                BtnProduto.Enabled = false;
                BtnAdicionarItem.Enabled = false;
                BtnRemoverItem.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnSalvar.Enabled = false;

                // CAMPOS
                TxtID.Enabled = true;

                TxtCliente.Enabled = false;
                TxtFormaPGTO.Enabled = false;
                MTxtData.Enabled = false;
                TxtValor.Enabled = false;
                TxtDesconto.Enabled = false;
                TxtValorFinal.Enabled = false;
                TxtProduto.Enabled = false;
                TxtValorItem.Enabled = false;
                TxtQuantidadeItem.Enabled = false;
                TxtDescontoItem.Enabled = false;
                TxtValorFinalItem.Enabled = false;
            }
        }

        private void ultimoRegistro()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                pedido = WebService.GetRegistroInicialPedidoAsync().Result;

                TxtID.Text = pedido.getSetID.ToString();
                TxtCliente.Text = pedido.getSetCliente.ToString();
                TxtFormaPGTO.Text = pedido.getSetFormaPGTO.ToString();
                TxtValor.Text = pedido.getSetValor.ToString();
                TxtDesconto.Text = pedido.getSetDesconto.ToString();
                TxtValorFinal.Text = pedido.getSetValorTotal.ToString();
                MTxtData.Text = pedido.getSetData.ToString();

                // PREENCHE O GRID COM OS ITENS DO PEDIDO
                PreencherGridPedidos(pedido.getSetID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, FormNome);
            }
        }

        private void preencheDados(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                pedido = WebService.GetPedidoAsync(ID).Result;

                TxtID.Text = pedido.getSetID.ToString();
                TxtCliente.Text = pedido.getSetCliente.ToString();
                TxtFormaPGTO.Text = pedido.getSetFormaPGTO.ToString();
                TxtValor.Text = pedido.getSetValor.ToString();
                TxtDesconto.Text = pedido.getSetDesconto.ToString();
                TxtValorFinal.Text = pedido.getSetValorTotal.ToString();

                // PREENCHE O GRID COM OS ITENS DO PEDIDO
                PreencherGridPedidos(pedido.getSetID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, FormNome);
            }
        }

        private void preencheProduto(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                produto = WebService.GetProdutoAsync(ID).Result;
                LblEstoqueAtual.Text = WebService.GetEstoqueProdutoAsync(ID).Result.ToString();

                TxtNomeProduto.Text = produto.getSetNome;
                TxtValorItem.Text = produto.getSetValor.ToString();
                TxtQuantidadeItem.Text = "1";
                TxtDescontoItem.Text = "0,00";

                calcularProduto();
                calculaEstoqueProduto();

                // FOCO PARA O PROXIMO CAMPO
                TxtValorItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
                limpaCamposItem();
            }
        }

        private void calcularProduto()
        {
            try
            {
                double valor;
                double quantidade;
                double desconto;

                if (TxtValorItem.Text == "")
                {
                    TxtValorItem.Text = produto.getSetValor.ToString();
                }

                if (TxtQuantidadeItem.Text == "")
                {
                    TxtQuantidadeItem.Text = "1";
                }

                if (TxtDescontoItem.Text == "")
                {
                    TxtDescontoItem.Text = "0,00";
                }

                valor = Convert.ToDouble(TxtValorItem.Text);
                quantidade = Convert.ToDouble(TxtQuantidadeItem.Text);
                desconto = Convert.ToDouble(TxtDescontoItem.Text) * 0.01;

                double valorFinal = valor * quantidade;

                valorFinal -= valorFinal * desconto;

                TxtValorFinalItem.Text = valorFinal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            getSetStatus = 1;
            validarAcoes();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                getSetStatus = 0;
                validarAcoes();

                TxtID.Text = WebService.GetProximoRegistroPedidoAsync().Result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, FormNome);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            validarCancelamento();
        }

        public void validarCancelamento()
        {
            DialogResult validar;

            if (getSetStatus == 0)
            {
                validar = MessageBox.Show("Deseja cancelar o Cadastro?", FormNome, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    // LIMPA OS CAMPOS
                    limpaCamposItem();
                    limpaCamposEstoque();

                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(pedido.getSetID);
                }
            }
            else if (getSetStatus == 1)
            {
                validar = MessageBox.Show("Deseja cancelar a Alteração?", FormNome, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    // LIMPA OS CAMPOS
                    limpaCamposItem();
                    limpaCamposEstoque();

                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(pedido.getSetID);
                }
            }
            else if (getSetStatus == 2)
            {
                this.Close();
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                int ID = WebService.VoltarRegistroPedidoAsync(Convert.ToInt32(TxtID.Text)).Result;

                preencheDados(ID);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message, NomeForm);
                //TxtID.Text = formaPGTO.getSetID.ToString();
            }
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                int ID = WebService.AvancarRegistroPedidoAsync(Convert.ToInt32(TxtID.Text)).Result;

                preencheDados(ID);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message, NomeForm);
                //TxtID.Text = formaPGTO.getSetID.ToString();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            int ID;

            try
            {
                var WebService = new ServiceReference1.Service1Client();

                if (getSetStatus == 0)
                {
                    ID = -1;
                }
                else
                {
                    ID = Convert.ToInt32(TxtID.Text);
                }

                if (validarCampos() == true)
                {
                    Pedido pedido = new Pedido();
                    pedido.getSetID = ID;
                    pedido.getSetCliente = Convert.ToInt32(TxtCliente.Text);
                    pedido.getSetFormaPGTO = Convert.ToInt32(TxtFormaPGTO.Text);
                    pedido.getSetValor = Convert.ToDouble(TxtValor.Text);
                    pedido.getSetDesconto = Convert.ToDouble(TxtDesconto.Text);
                    pedido.getSetValorTotal = Convert.ToDouble(TxtValorFinal.Text);
                    pedido.getSetData = MTxtData.Text;

                    // NÃO IMPLEMENTEI AINDA -> VOU VER
                    //validarNome(operador);

                    //validarRetorno(WebService.SalvarOperadorAsync(pedido).Result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, FormNome);
            }
        }

        public bool validarCampos()
        {
            if (TxtCliente.Text == "")
            {
                MessageBox.Show("Necessário informar um Cliente", FormNome);
                TxtCliente.Focus();
                return false;
            }
            else if (TxtFormaPGTO.Text == "")
            {
                MessageBox.Show("Necessário informar uma Forma de Pagamento", FormNome);
                TxtFormaPGTO.Focus();
                return false;
            }
            else if (MTxtData.Text == "")
            {
                MessageBox.Show("Necessário informar uma Data", FormNome);
                MTxtData.Focus();
                return false;
            }
            else if (TxtValor.Text == "")
            {
                MessageBox.Show("Necessário informar o Pedido ter um Valor", FormNome);
                TxtValor.Focus();
                return false;
            }
            else if (TxtValorFinal.Text == "")
            {
                MessageBox.Show("Necessário informar Valor Total ao Pedido", FormNome);
                TxtValorFinal.Focus();
                return false;
            }

            return true;
        }

        public void validarRetorno(int retorno)
        {
            if (retorno == 0)
            {
                MessageBox.Show("Registro alterado com Sucesso!", FormNome);
                getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                validarAcoes();
            }
            else if (retorno == 1)
            {
                MessageBox.Show("Registro cadastrado com Sucesso!", FormNome);
                getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                validarAcoes();
                ultimoRegistro();
            }
        }

        private void limpaCampos()
        {
            TxtCliente.Text = string.Empty;
            TxtFormaPGTO.Text = string.Empty;
            MTxtData.Text = string.Empty;
            TxtValor.Text = string.Empty;
            TxtDesconto.Text = string.Empty;
            TxtValorFinal.Text = string.Empty;
        }

        private void limpaCamposItem()
        {
            TxtProduto.Text = string.Empty;
            TxtValorItem.Text = string.Empty;
            TxtQuantidadeItem.Text = string.Empty;
            TxtDescontoItem.Text = string.Empty;
            TxtValorFinalItem.Text = string.Empty;
            TxtNomeProduto.Text = string.Empty;
        }

        private void limpaCamposEstoque()
        {
            LblEstoqueAtual.Text = string.Empty;
            LblQuantidadeVenda.Text = string.Empty;
            LblLinhaSoma.Visible = false;
            LblNovoEstoque.Text = string.Empty;
        }

        private void PreencherGridPedidos(int ID)
        {
            var WebService = new ServiceReference1.Service1Client();

            var lista = WebService.GetPedidoItensAsync(ID).Result;

            GridViewItens.Rows.Clear();

            foreach (var item in lista)
            {
                GridViewItens.Rows.Add(item.getSetItemID, item.getSetPedidoID, item.getSetProduto, item.getSetItemNomeProduto, item.getSetItemValor, item.getSetQuantidade, item.getSetItemDesconto, item.getSetItemValorTotal);
            }
        }

        private void TxtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                if (TxtProduto.Text != string.Empty)
                {
                    preencheProduto(Convert.ToInt32(TxtProduto.Text));
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Informe um produto!", FormNome);
                    limpaCamposItem();
                }
            }
        }

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtValorItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtDescontoItem.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtQuantidadeItem.Focus();

                e.Handled = true;
            }
        }

        private void TxtValorItem_Leave(object sender, EventArgs e)
        {
            if (TxtProduto.Text != string.Empty)
            {
                TxtValorItem.Text = Convert.ToDecimal(TxtValorItem.Text).ToString("N2");

                calcularProduto();
            }
            else
            {
                MessageBox.Show("Informe um produto!", FormNome);
                TxtProduto.Focus();
                limpaCamposItem();
            }
        }

        private void TxtQuantidadeItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtDescontoItem.Focus();

                e.Handled = true;
            }
        }

        private void TxtQuantidadeItem_Leave(object sender, EventArgs e)
        {
            if (TxtProduto.Text != string.Empty)
            {
                calcularProduto();
            }
            else
            {
                MessageBox.Show("Informe um produto!", FormNome);
                TxtProduto.Focus();
                limpaCamposItem();
            }
        }

        private void TxtDescontoItem_Leave(object sender, EventArgs e)
        {
            if (TxtProduto.Text != string.Empty)
            {
                TxtDescontoItem.Text = Convert.ToDecimal(TxtDescontoItem.Text).ToString("N2");

                calcularProduto();
            }
            else
            {
                MessageBox.Show("Informe um produto!", FormNome);
                TxtProduto.Focus();
                limpaCamposItem();
            }
        }

        private void TxtDescontoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtDescontoItem.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtValorFinalItem.Focus();

                e.Handled = true;
            }
        }

        private void getConfiguracoes()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                configuracoes = WebService.GetDadosConfiguracoesGeraisAsync().Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void BtnAdicionarItem_Click(object sender, EventArgs e)
        {
            try
            {
                int estoque = Convert.ToInt32(LblNovoEstoque.Text);

                if (configuracoes.getSetVendaItemNegativo == false && estoque < 0)
                {
                    MessageBox.Show("Estoque insuficiente!", FormNome);
                }
                else
                {
                    //adicionarItem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void TxtDescontoItem_TextChanged(object sender, EventArgs e)
        {
            if (configuracoes.getSetMaxDescontoItensPedido == -1)
            {
                if (TxtDescontoItem.Text == "")
                {

                }
                else if (Convert.ToDouble(TxtDescontoItem.Text) > 100)
                {
                    TxtDescontoItem.Text = "100,00";
                }
            }
            else if (Convert.ToDouble(TxtDescontoItem.Text) > configuracoes.getSetMaxDescontoItensPedido)
            {
                TxtDescontoItem.Text = configuracoes.getSetMaxDescontoItensPedido.ToString();
            }
        }

        private void TxtQuantidadeItem_TextChanged(object sender, EventArgs e)
        {
            calculaEstoqueProduto();
        }

        private void calculaEstoqueProduto()
        {
            try
            {
                int estoqueAtual = Convert.ToInt32(LblEstoqueAtual.Text);
                int quantidade;
                int novoEstoque;

                if (TxtQuantidadeItem.Text == "")
                {
                    quantidade = 0;
                }
                else
                {
                    quantidade = Convert.ToInt32(TxtQuantidadeItem.Text);
                }

                novoEstoque = estoqueAtual - quantidade;

                LblQuantidadeVenda.Text = " - " + quantidade.ToString();
                LblLinhaSoma.Visible = true;

                LblNovoEstoque.Text = novoEstoque.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void TxtValorItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblEstoqueAtual_Click(object sender, EventArgs e)
        {

        }

        private void TxtValorFinalItem_TextChanged(object sender, EventArgs e)
        {
            if (TxtValorFinalItem.Text != "")
            {
                TxtValorFinalItem.Text = Convert.ToDecimal(TxtValorFinalItem.Text).ToString("N2");
            }
        }

        private void BtnRemoverItem_Click(object sender, EventArgs e)
        {
            if (GridViewItens.CurrentRow != null)
            {
                MessageBox.Show(GridViewItens.CurrentRow.Cells["IDItemPedido"].Value.ToString());
            }
            else
            {
                MessageBox.Show("Selecione um item para Excluír!", FormNome);
            }
        }
    }
}
