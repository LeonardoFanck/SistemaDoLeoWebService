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
    public partial class FormPedido : Form
    {
        private string FormNome = "Pedidos";
        private Operador operadorLogado;
        private Pedido pedido;
        private Produto produto;
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

                // LIMPAR CAMPOS
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

                TxtNomeProduto.Text = produto.getSetNome;
                TxtValorItem.Text = produto.getSetValor.ToString();
                TxtQuantidadeItem.Text = "1";
                TxtDesconto.Text = "0";

                CalcularProduto();

                // FOCO PARA O PROXIMO CAMPO
                TxtValorItem.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
                limpaCamposItem();
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            getSetStatus = 1;
            validarAcoes();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            getSetStatus = 0;
            validarAcoes();

            try
            {
                var WebService = new ServiceReference1.Service1Client();

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

        public void limpaCampos()
        {
            TxtCliente.Text = string.Empty;
            TxtFormaPGTO.Text = string.Empty;
            MTxtData.Text = string.Empty;
            TxtValor.Text = string.Empty;
            TxtDesconto.Text = string.Empty;
            TxtValorFinal.Text = string.Empty;
        }

        public void limpaCamposItem()
        {
            TxtProduto.Text = string.Empty;
            TxtValorItem.Text = string.Empty;
            TxtQuantidadeItem.Text = string.Empty;
            TxtDescontoItem.Text = string.Empty;
            TxtValorFinalItem.Text = string.Empty;
            TxtNomeProduto.Text = string.Empty;
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
    }
}
