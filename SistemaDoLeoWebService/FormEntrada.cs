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
    public partial class FormEntrada : Form
    {
        private string FormNome = "Pedido Entrada";
        private Operador operadorLogado;
        private FormMain formMain;
        private Entrada entrada;
        private Produto produto;
        private ConfiguracoesGerais configuracoes;
        private int Status;
        private int contadorItemOrigial;
        private List<EntradaItens> ItensOriginais;
        private List<EntradaItens> itensAlterados;

        public FormEntrada(Operador operador, FormMain formMain)
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
        private void FormEntrada_Load(object sender, EventArgs e)
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
                TxtCusto.Enabled = true;
                TxtDesconto.Enabled = true;
                TxtCustoFinal.Enabled = true;
                TxtProduto.Enabled = true;
                TxtCustoItem.Enabled = true;
                TxtQuantidadeItem.Enabled = true;
                TxtDescontoItem.Enabled = true;
                TxtCustoFinalItem.Enabled = true;

                // PERMISSÃO ADMIN
                if (operadorLogado.getSetAdmin == false)
                {
                    BtnLiberarPedido.Visible = true;
                }

                // VALIDAR CONFIGURAÇÕES
                if (configuracoes.getSetAlterarValorItem == false)
                {
                    TxtCustoItem.ReadOnly = true;
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
                TxtCusto.Enabled = true;
                TxtDesconto.Enabled = true;
                TxtCustoFinal.Enabled = true;
                TxtProduto.Enabled = true;
                TxtCustoItem.Enabled = true;
                TxtQuantidadeItem.Enabled = true;
                TxtDescontoItem.Enabled = true;
                TxtCustoFinalItem.Enabled = true;

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
                TxtCusto.Enabled = false;
                TxtDesconto.Enabled = false;
                TxtCustoFinal.Enabled = false;
                TxtProduto.Enabled = false;
                TxtCustoItem.Enabled = false;
                TxtQuantidadeItem.Enabled = false;
                TxtDescontoItem.Enabled = false;
                TxtCustoFinalItem.Enabled = false;

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

                entrada = WebService.GetRegistroInicialEntradaAsync().Result;

                TxtID.Text = entrada.getSetID.ToString();
                MTxtData.Text = entrada.getSetData.ToString();
                TxtCliente.Text = entrada.getSetCliente.ToString();
                TxtFormaPGTO.Text = entrada.getSetFormaPGTO.ToString();
                TxtCusto.Text = entrada.getSetCusto.ToString();
                TxtDesconto.Text = entrada.getSetDesconto.ToString();
                TxtCustoFinal.Text = entrada.getSetCustoTotal.ToString();

                // CRIA A LISTA DE ITENS ORGINAIS DO PEDIDO
                ItensOriginais = new List<EntradaItens>();

                // CRIA A LISTA DE ITENS EDITADOS
                itensAlterados = new List<EntradaItens>();

                // DEFINE O CONTADOR COMO 0
                contadorItemOrigial = 0;

                // PREENCHE O GRID COM OS ITENS DO PEDIDO
                PreencherGridItens(entrada.getSetID);
                contadorItemOrigial++;

                // PREENCHE AS INFORMÇÕES DO CLIENTE E FORMA PGTO
                validarCliente(entrada.getSetCliente);
                validarFormaPGTO(entrada.getSetFormaPGTO);
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

                entrada = WebService.GetEntradaAsync(ID).Result;

                TxtID.Text = entrada.getSetID.ToString();
                MTxtData.Text = entrada.getSetData.ToString();
                TxtCliente.Text = entrada.getSetCliente.ToString();
                TxtFormaPGTO.Text = entrada.getSetFormaPGTO.ToString();
                TxtCusto.Text = entrada.getSetCusto.ToString();
                TxtDesconto.Text = entrada.getSetDesconto.ToString();
                TxtCustoFinal.Text = entrada.getSetCustoTotal.ToString();

                // CRIA A LISTA DE ITENS ORGINAIS DO PEDIDO
                ItensOriginais = new List<EntradaItens>();

                // CRIA A LISTA DE ITENS EDITADOS
                itensAlterados = new List<EntradaItens>();

                // DEFINE O CONTADOR COMO 0
                contadorItemOrigial = 0;

                // PREENCHE O GRID COM OS ITENS DO PEDIDO
                PreencherGridItens(entrada.getSetID);
                contadorItemOrigial++;

                // PREENCHE AS INFORMÇÕES DO CLIENTE E FORMA PGTO
                validarCliente(entrada.getSetCliente);
                validarFormaPGTO(entrada.getSetFormaPGTO);

                // MANTEM SEMPRE O TXT ID COM O TEXTO SELECIONADO
                TxtID.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, FormNome);

                TxtID.Text = entrada.getSetID.ToString();
                TxtID.SelectAll();
            }
        }

        public void preencheProduto(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                produto = WebService.GetProdutoAsync(ID).Result;
                LblEstoqueAtual.Text = WebService.GetEstoqueProdutoAsync(ID).Result.ToString();

                TxtProduto.Text = produto.getSetID.ToString();
                TxtNomeProduto.Text = produto.getSetNome;
                TxtCustoItem.Text = produto.getSetCusto.ToString();
                TxtQuantidadeItem.Text = "1";
                TxtDescontoItem.Text = "0,00";

                calcularProduto();
                calculaEstoqueProduto();
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
                double custo;
                double quantidade;
                double desconto;

                if (TxtCustoItem.Text == "")
                {
                    TxtCustoItem.Text = produto.getSetCusto.ToString();
                }

                if (TxtQuantidadeItem.Text == "")
                {
                    TxtQuantidadeItem.Text = "1";
                }

                if (TxtDescontoItem.Text == "")
                {
                    TxtDescontoItem.Text = "0,00";
                }

                custo = Convert.ToDouble(TxtCustoItem.Text);
                quantidade = Convert.ToDouble(TxtQuantidadeItem.Text);
                desconto = Convert.ToDouble(TxtDescontoItem.Text) * 0.01;

                double valorFinal = custo * quantidade;

                valorFinal -= valorFinal * desconto;

                TxtCustoFinalItem.Text = valorFinal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source);
            }
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
                    preencheDados(entrada.getSetID);
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
                    excluirItensEntradaAlterado();
                    // LIMPA LISTA DE PRODUTOS 
                    itensAlterados.Clear();

                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(entrada.getSetID);
                }
            }
        }

        private void validarValor(Entrada entrada)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();
                DialogResult validar;
                int ID = Convert.ToInt32(TxtID.Text);

                double custo = WebService.VerificarValorEntradaAsync(ID).Result;

                if (custo == entrada.getSetCustoTotal)
                {
                    finalizarEntrada(entrada);
                }
                else
                {
                    validar = MessageBox.Show("Valor alterado Manualmente, deseja Prosseguir?", FormNome, MessageBoxButtons.YesNo);

                    if (validar == System.Windows.Forms.DialogResult.Yes)
                    {
                        finalizarEntrada(entrada);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        //[STAThread] para utiliazar o CTRL + C
        private void finalizarEntrada(Entrada entrada)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                validarRetorno(WebService.FinalizarEntradaAsync(entrada).Result);
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

                validarImpressao();

                getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                validarAcoes();
                ultimoRegistro();
            }
        }

        private void validarImpressao()
        {
            DialogResult imprimir;
            imprimir = MessageBox.Show("Deseja realizar a impressão?", $"Impressão N° - {TxtID.Text}", MessageBoxButtons.YesNo);

            if (imprimir == System.Windows.Forms.DialogResult.Yes)
            {
                impressaoEntrada();
            }
        }

        private void impressaoEntrada()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();
                var dtItens = new DataTable();
                var dtEntrada = new DataTable();
                EntradaComDados entrada;

                EntradaComDados entradaComDados = WebService.GetEntradaComDadosAsync(Convert.ToInt32(TxtID.Text)).Result;

                dtEntrada.Columns.Add("IdEntrada");
                dtEntrada.Columns.Add("Data");
                dtEntrada.Columns.Add("Cliente");
                dtEntrada.Columns.Add("FormaPGTO");
                dtEntrada.Columns.Add("Custo");
                dtEntrada.Columns.Add("Desconto");
                dtEntrada.Columns.Add("CustoTotal");

                dtEntrada.Rows.Add(entradaComDados.getSetID, entradaComDados.getSetData, entradaComDados.getSetCliente, entradaComDados.getSetFormaPGTO, entradaComDados.getSetCusto, entradaComDados.getSetDesconto, entradaComDados.getSetCustoTotal);

                List<EntradaItens> itens = new List<EntradaItens>(WebService.GetEntradaItensAsync(Convert.ToInt32(TxtID.Text)).Result);

                dtItens.Columns.Add("ID");
                dtItens.Columns.Add("Nome");
                dtItens.Columns.Add("Custo");
                dtItens.Columns.Add("Quantidade");
                dtItens.Columns.Add("Desconto");
                dtItens.Columns.Add("CustoTotal");

                foreach (var item in itens)
                {
                    dtItens.Rows.Add(item.getSetProduto, item.getSetItemNomeProduto, item.getSetItemCusto, item.getSetQuantidade, item.getSetItemDesconto, item.getSetItemCustoTotal);
                }

                // ABRE O FORMULÁRIO DE IMPESSAO
                using (var formImpressao = new FormImpressoes(dtEntrada, dtItens))
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
                MessageBox.Show("Necessário informar um Fornecedor", FormNome);
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
            else if (TxtCusto.Text == "")
            {
                MessageBox.Show("Necessário informar o Pedido ter um Valor", FormNome);
                TxtCusto.Focus();
                return false;
            }
            else if (TxtCustoFinal.Text == "")
            {
                MessageBox.Show("Necessário informar Valor Total ao Pedido", FormNome);
                TxtCustoFinal.Focus();
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
            TxtCusto.Text = string.Empty;
            TxtDesconto.Text = string.Empty;
            TxtCustoFinal.Text = string.Empty;
        }

        private void limpaCamposItem()
        {
            TxtProduto.Text = string.Empty;
            TxtCustoItem.Text = string.Empty;
            TxtQuantidadeItem.Text = string.Empty;
            TxtDescontoItem.Text = string.Empty;
            TxtCustoFinalItem.Text = string.Empty;
            TxtNomeProduto.Text = string.Empty;
        }

        private void limpaCamposEstoque()
        {
            LblEstoqueAtual.Text = string.Empty;
            LblQuantidadeCompra.Text = string.Empty;
            LblLinhaSoma.Visible = false;
            LblNovoEstoque.Text = string.Empty;
        }

        private void PreencherGridItens(int ID)
        {
            var WebService = new ServiceReference1.Service1Client();

            var lista = WebService.GetEntradaItensAsync(ID).Result;

            GridViewItens.Rows.Clear();
            itensAlterados.Clear();

            foreach (var item in lista)
            {
                GridViewItens.Rows.Add(item.getSetItemID, item.getSetEntradaID, item.getSetProduto, item.getSetItemNomeProduto, item.getSetItemCusto, item.getSetQuantidade, item.getSetItemDesconto, item.getSetItemCustoTotal);

                // SE FOR A PRIMEIRA BUSCA NO MODO DE EDIÇÃO, VAI ADICIONAR OS ITENS QUE JÁ ESTAVAM NO
                // PEDIDO NA LISTA "pedidoItensOriginais"
                // CONTADOR RESETA QUANDO MUDA O STATUS
                if (contadorItemOrigial < 1)
                {
                    ItensOriginais.Add(item);
                }
                else if (getSetStatus == 1)
                {
                    // VALIDA OS ITENS NOVOS (QUE FORAM ADICIONADOS NO MODO DE EDIÇÃO)
                    // ADICIONA ELES NA LISTA "ItensOriginais" PARA QUE POSSA EXCLUIR CASO CANCELE
                    // A ALTERAÇÃO
                    if (!ItensOriginais.Any(itensOriginais => itensOriginais.getSetItemID == item.getSetItemID))
                    {
                        ItensOriginais.Add(item);
                    }
                }
            }

            // AJUSTA AS CASAS DECIMAIS DO PEDIDO
            ajustarValores();

            // ORDENA A LISTA PELA ORDEM QUE ENTROU OS PRODUTOS
            GridViewItens.Sort(GridViewItens.Columns["IDItemEntrada"], ListSortDirection.Ascending);
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

        private void calcularEntrada()
        {
            try
            {
                double custo;
                double desconto;
                double custoFinal = 0;

                if (TxtCusto.Text == "")
                {
                    TxtCusto.Text = "0,00";
                }

                if (TxtDesconto.Text == "")
                {
                    TxtDesconto.Text = "0,00";
                }

                if (TxtCustoFinal.Text == "")
                {
                    TxtCustoFinal.Text = "0,00";
                }

                custo = Convert.ToDouble(TxtCusto.Text);
                desconto = Convert.ToDouble(TxtDesconto.Text) * 0.01;

                custoFinal = custo - (custo * desconto);

                TxtCustoFinal.Text = custoFinal.ToString();

                ajustarValores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void ajustarValores()
        {
            if (TxtCusto.Text != string.Empty && TxtCusto.Text != string.Empty)
            {
                TxtCusto.Text = Convert.ToDecimal(TxtCusto.Text).ToString("N2");
            }

            if (TxtDesconto.Text != string.Empty && TxtDesconto.Text != string.Empty)
            {
                TxtDesconto.Text = Convert.ToDecimal(TxtDesconto.Text).ToString("N2");
            }

            if (TxtCustoFinal.Text != string.Empty && TxtCustoFinal.Text != string.Empty)
            {
                TxtCustoFinal.Text = Convert.ToDecimal(TxtCustoFinal.Text).ToString("N2");
            }
        }

        private void getCustoEntrada()
        {
            double custo = 0;

            foreach (DataGridViewRow item in GridViewItens.Rows)
            {
                custo += Convert.ToDouble(item.Cells["CustoTotal"].Value);
            }

            TxtCusto.Text = custo.ToString();
        }

        private void adicionarItem(EntradaItens item)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                WebService.salvarItensEntradaAsync(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
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

                novoEstoque = estoqueAtual + quantidade;

                LblQuantidadeCompra.Text = " + " + quantidade.ToString();
                LblLinhaSoma.Visible = true;

                LblNovoEstoque.Text = novoEstoque.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void excluirItem(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                WebService.excluirItemEntradaAsync(ID);

                MessageBox.Show("Item excluido com Sucesso!", FormNome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void excluirItensEntradaAlterado()
        {
            // FUNÇÃO PARA EXCLUIR OS ITENS QUE FORAM ADICIONADO EM MODO DE EDIÇÃO E A EDIÇÃO FOI CANCELADA
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                foreach (var item in itensAlterados)
                {
                    WebService.excluirItemEntradaAsync(item.getSetItemID);
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

                WebService.excluirItensEntradaAsync(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void validarData(string data)
        {
            // DATA INVÁLIDA
            if (!DateTime.TryParse(data, out DateTime date))
            {
                MessageBox.Show("Data Inválida!", FormNome);

                MTxtData.Text = string.Empty;
                MTxtData.Focus();
            }
        }

        public void validarCliente(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                Cliente cliente = WebService.GetClienteAsync(ID).Result;

                TxtCliente.Text = cliente.getSetID.ToString();
                TxtClienteNome.Text = cliente.getSetNome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
                TxtCliente.Text = string.Empty;
                TxtClienteNome.Text = string.Empty;
                TxtCliente.Focus();
            }
        }

        public void validarFormaPGTO(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                FormaPGTO formaPGTO = WebService.GetFormaPGTOAsync(ID).Result;

                TxtFormaPGTO.Text = formaPGTO.getSetID.ToString();
                TxtFormaPGTONome.Text = formaPGTO.getSetNome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
                TxtFormaPGTO.Text = string.Empty;
                TxtFormaPGTONome.Text = string.Empty;
                TxtFormaPGTO.Focus();
            }
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

        private void BtnID_Click(object sender, EventArgs e)
        {
            FormPesquisa formPesquisa = new FormPesquisa(2, this); // 2 -> Pesquisa Pedido

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(formPesquisa);
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
                    EntradaItens item = new EntradaItens();
                    item.getSetEntradaID = Convert.ToInt32(TxtID.Text);
                    item.getSetProduto = Convert.ToInt32(TxtProduto.Text);
                    item.getSetItemCusto = Convert.ToDouble(TxtCustoItem.Text);
                    item.getSetQuantidade = Convert.ToInt32(TxtQuantidadeItem.Text);
                    item.getSetItemDesconto = Convert.ToDouble(TxtDescontoItem.Text);
                    item.getSetItemCustoTotal = Convert.ToDouble(TxtCustoFinalItem.Text);

                    adicionarItem(item);

                    MessageBox.Show("Item adicionado com Sucesso!", FormNome);

                    // PREENCHE O GRID COM OS ITENS DO PEDIDO
                    PreencherGridItens(item.getSetEntradaID);

                    // LIMPA AS INFORMAÇÕES DO PRODUTO
                    limpaCamposItem();
                    limpaCamposEstoque();

                    // FUNÇÃO PARA CALCULAR O VALOR DO PEDIDO
                    getCustoEntrada();
                    calcularEntrada();

                    // FOCO NOVAMENTE PARA O TXT PRODUTO
                    TxtProduto.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, FormNome);
            }
        }

        private void BtnRemoverItem_Click(object sender, EventArgs e)
        {
            if (GridViewItens.CurrentRow != null)
            {
                //MessageBox.Show(GridViewItens.CurrentRow.Cells["IDItemPedido"].Value.ToString());
                excluirItem(Convert.ToInt32(GridViewItens.CurrentRow.Cells["IDItemPedido"].Value));

                // PREENCHE O GRID COM OS ITENS DO PEDIDO
                PreencherGridItens(Convert.ToInt32(TxtID.Text));

                // FOCO NOVAMENTE PARA O TXT PRODUTO
                TxtProduto.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um item para Excluír!", FormNome);
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa(0, this);

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(pesquisa);
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

            TxtCustoItem.Focus();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                getSetStatus = 0;
                validarAcoes();

                TxtID.Text = WebService.GetProximoRegistroEntradaAsync().Result.ToString();
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            getSetStatus = 1;
            validarAcoes();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                int ID = WebService.VoltarRegistroEntradaAsync(Convert.ToInt32(TxtID.Text)).Result;

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

                int ID = WebService.AvancarRegistroEntradaAsync(Convert.ToInt32(TxtID.Text)).Result;

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
                    validarImpressao();
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
                        Entrada entrada = new Entrada();
                        entrada.getSetID = ID;
                        entrada.getSetCliente = Convert.ToInt32(TxtCliente.Text);
                        entrada.getSetFormaPGTO = Convert.ToInt32(TxtFormaPGTO.Text);
                        entrada.getSetCusto = Convert.ToDouble(TxtCusto.Text);
                        entrada.getSetDesconto = Convert.ToDouble(TxtDesconto.Text);
                        entrada.getSetCustoTotal = Convert.ToDouble(TxtCustoFinal.Text);
                        entrada.getSetData = MTxtData.Text;

                        // VALIDA O VALOR DO PEDIDO -> FINALIZA O PEDIDO
                        validarValor(entrada);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, FormNome);
            }
        }

        private void TxtCliente_Leave(object sender, EventArgs e)
        {
            if (TxtCliente.Text != string.Empty)
            {
                validarCliente(Convert.ToInt32(TxtCliente.Text));
            }
        }

        private void TxtProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(1, this); //Lista Produto

                validarPesquisa(pesquisa);
            }
        }

        private void TxtFormaPGTO_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(3, this); //Lista Forma PGTO

                validarPesquisa(pesquisa);
            }
        }

        private void TxtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(0, this); //Lista Cliente

                validarPesquisa(pesquisa);
            }
        }

        private void TxtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(2, this); // 2 -> Lista Pedido

                validarPesquisa(pesquisa);
            }
        }

        private void GridViewItens_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Número da linha a ser exibido no cabeçalho da linha
            string numeracao = (e.RowIndex + 1).ToString();

            // Obtém o retângulo de layout para o cabeçalho da linha
            System.Drawing.Rectangle limitacoes = new System.Drawing.Rectangle(e.RowBounds.Left, e.RowBounds.Top, GridViewItens.RowHeadersWidth, e.RowBounds.Height);

            // Centraliza o número da linha no cabeçalho da linha
            TextRenderer.DrawText(e.Graphics, numeracao, GridViewItens.RowHeadersDefaultCellStyle.Font, limitacoes, GridViewItens.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
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
                TxtCustoFinalItem.Focus();

                e.Handled = true;
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

        private void TxtCustoItem_Leave(object sender, EventArgs e)
        {
            if (TxtProduto.Text != string.Empty && TxtCustoItem.Text != string.Empty)
            {
                TxtCustoItem.Text = Convert.ToDecimal(TxtCustoItem.Text).ToString("N2");

                calcularProduto();
            }
            else
            {
                //MessageBox.Show("Informe um produto!", FormNome);
                TxtProduto.Focus();
                limpaCamposItem();
            }
        }

        private void TxtCustoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtCustoItem.Text.Contains(","))
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

        private void TxtProduto_TextChanged(object sender, EventArgs e)
        {
            if (TxtProduto.Text != string.Empty)
            {
                TxtCustoItem.Enabled = true;
                TxtQuantidadeItem.Enabled = true;
                TxtDescontoItem.Enabled = true;
                TxtCustoFinalItem.Enabled = true;
                BtnAdicionarItem.Enabled = true;
            }
            else
            {
                TxtCustoItem.Enabled = false;
                TxtQuantidadeItem.Enabled = false;
                TxtDescontoItem.Enabled = false;
                TxtCustoFinalItem.Enabled = false;
                BtnAdicionarItem.Enabled = false;
                limpaCamposItem();
                limpaCamposEstoque();
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
                // FOCO PARA O PROXIMO CAMPO
                TxtCustoItem.Focus();
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

        private void TxtCustoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtCustoFinal.Text.Contains(","))
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

        private void TxtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                if (TxtCusto.Text.Contains(","))
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
                TxtCustoFinal.Focus();

                e.Handled = true;
            }
        }

        private void FormEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            validarCancelamento();
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

        private void TxtCustoFinalItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                BtnAdicionarItem.Focus();

                e.Handled = true;
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

        private void TxtCustoFinalItem_TextChanged(object sender, EventArgs e)
        {
            if (TxtCustoFinalItem.Text != "")
            {
                TxtCustoFinalItem.Text = Convert.ToDecimal(TxtCustoFinalItem.Text).ToString("N2");
            }
        }

        private void TxtQuantidadeItem_TextChanged(object sender, EventArgs e)
        {
            calculaEstoqueProduto();
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

        private void FormEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3) // F3
            {
                TxtCusto.Focus();
            }
        }

        private void FormEntrada_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtFormaPGTO_Leave(object sender, EventArgs e)
        {
            if (TxtFormaPGTO.Text != string.Empty)
            {
                validarFormaPGTO(Convert.ToInt32(TxtFormaPGTO.Text));
            }
        }

        private void TxtDesconto_Leave(object sender, EventArgs e)
        {
            calcularEntrada();
        }

        private void TxtCusto_Leave(object sender, EventArgs e)
        {
            calcularEntrada();
        }
    }
}
