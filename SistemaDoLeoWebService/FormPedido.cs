using FastReport;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace SistemaDoLeoWebService
{
    public partial class FormPedido : Form
    {
        private string FormNome = "Pedidos";
        private Operador operadorLogado;
        private FormMain formMain;
        private Pedido pedido;
        private Produto produto;
        private ConfiguracoesGerais configuracoes;
        private int Status;
        private int contadorItemOrigial;
        private List<PedidoItens> pedidoItensOriginais;
        private List<PedidoItens> itensPedidoAlterado;

        public FormPedido(Operador operador, FormMain formMain)
        {
            this.operadorLogado = operador;
            this.formMain = formMain;

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

            this.Text = FormNome;

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

                // ALTERA O NOME DO BOTÃO CONFIRMAR
                BtnSalvar.Text = "Finalizar";

                // ALTERA O PRODUTO PARA DESATIVAR TODOS OS CAMPOS
                TxtProduto.Text = "1";
                TxtProduto.Text = string.Empty;

                // LIMPAR CAMPOS
                GridViewItens.Rows.Clear();
                limpaCampos();
                limpaCamposItem();

                MTxtData.Focus();
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

                // ALTERA O NOME DO BOTÃO CONFIRMAR
                BtnSalvar.Text = "Salvar";

                MTxtData.Focus();
            }
            else if (getSetStatus == 2)
            {
                // BOTÕES
                BtnNovo.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnAvancar.Enabled = true;
                BtnVoltar.Enabled = true;
                BtnID.Enabled = true;
                BtnSalvar.Enabled = true;

                BtnCliente.Enabled = false;
                BtnFormaPGTO.Enabled = false;
                BtnProduto.Enabled = false;
                BtnAdicionarItem.Enabled = false;
                BtnRemoverItem.Enabled = false;
                BtnCancelar.Enabled = false;

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

                // ALTERA O NOME DO BOTÃO CONFIRMAR
                BtnSalvar.Text = "Imprimir";

                MTxtData.Focus();
            }
        }

        private void ultimoRegistro()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                pedido = WebService.GetRegistroInicialPedidoAsync().Result;

                TxtID.Text = pedido.getSetID.ToString();
                MTxtData.Text = pedido.getSetData.ToString();
                TxtCliente.Text = pedido.getSetCliente.ToString();
                TxtFormaPGTO.Text = pedido.getSetFormaPGTO.ToString();
                TxtValor.Text = pedido.getSetValor.ToString();
                TxtDesconto.Text = pedido.getSetDesconto.ToString();
                TxtValorFinal.Text = pedido.getSetValorTotal.ToString();

                // CRIA A LISTA DE ITENS ORGINAIS DO PEDIDO
                pedidoItensOriginais = new List<PedidoItens>();

                // CRIA A LISTA DE ITENS EDITADOS
                itensPedidoAlterado = new List<PedidoItens>();

                // DEFINE O CONTADOR COMO 0
                contadorItemOrigial = 0;

                // PREENCHE O GRID COM OS ITENS DO PEDIDO
                PreencherGridPedidos(pedido.getSetID);
                contadorItemOrigial++;

                // PREENCHE AS INFORMÇÕES DO CLIENTE E FORMA PGTO
                validarCliente(pedido.getSetCliente);
                validarFormaPGTO(pedido.getSetFormaPGTO);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, FormNome);
            }
        }

        public void preencheDados(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                pedido = WebService.GetPedidoAsync(ID).Result;

                TxtID.Text = pedido.getSetID.ToString();
                MTxtData.Text = pedido.getSetData.ToString();
                TxtCliente.Text = pedido.getSetCliente.ToString();
                TxtFormaPGTO.Text = pedido.getSetFormaPGTO.ToString();
                TxtValor.Text = pedido.getSetValor.ToString();
                TxtDesconto.Text = pedido.getSetDesconto.ToString();
                TxtValorFinal.Text = pedido.getSetValorTotal.ToString();

                // CRIA A LISTA DE ITENS ORGINAIS DO PEDIDO
                pedidoItensOriginais = new List<PedidoItens>();

                // CRIA A LISTA DE ITENS EDITADOS
                itensPedidoAlterado = new List<PedidoItens>();

                // DEFINE O CONTADOR COMO 0
                contadorItemOrigial = 0;

                // PREENCHE O GRID COM OS ITENS DO PEDIDO
                PreencherGridPedidos(pedido.getSetID);
                contadorItemOrigial++;

                // PREENCHE AS INFORMÇÕES DO CLIENTE E FORMA PGTO
                validarCliente(pedido.getSetCliente);
                validarFormaPGTO(pedido.getSetFormaPGTO);

                // MANTEM SEMPRE O TXT ID COM O TEXTO SELECIONADO
                TxtID.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, FormNome);

                TxtID.Text = pedido.getSetID.ToString();
                TxtID.SelectAll();
            }
        }

        public void preencheProduto(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                produto = WebService.GetProdutoAsync(ID).Result;
                
                if (produto.getSetStatus)
                {
                    MessageBox.Show("Produto Inativo!", FormNome);
                    limpaCamposItem();
                }
                else
                {
                    LblEstoqueAtual.Text = WebService.GetEstoqueProdutoAsync(ID).Result.ToString();
                    TxtProduto.Text = produto.getSetID.ToString();
                    TxtNomeProduto.Text = produto.getSetNome;
                    TxtValorItem.Text = produto.getSetValor.ToString();
                    TxtQuantidadeItem.Text = "1";
                    TxtDescontoItem.Text = "0,00";

                    calcularProduto();
                    calculaEstoqueProduto();
                }                
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

                    // EXCLUI OS ITENS DO PEDIDO
                    excluirItens(Convert.ToInt32(TxtID.Text));

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

                    // EXCLUI OS PEDIDOS QUE FORAM ADICIONADOS
                    excluirItensPedidoAlterado();
                    // LIMPA LISTA DE PRODUTOS 
                    itensPedidoAlterado.Clear();

                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(pedido.getSetID);
                }
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
            try
            {
                // SE ESTIVER EM MODO VISUALIZAÇÃO, IRÁ IMPRIMIR
                if (getSetStatus == 2)
                {
                    validarImpressaoPedido();
                }
                // SENÃO IRÁ SALVAR | ALTERAR
                else
                {
                    int ID;

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

                        // VALIDA O VALOR DO PEDIDO -> FINALIZA O PEDIDO
                        validarValorPedido(pedido);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, FormNome);
            }
        }

        private void validarValorPedido(Pedido pedido)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();
                DialogResult validar;
                int ID = Convert.ToInt32(TxtID.Text);

                double valor = WebService.VerificarValorPedidoAsync(ID).Result;

                if (valor == pedido.getSetValorTotal)
                {
                    finalizarPedido(pedido);
                }
                else
                {
                    validar = MessageBox.Show("Valor do Pedido alterado Manualmente, deseja Prosseguir?", FormNome, MessageBoxButtons.YesNo);

                    if (validar == System.Windows.Forms.DialogResult.Yes)
                    {
                        finalizarPedido(pedido);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);

            }
        }


        //[STAThread] para utiliazar o CTRL + C
        private void finalizarPedido(Pedido pedido)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                validarRetorno(WebService.FinalizarPedidoAsync(pedido).Result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
                //Clipboard.SetText(ex.Message + " - " + ex.Source); CTRL + C
            }
        }

        private void validarRetorno(int retorno)
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

                validarImpressaoPedido();

                getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                validarAcoes();
                ultimoRegistro();
            }
        }

        private void validarImpressaoPedido()
        {
            DialogResult imprimir;
            imprimir = MessageBox.Show("Deseja imprimir o Pedido?", $"Impressão Pedido - {TxtID.Text}", MessageBoxButtons.YesNo);

            if (imprimir == System.Windows.Forms.DialogResult.Yes)
            {
                impressaoPedido();
            }
        }

        private void impressaoPedido()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();
                var dtItens = new DataTable();
                var dtPedido = new DataTable();
                PedidoComDados pedido;

                PedidoComDados pedidoComDados = WebService.GetPedidoComDadosAsync(Convert.ToInt32(TxtID.Text)).Result;

                dtPedido.Columns.Add("CodPedido");
                dtPedido.Columns.Add("Data");
                dtPedido.Columns.Add("Cliente");
                dtPedido.Columns.Add("FormaPGTO");
                dtPedido.Columns.Add("PedidoValor");
                dtPedido.Columns.Add("PedidoDesconto");
                dtPedido.Columns.Add("PedidoValorTotal");

                dtPedido.Rows.Add(pedidoComDados.getSetID, pedidoComDados.getSetData, pedidoComDados.getSetCliente, pedidoComDados.getSetFormaPGTO, pedidoComDados.getSetValor, pedidoComDados.getSetDesconto, pedidoComDados.getSetValorTotal);

                List<PedidoItens> itens = new List<PedidoItens>(WebService.GetPedidoItensAsync(Convert.ToInt32(TxtID.Text)).Result);

                dtItens.Columns.Add("ID");
                dtItens.Columns.Add("Nome");
                dtItens.Columns.Add("Valor");
                dtItens.Columns.Add("Quantidade");
                dtItens.Columns.Add("Desconto");
                dtItens.Columns.Add("ValorTotal");

                foreach (var item in itens)
                {
                    dtItens.Rows.Add(item.getSetProduto, item.getSetItemNomeProduto, item.getSetItemValor, item.getSetQuantidade, item.getSetItemDesconto, item.getSetItemValorTotal);
                }

                // ABRE O FORMULÁRIO DE IMPESSAO
                using (var formImpressao = new FormImpressoes(dtPedido, dtItens))
                    formImpressao.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private bool validarCampos()
        {
            if (MTxtData.Text == "  /  /")
            {
                MessageBox.Show("Necessário informar uma Data", FormNome);
                MTxtData.Focus();
                return false;
            }
            else if (TxtCliente.Text == "")
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
            else if (GridViewItens.Rows.Count < 1)
            {
                MessageBox.Show("Necessário informar ao menos um Item no Pedido", FormNome);
                TxtProduto.Focus();
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

        private void limpaCampos()
        {
            TxtCliente.Text = string.Empty;
            TxtClienteNome.Text = string.Empty;
            TxtFormaPGTO.Text = string.Empty;
            TxtFormaPGTONome.Text = string.Empty;
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
            itensPedidoAlterado.Clear();

            foreach (var item in lista)
            {
                GridViewItens.Rows.Add(item.getSetItemID, item.getSetPedidoID, item.getSetProduto, item.getSetItemNomeProduto, item.getSetItemValor, item.getSetQuantidade, item.getSetItemDesconto, item.getSetItemValorTotal);

                // SE FOR A PRIMEIRA BUSCA NO MODO DE EDIÇÃO, VAI ADICIONAR OS ITENS QUE JÁ ESTAVAM NO
                // PEDIDO NA LISTA "pedidoItensOriginais"
                // CONTADOR RESETA QUANDO MUDA O STATUS
                if (contadorItemOrigial < 1)
                {
                    pedidoItensOriginais.Add(item);
                }
                else if (getSetStatus == 1)
                {
                    // VALIDA OS ITENS NOVOS (QUE FORAM ADICIONADOS NO MODO DE EDIÇÃO)
                    // ADICIONA ELES NA LISTA "itensPedidoAlterado" PARA QUE POSSA EXCLUIR CASO CANCELE
                    // A ALTERAÇÃO
                    if (!pedidoItensOriginais.Any(itensOriginais => itensOriginais.getSetItemID == item.getSetItemID))
                    {
                        itensPedidoAlterado.Add(item);
                    }
                }
            }

            // AJUSTA AS CASAS DECIMAIS DO PEDIDO
            ajustarValorPedido();

            // ORDENA A LISTA PELA ORDEM QUE ENTROU OS PRODUTOS
            GridViewItens.Sort(GridViewItens.Columns["IDItemPedido"], ListSortDirection.Ascending);
        }

        private void TxtProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                // FOCO PARA O PROXIMO CAMPO
                TxtValorItem.Focus();
                e.Handled = true;
            }
        }

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {
            if (TxtProduto.Text != string.Empty)
            {
                TxtValorItem.Enabled = true;
                TxtQuantidadeItem.Enabled = true;
                TxtDescontoItem.Enabled = true;
                TxtValorFinalItem.Enabled = true;
                BtnAdicionarItem.Enabled = true;
            }
            else
            {
                TxtValorItem.Enabled = false;
                TxtQuantidadeItem.Enabled = false;
                TxtDescontoItem.Enabled = false;
                TxtValorFinalItem.Enabled = false;
                BtnAdicionarItem.Enabled = false;
                limpaCamposItem();
                limpaCamposEstoque();
            }

        }

        private void TxtValorItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtValorItem.Text.Contains(","))
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
            if (TxtProduto.Text != string.Empty && TxtValorItem.Text != string.Empty)
            {
                TxtValorItem.Text = Convert.ToDecimal(TxtValorItem.Text).ToString("N2");

                calcularProduto();
            }
            else
            {
                //MessageBox.Show("Informe um produto!", FormNome);
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
                //MessageBox.Show("Informe um produto!", FormNome);
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
                //MessageBox.Show("Informe um produto!", FormNome);
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
                    PedidoItens item = new PedidoItens();
                    item.getSetPedidoID = Convert.ToInt32(TxtID.Text);
                    item.getSetProduto = Convert.ToInt32(TxtProduto.Text);
                    item.getSetItemValor = Convert.ToDouble(TxtValorItem.Text);
                    item.getSetQuantidade = Convert.ToInt32(TxtQuantidadeItem.Text);
                    item.getSetItemDesconto = Convert.ToDouble(TxtDescontoItem.Text);
                    item.getSetItemValorTotal = Convert.ToDouble(TxtValorFinalItem.Text);

                    adicionarItem(item);

                    MessageBox.Show("Item adicionado com Sucesso!", FormNome);

                    // PREENCHE O GRID COM OS ITENS DO PEDIDO
                    PreencherGridPedidos(item.getSetPedidoID);

                    // LIMPA AS INFORMAÇÕES DO PRODUTO
                    limpaCamposItem();
                    limpaCamposEstoque();

                    // FUNÇÃO PARA CALCULAR O VALOR DO PEDIDO
                    getValorPedido();
                    calcularPedido();

                    // FOCO NOVAMENTE PARA O TXT PRODUTO
                    TxtProduto.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void calcularPedido()
        {
            try
            {
                double valor;
                double desconto;
                double valorFinal = 0;

                if (TxtValor.Text == "")
                {
                    TxtValor.Text = "0,00";
                }

                if (TxtDesconto.Text == "")
                {
                    TxtDesconto.Text = "0,00";
                }

                if (TxtValorFinal.Text == "")
                {
                    TxtValorFinal.Text = "0,00";
                }

                valor = Convert.ToDouble(TxtValor.Text);
                desconto = Convert.ToDouble(TxtDesconto.Text) * 0.01;

                valorFinal = valor - (valor * desconto);

                TxtValorFinal.Text = valorFinal.ToString();

                ajustarValorPedido();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void ajustarValorPedido()
        {
            if (TxtValor.Text != string.Empty && TxtValor.Text != string.Empty)
            {
                TxtValor.Text = Convert.ToDecimal(TxtValor.Text).ToString("N2");
            }

            if (TxtDesconto.Text != string.Empty && TxtDesconto.Text != string.Empty)
            {
                TxtDesconto.Text = Convert.ToDecimal(TxtDesconto.Text).ToString("N2");
            }

            if (TxtValorFinal.Text != string.Empty && TxtValorFinal.Text != string.Empty)
            {
                TxtValorFinal.Text = Convert.ToDecimal(TxtValorFinal.Text).ToString("N2");
            }
        }

        private void getValorPedido()
        {
            double valor = 0;

            foreach (DataGridViewRow item in GridViewItens.Rows)
            {
                valor += Convert.ToDouble(item.Cells["ValorTotal"].Value);
            }

            TxtValor.Text = valor.ToString();
        }

        private void adicionarItem(PedidoItens item)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                WebService.salvarItensPedidoAsync(item);
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
                //MessageBox.Show(GridViewItens.CurrentRow.Cells["IDItemPedido"].Value.ToString());
                excluirItem(Convert.ToInt32(GridViewItens.CurrentRow.Cells["IDItemPedido"].Value));

                // PREENCHE O GRID COM OS ITENS DO PEDIDO
                PreencherGridPedidos(Convert.ToInt32(TxtID.Text));

                // FOCO NOVAMENTE PARA O TXT PRODUTO
                TxtProduto.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um item para Excluír!", FormNome);
            }
        }

        private void excluirItem(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                WebService.excluirItemPedidoAsync(ID);

                MessageBox.Show("Item excluido com Sucesso!", FormNome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void excluirItensPedidoAlterado()
        {
            // FUNÇÃO PARA EXCLUIR OS ITENS QUE FORAM ADICIONADO EM MODO DE EDIÇÃO E A EDIÇÃO FOI CANCELADA
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                foreach (var item in itensPedidoAlterado)
                {
                    WebService.excluirItemPedidoAsync(item.getSetItemID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void excluirItens(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                WebService.excluirItensPedidoAsync(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void LblNovoEstoque_TextChanged(object sender, EventArgs e)
        {
            if (LblNovoEstoque.Text != "" && Convert.ToInt32(LblNovoEstoque.Text) < 0)
            {
                LblNovoEstoque.ForeColor = Color.Red;
            }
            else
            {
                LblNovoEstoque.ForeColor = Color.Black;
            }

        }

        private void TxtProduto_Leave(object sender, EventArgs e)
        {
            if (TxtProduto.Text != string.Empty)
            {
                preencheProduto(Convert.ToInt32(TxtProduto.Text));
            }
            else
            {
                //MessageBox.Show("Informe um produto!", FormNome);
                limpaCamposItem();
            }
        }

        private void TxtValorFinalItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                BtnAdicionarItem.Focus();

                e.Handled = true;
            }
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                if (getSetStatus != 2)
                {
                    MTxtData.Focus();
                }
                else if (!TxtID.Text.Equals(""))
                {
                    preencheDados(Convert.ToInt32(TxtID.Text));

                    TxtID.Focus();
                }

                e.Handled = true;
            }
        }

        private void MTxtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtCliente.Focus();

                e.Handled = true;
            }
        }

        private void TxtFormaPGTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtProduto.Focus();

                e.Handled = true;
            }
        }

        private void TxtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtFormaPGTO.Focus();

                e.Handled = true;
            }
        }

        private void FormPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            validarCancelamento();
        }

        private void TxtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtDesconto.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtValorFinal.Focus();

                e.Handled = true;
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtValor.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtDesconto.Focus();

                e.Handled = true;
            }
        }

        private void TxtValorFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtValorFinal.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == 13) // ENTER
            {
                BtnSalvar.Focus();

                e.Handled = true;
            }
        }

        private void MTxtData_Leave(object sender, EventArgs e)
        {
            if (MTxtData.Text == "  /  /")
            {
                DateTime date = DateTime.Now;

                MTxtData.Text = date.ToString();
            }
            else
            {
                validarData(MTxtData.Text);
            }
        }

        private void validarData(string data)
        {
            // DATA INVÁLIDA
            if (!DateTime.TryParse(data, out DateTime date))
            {
                MessageBox.Show("data Inválida!", FormNome);

                MTxtData.Text = string.Empty;
                MTxtData.Focus();
            }
        }

        private void TxtCliente_Leave(object sender, EventArgs e)
        {
            if (TxtCliente.Text != string.Empty)
            {
                validarCliente(Convert.ToInt32(TxtCliente.Text));
            }
        }

        public void validarCliente(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                Cliente cliente = WebService.GetClienteAsync(ID).Result;
                TipoClientes tipoClientes = WebService.GetTipoClientesAsync(cliente.getSetID).Result;

                if (getSetStatus != 2)
                {
                    if (cliente.getSetStatus)
                    {
                        MessageBox.Show("Cliente Inativo!", FormNome);
                        TxtCliente.Text = string.Empty;
                        TxtClienteNome.Text = string.Empty;
                        TxtCliente.Focus();
                    }
                    else if (!tipoClientes.getSetTipoCliente)
                    {
                        MessageBox.Show("Tipo do Cliente inválido para esta Operação!", FormNome);
                        TxtCliente.Text = string.Empty;
                        TxtClienteNome.Text = string.Empty;
                        TxtCliente.Focus();
                    }
                }
                else
                {
                    TxtCliente.Text = cliente.getSetID.ToString();
                    TxtClienteNome.Text = cliente.getSetNome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
                TxtCliente.Text = string.Empty;
                TxtClienteNome.Text = string.Empty;
                TxtCliente.Focus();
            }
        }

        private void TxtFormaPGTO_Leave(object sender, EventArgs e)
        {
            if (TxtFormaPGTO.Text != string.Empty)
            {
                validarFormaPGTO(Convert.ToInt32(TxtFormaPGTO.Text));
            }
        }

        public void validarFormaPGTO(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                FormaPGTO formaPGTO = WebService.GetFormaPGTOAsync(ID).Result;

                if (getSetStatus != 2)
                {
                    if (formaPGTO.getSetStatus)
                    {
                        MessageBox.Show("Forma de Pagamento Inativa!", FormNome);
                        TxtFormaPGTO.Text = string.Empty;
                        TxtFormaPGTONome.Text = string.Empty;
                        TxtFormaPGTO.Focus();
                    }
                }
                else
                {
                    TxtFormaPGTO.Text = formaPGTO.getSetID.ToString();
                    TxtFormaPGTONome.Text = formaPGTO.getSetNome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
                TxtFormaPGTO.Text = string.Empty;
                TxtFormaPGTONome.Text = string.Empty;
                TxtFormaPGTO.Focus();
            }
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            calcularPedido();
        }

        private void TxtDesconto_Leave(object sender, EventArgs e)
        {
            calcularPedido();
        }

        private void FormPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) // ESC
            {
                if (getSetStatus == 2)
                {
                    Close();
                }
                else
                {
                    validarCancelamento();
                }
            }
        }

        private void FormPedido_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) // F3
            {
                TxtValor.Focus();
            }
        }

        private void BtnID_Click(object sender, EventArgs e)
        {
            FormPesquisa formPesquisa = new FormPesquisa(2, this); // 2 -> Pesquisa Pedido

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(formPesquisa);
        }

        private void validarPesquisa(FormPesquisa pesquisa)
        {
            formMain.Enabled = false;

            // FUNÇÃO PARA QUANDO FECHAR O CONFIGURAÇÕES GERAIS, ATIVAR NOVAMENTE O FORMA MAIN
            pesquisa.FormClosed += (sender, e) =>
            {
                formMain.Enabled = true;
                TxtID.Focus();
            };

            pesquisa.Show();
        }

        private void GridViewItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLiberarPedido_Click(object sender, EventArgs e)
        {
            // CHAMA A TELA DE LIBERAÇÃO
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa(0, this);

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(pesquisa);
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridViewItens_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Número da linha a ser exibido no cabeçalho da linha
            string numeracao = (e.RowIndex + 1).ToString();

            // Obtém o retângulo de layout para o cabeçalho da linha
            System.Drawing.Rectangle limitacoes = new System.Drawing.Rectangle(e.RowBounds.Left, e.RowBounds.Top, GridViewItens.RowHeadersWidth, e.RowBounds.Height);

            // Centraliza o número da linha no cabeçalho da linha
            TextRenderer.DrawText(e.Graphics, numeracao, GridViewItens.RowHeadersDefaultCellStyle.Font, limitacoes, GridViewItens.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void BtnFormaPGTO_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa(3, this); // LISTA FORMA PGTO

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(pesquisa);
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            // 1 -> Pesquisa de Produto
            FormPesquisa pesquisa = new FormPesquisa(1, this);

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(pesquisa);

            TxtValorItem.Focus();
        }

        private void TxtID_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(2, this); // 2 -> Lista Pedido

                validarPesquisa(pesquisa);
            }
        }

        private void TxtCliente_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(0, this); //Lista Cliente

                validarPesquisa(pesquisa);
            }
        }

        private void TxtFormaPGTO_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(3, this); //Lista Forma PGTO

                validarPesquisa(pesquisa);
            }
        }

        private void TxtProduto_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(1, this); //Lista Produto

                validarPesquisa(pesquisa);
            }
        }
    }
}
