using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaDoLeoWebService
{
    public partial class FormPesquisa : Form
    {
        private int codigo;
        private object TelaFonte;

        public int getSetCodigo
        {
            get { return codigo; } set { codigo = value; }
        }

        public FormPesquisa(int codigo, object telaFonte)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.TelaFonte = telaFonte;

            this.Text = "PESQUISA - ";

            TxtDados.Focus();

            validarCodigo(codigo);
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
        }

        private void validarCodigo(int codigo)
        {
            if (codigo == 0) // LISTA CLIENTE
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns["getSetCodigo"].Width = 80;
                GridViewPesquisa.Columns.Add("getSetNome", "Nome");
                GridViewPesquisa.Columns["getSetNome"].Width = 310;
                GridViewPesquisa.Columns.Add("getSetDocumento", "Documento");
                GridViewPesquisa.Columns["getSetDocumento"].Width = 120;
                GridViewPesquisa.Columns.Add("getSetDtNasc", "Dt Nasc");
                GridViewPesquisa.Columns.Add("getSetStatus", "Inativo");
                GridViewPesquisa.Columns["getSetStatus"].Width = 84;

                // PREENCHE O ComboBoxTipo
                ComboBoxTipo.Items.Add("Codigo");
                ComboBoxTipo.Items.Add("Nome");
                ComboBoxTipo.Items.Add("Documento");
                ComboBoxTipo.Items.Add("Dt Nasc");
                ComboBoxTipo.Items.Add("Inativo");

                ComboBoxTipo.Text = "Nome";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Cliente";
            }
            else if (codigo == 1) // LISTA PRODUTO
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns.Add("getSetNome", "Nome");
                GridViewPesquisa.Columns.Add("getSetCategoria", "Categoria");
                GridViewPesquisa.Columns.Add("getSetValor", "Valor");
                GridViewPesquisa.Columns.Add("getSetCusto", "Custo");
                GridViewPesquisa.Columns.Add("getSetEstoque", "Estoque");
                GridViewPesquisa.Columns.Add("getSetStatus", "Inativo");

                // PREENCHE O ComboBoxTipo
                ComboBoxTipo.Items.Add("Codigo");
                ComboBoxTipo.Items.Add("Nome");
                ComboBoxTipo.Items.Add("Categoria");
                ComboBoxTipo.Items.Add("Valor");
                ComboBoxTipo.Items.Add("Custo");
                ComboBoxTipo.Items.Add("Inativo");

                ComboBoxTipo.Text = "Nome";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Produto";
            }
            else if (codigo == 2) // LISTA PEDIDO
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns.Add("getSetNome", "Cliente");
                GridViewPesquisa.Columns["getSetNome"].Width = 294;
                GridViewPesquisa.Columns.Add("getSetFormaPGTO", "Forma PGTO");
                GridViewPesquisa.Columns.Add("getSetData", "Data");
                GridViewPesquisa.Columns.Add("getSetValor", "Valor");

                // PREENCHE O ComboBoxTipo
                ComboBoxTipo.Items.Add("Codigo");
                ComboBoxTipo.Items.Add("Cliente");
                ComboBoxTipo.Items.Add("Forma PGTO");
                ComboBoxTipo.Items.Add("Data");
                ComboBoxTipo.Items.Add("Valor");

                ComboBoxTipo.Text = "Cliente";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Pedido";
            }
            else if (codigo == 3) // LISTA FORMA PGTO
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns["getSetCodigo"].Width = 80;
                GridViewPesquisa.Columns.Add("getSetNome", "Nome");
                GridViewPesquisa.Columns["getSetNome"].Width = 300;
                GridViewPesquisa.Columns.Add("getSetStatus", "Inativo");
                GridViewPesquisa.Columns["getSetStatus"].Width = 80;

                // PREENCHE O ComboBoxTipo
                ComboBoxTipo.Items.Add("Codigo");
                ComboBoxTipo.Items.Add("Nome");
                ComboBoxTipo.Items.Add("Inativo");

                ComboBoxTipo.Text = "Nome";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Forma PGTO";
            }
            else if (codigo == 4) // LISTA CATEGORIA
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns.Add("getSetNome", "Nome");
                GridViewPesquisa.Columns["getSetNome"].Width = 300;
                GridViewPesquisa.Columns.Add("getSetStatus", "Inativo");

                // PREENCHE O ComboBoxTipo
                ComboBoxTipo.Items.Add("Codigo");
                ComboBoxTipo.Items.Add("Nome");
                ComboBoxTipo.Items.Add("Inativo");

                ComboBoxTipo.Text = "Nome";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Categoria";
            }
            else if (codigo == 5) // LISTA OPERADOR
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns.Add("getSetNome", "Nome");
                GridViewPesquisa.Columns["getSetNome"].Width = 300;
                GridViewPesquisa.Columns.Add("getSetAdmin", "Admin");
                GridViewPesquisa.Columns.Add("getSetStatus", "Inativo");

                // PREENCHE O ComboBoxTipo
                ComboBoxTipo.Items.Add("Codigo");
                ComboBoxTipo.Items.Add("Nome");
                ComboBoxTipo.Items.Add("Admin");
                ComboBoxTipo.Items.Add("Inativo");

                ComboBoxTipo.Text = "Nome";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Operador";
            }
            else if (codigo == 6) // LISTA ENTRADA
            {
                GridViewPesquisa.Columns.Add("ID", "Codigo");
                GridViewPesquisa.Columns.Add("Fornecedor", "Fornecedor");
                GridViewPesquisa.Columns["Fornecedor"].Width = 300;
                GridViewPesquisa.Columns.Add("FormaPGTO", "FormaPGTO");
                GridViewPesquisa.Columns.Add("Data", "Data");
                GridViewPesquisa.Columns.Add("Custo", "Custo");

                // PREENCHE O ComboBoxTipo
                ComboBoxTipo.Items.Add("Codigo");
                ComboBoxTipo.Items.Add("Fornecedor");
                ComboBoxTipo.Items.Add("FormaPGTO");
                ComboBoxTipo.Items.Add("Data");
                ComboBoxTipo.Items.Add("Custo");

                ComboBoxTipo.Text = "Fornecedor";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Entrada";
            }

            preencheGrid("");
        }

        private void preencheGrid(string pesquisa)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();
                bool buscaInativo = false;
                string status;
                string tipoCliente = "";

                // LIMPA O GRID ANTES DE ADICIONAR
                GridViewPesquisa.Rows.Clear();

                if (codigo == 0) // LISTA CLIENTE
                {
                    // VALIDA SE VAI BUSCAR OS REGISTROS INATIVOS OU NÃO
                    // SOMENTE A TELA DE CADASTRO DE CLIENTE BUSCA INATIVO
                    if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormCadastroClientes, Text: Cadastro Cliente")
                    {
                        buscaInativo = true;
                        tipoCliente = "0";
                    }
                    else if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormPedido, Text: Pedidos")
                    {
                        tipoCliente = "1"; // CLIENTE
                    }
                    else if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormEntrada, Text: Pedido Entrada")
                    {
                        tipoCliente = "2"; // FORNECEDOR
                    }

                    List<ListaCliente> listaClientes = new List<ListaCliente>(WebService.GetListaClientesAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa, buscaInativo, tipoCliente).Result);

                    foreach (var item in listaClientes)
                    {
                        if (item.getSetStatus == true)
                        {
                            status = "Sim";
                        }
                        else
                        {
                            status = "Não";
                        }

                        GridViewPesquisa.Rows.Add(item.getSetCodigo, item.getSetNome, item.getSetDocumento, item.getSetDtNasc, status);
                    }
                }
                else if (codigo == 1) // LISTA PRODUTO
                {
                    // VALIDA SE VAI BUSCAR OS REGISTROS INATIVOS OU NÃO
                    // SOMENTE A TELA DE CADASTRO DE CLIENTE BUSCA INATIVO
                    if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormCadastroProdutos, Text: Cadastro Produto")
                    {
                        buscaInativo = true;
                    }

                    List<ListaProduto> listaProdutos = new List<ListaProduto>(WebService.GetListaProdutosAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa, buscaInativo).Result);

                    foreach (var item in listaProdutos)
                    {
                        if (item.getSetStatus == true)
                        {
                            status = "Sim";
                        }
                        else
                        {
                            status = "Não";
                        }

                        GridViewPesquisa.Rows.Add(item.getSetID, item.getSetNome, item.getSetCategoria, item.getSetValor, item.getSetCusto, item.getSetEstoque, status);
                    }
                }
                else if (codigo == 2) // LISTA PEDIDO
                {
                    List<ListaPedido> listaPedidos = new List<ListaPedido>(WebService.GetListaPedidosAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa).Result);

                    foreach (var item in listaPedidos)
                    {
                        GridViewPesquisa.Rows.Add(item.getSetCodigo, item.getSetcliente, item.getSetformaPGTO, item.getSetData, item.getSetValor);
                    }
                }
                else if (codigo == 3) // LISTA FORMA PGTO
                {
                    List<FormaPGTO> listaFormaPGTO = new List<FormaPGTO>(WebService.GetListaFormaPGTOAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa, buscaInativo).Result);

                    foreach (var item in listaFormaPGTO)
                    {
                        if (item.getSetStatus == true)
                        {
                            status = "Sim";
                        }
                        else
                        {
                            status = "Não";
                        }

                        GridViewPesquisa.Rows.Add(item.getSetID, item.getSetNome, status);
                    }
                }
                else if (codigo == 4) // LISTA CATEGORIA
                {
                    // VALIDA SE VAI BUSCAR OS REGISTROS INATIVOS OU NÃO
                    // SOMENTE A TELA DE CADASTRO DE CLIENTE BUSCA INATIVO
                    if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormCadastroCategoria, Text: Cadastro Categoria")
                    {
                        buscaInativo = true;
                    }

                    List<Categoria> listaCategoria = new List<Categoria>(WebService.GetListaCategoriasAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa, buscaInativo).Result);

                    foreach (var item in listaCategoria)
                    {
                        if (item.getSetStatus == true)
                        {
                            status = "Sim";
                        }
                        else
                        {
                            status = "Não";
                        }

                        GridViewPesquisa.Rows.Add(item.getSetID, item.getSetNome, status);
                    }
                }
                else if (codigo == 5) // LISTA OPERADOR
                {
                    List<Operador> listaOperador = new List<Operador>(WebService.GetListaOperadorAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa, buscaInativo).Result);

                    foreach (var item in listaOperador)
                    {
                        status = "Não";
                        string admin = "Não";
                        if (item.getSetStatus == true)
                        {
                            status = "Sim";
                        }

                        if (item.getSetAdmin == true)
                        {
                            admin = "Sim";
                        }

                        GridViewPesquisa.Rows.Add(item.getSetID, item.getSetNome, admin, status);
                    }
                }
                else if (codigo == 6) // LISTA ENTRADA
                {
                    List<ListaEntrada> listaEntrada = new List<ListaEntrada>(WebService.GetListaEntradasAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa).Result);

                    foreach (var item in listaEntrada)
                    {
                        GridViewPesquisa.Rows.Add(item.getSetID, item.getSetFornecedor, item.getSetformaPGTO, item.getSetData, item.getSetCusto);
                    }
                }
            }
            catch (Exception ex)
            {
                // NÃO NECESSÁRIO POIS ALGUMAS CONSULTAS NÃO VÃO LOCALIZAR NADA
                //MessageBox.Show($"{ex.Message} - {ex.Source}");
            }
        }

        private void GridViewPesquisa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (GridViewPesquisa.CurrentRow.Cells[0].Value != null)
            {
                var ID = GridViewPesquisa.CurrentRow.Cells[0].Value.ToString();

                validarRetorno(Convert.ToInt32(ID));
            }
        }

        private void validarRetorno(int ID)
        {
            if (codigo == 0) // PESQUISA CLIENTE
            {
                // VALIDA QUAL A TELA QUE CHAMOU A LISTA DE PESQUISA

                // TELA CADASTRO CLIENTE
                if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormCadastroClientes, Text: Cadastro Cliente")
                {
                    //MessageBox.Show(TelaFonte.ToString());
                    FormCadastroClientes formCadastroClientes = (FormCadastroClientes)TelaFonte;

                    formCadastroClientes.preencheDados(ID);
                }
                // TELA PEDIDO
                else if (TelaFonte.ToString().Equals("SistemaDoLeoWebService.FormPedido, Text: Pedidos"))
                {
                    FormPedido pedido = (FormPedido)TelaFonte;

                    pedido.validarCliente(ID);
                }
                // TELA RELATÓRIO DE PEDIDOS
                else if (TelaFonte.ToString().Equals("SistemaDoLeoWebService.FormRelatorioPedidos, Text: Relatório de Pedidos"))
                {
                    FormRelatorioPedidos relatorio = (FormRelatorioPedidos)TelaFonte;

                    relatorio.validarCliente(ID);
                }
            }
            else if (codigo == 1) // PESQUISA PRODUTO
            {
                // TELA CADASTRO PRODUTO
                if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormCadastroProdutos, Text: Cadastro Produto")
                {
                    FormCadastroProdutos formCadastroProdutos = (FormCadastroProdutos)TelaFonte;

                    formCadastroProdutos.preencherDados(ID);
                }
                // TELA CADASTRO PEDIDO
                else if (TelaFonte.ToString().Equals("SistemaDoLeoWebService.FormPedido, Text: Pedidos"))
                {
                    FormPedido pedido = (FormPedido)TelaFonte;

                    pedido.preencheProduto(ID);
                }
            }
            else if (codigo == 2) // PESQUISA PEDIDO
            {
                FormPedido formPedido = (FormPedido)TelaFonte;

                formPedido.preencheDados(ID);
            }
            else if (codigo == 3) // PESQUISA FORMA PGTO
            {
                // TELA CADASTRO FORMA PGTO
                if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormCadastroFormaPGTO, Text: Cadastro Forma de Pagamentos")
                {
                    FormCadastroFormaPGTO formCadastroFormaPGTO = (FormCadastroFormaPGTO)TelaFonte;

                    formCadastroFormaPGTO.preencheDados(ID);
                }
                // TELA PEDIDO
                else if (TelaFonte.ToString().Equals("SistemaDoLeoWebService.FormPedido, Text: Pedidos"))
                {
                    FormPedido pedido = (FormPedido)TelaFonte;

                    pedido.validarFormaPGTO(ID);
                }
                // TELA RELATÓRIO DE PEDIDOS
                else if (TelaFonte.ToString().Equals("SistemaDoLeoWebService.FormRelatorioPedidos, Text: Relatório de Pedidos"))
                {
                    FormRelatorioPedidos relatorio = (FormRelatorioPedidos)TelaFonte;

                    relatorio.validarFormaPGTO(ID);
                }
            }
            else if (codigo == 4) // LISTA CATEGORIA
            {
                // TELA CADASTRO CATEGORIA
                if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormCadastroCategoria, Text: Cadastro Categoria")
                {
                    FormCadastroCategoria categoria = (FormCadastroCategoria)TelaFonte;

                    categoria.preencheDados(ID);
                }
            }
            else if (codigo == 5) // LISTA OPERADOR
            {
                // TELA CADASTRO CATEGORIA
                if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormCadastroOperador, Text: Cadastro Operador")
                {
                    FormCadastroOperador operador = (FormCadastroOperador)TelaFonte;

                    operador.preencheDados(ID);
                }
            }
            else if (codigo == 6) // LISTA ENTRADA
            {
                // TELA ENTRADA
                if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormEntrada, Text: Pedido Entrada")
                {
                    FormEntrada form = (FormEntrada)TelaFonte;

                    form.preencheDados(ID);
                }
            }

            this.Close();
        }

        private void TxtDados_TextChanged(object sender, EventArgs e)
        {
            preencheGrid(TxtDados.Text);
        }

        private void ComboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtDados.Text = string.Empty;
        }

        private void TxtDados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (GridViewPesquisa.RowCount > 0)
                {
                    var ID = GridViewPesquisa.CurrentRow.Cells[0].Value.ToString();

                    validarRetorno(Convert.ToInt32(ID));
                }
            }
        }

        private void GridViewPesquisa_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Número da linha a ser exibido no cabeçalho da linha
            string numeracao = (e.RowIndex + 1).ToString();

            // Obtém o retângulo de layout para o cabeçalho da linha
            Rectangle limitacoes = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, GridViewPesquisa.RowHeadersWidth, e.RowBounds.Height);

            // Centraliza o número da linha no cabeçalho da linha
            TextRenderer.DrawText(e.Graphics, numeracao, GridViewPesquisa.RowHeadersDefaultCellStyle.Font, limitacoes, GridViewPesquisa.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void FormPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Escape))
            {
                this.Close();
                e.Handled = true;
            }
        }

        private void FormPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Down))
            {
                if (GridViewPesquisa.CurrentCell != null && GridViewPesquisa.CurrentCell.RowIndex + 1 < GridViewPesquisa.RowCount)
                {
                    GridViewPesquisa.CurrentCell = GridViewPesquisa.Rows[GridViewPesquisa.CurrentCell.RowIndex + 1].Cells[0]; 
                }
            }
            else if (e.KeyValue == (char)(Keys.Up))
            {
                if (GridViewPesquisa.CurrentCell != null && GridViewPesquisa.CurrentCell.RowIndex - 1 >= 0)
                {
                    GridViewPesquisa.CurrentCell = GridViewPesquisa.Rows[GridViewPesquisa.CurrentCell.RowIndex - 1].Cells[0];
                }
            }
        }

        private void TxtDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Down || e.KeyValue == (char)Keys.Up)
            {
                e.Handled = true;
            }
        }
    }
}
