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

namespace SistemaDoLeoWebService
{
    public partial class FormPesquisa : Form
    {
        private int codigo;
        private object TelaFonte;

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

        private void validarComboBoxTipo()
        {

        }

        private void validarCodigo(int codigo)
        {
            if (codigo == 0) // TELA CLIENTE
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
                //ComboBoxTipo.Items.Add("Status");

                ComboBoxTipo.Text = "Nome";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Cliente";
            }
            else if (codigo == 1) // TELA PRODUTO
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns.Add("getSetNome", "Nome");
                GridViewPesquisa.Columns.Add("getSetValor", "Valor");
                GridViewPesquisa.Columns.Add("getSetCusto", "Custo");
                GridViewPesquisa.Columns.Add("getSetStatus", "Status");

                // PREENCHE O ComboBoxTipo
                ComboBoxTipo.Items.Add("Codigo");
                ComboBoxTipo.Items.Add("Nome");
                ComboBoxTipo.Items.Add("Valor");
                ComboBoxTipo.Items.Add("Custo");
                //ComboBoxTipo.Items.Add("Status");

                ComboBoxTipo.Text = "Nome";

                // DEFINE O NOME DA TELA
                this.Text = this.Text + "Produto";
            }
            else if (codigo == 2) // TELA PEDIDO
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

            preencheGrid("");
        }

        private void preencheGrid(string pesquisa)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                // LIMPA O GRID ANTES DE ADICIONAR
                GridViewPesquisa.Rows.Clear();

                if (codigo == 0) // TELA CLIENTE
                {
                    List<ListaCliente> listaClientes = new List<ListaCliente>(WebService.GetListaClientesAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa).Result);
                    string status;

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
                else if (codigo == 1) // TELA PRODUTO
                {

                }
                else if (codigo == 2) // TELA PEDIDO
                {
                    List<ListaPedido> listaPedidos = new List<ListaPedido>(WebService.GetListaPedidosAsync(ComboBoxTipo.SelectedItem.ToString(), pesquisa).Result);

                    foreach (var item in listaPedidos)
                    {
                        GridViewPesquisa.Rows.Add(item.getSetCodigo, item.getSetcliente, item.getSetformaPGTO, item.getSetData, item.getSetValor);
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
            if (codigo == 0) // TELA CLIENTE
            {
                FormCadastroClientes formCadastroClientes = (FormCadastroClientes) TelaFonte;

                formCadastroClientes.preencheDados(ID);

                this.Close();
            }
            else if (codigo == 1) // TELA PRODUTO
            {

            }
            else if (codigo == 2) // TELA PEDIDO
            {
                FormPedido formPedido = (FormPedido) TelaFonte;

                formPedido.preencheDados(ID);

                this.Close();
            }
        }

        private void TxtDados_TextChanged(object sender, EventArgs e)
        {
            preencheGrid(TxtDados.Text);
        }

        private void ComboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtDados.Text = string.Empty;
        }
    }
}
