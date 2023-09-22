using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDoLeoWebService
{
    public partial class FormPesquisa : Form
    {
        private int codigo;
        private object testeTela;

        public FormPesquisa(int codigo, object teste)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.testeTela = teste;

            validarCodigo(codigo);
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
        }

        private void validarCodigo(int codigo)
        {
            if (codigo == 0) // TELA CLIENTE
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns.Add("getSetNome", "Nome");
                GridViewPesquisa.Columns.Add("getSetDocumento", "Documento");
                GridViewPesquisa.Columns.Add("getSetDtNasc", "Dt Nasc");
                GridViewPesquisa.Columns.Add("getSetStatus", "Status");
            }
            else if (codigo == 1) // TELA PRODUTO
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns.Add("getSetNome", "Nome");
                GridViewPesquisa.Columns.Add("getSetValor", "Valor");
                GridViewPesquisa.Columns.Add("getSetCusto", "Custo");
                GridViewPesquisa.Columns.Add("getSetStatus", "Status");
            }
            else if (codigo == 2) // TELA PEDIDO
            {
                GridViewPesquisa.Columns.Add("getSetCodigo", "Codigo");
                GridViewPesquisa.Columns.Add("getSetNome", "Cliente");
                GridViewPesquisa.Columns["getSetNome"].Width = 294;
                GridViewPesquisa.Columns.Add("getSetFormaPGTO", "Forma PGTO");
                GridViewPesquisa.Columns.Add("getSetData", "Data");
                GridViewPesquisa.Columns.Add("getSetValor", "Valor");
            }

            preencheGrid();
        }

        private void preencheGrid()
        {
            var WebService = new ServiceReference1.Service1Client();

            List<ListaPedido> listaPedidos = new List<ListaPedido>(WebService.GetListaPedidosAsync("").Result);

            foreach (var item in listaPedidos)
            {
                GridViewPesquisa.Rows.Add(item.getSetCodigo, item.getSetcliente, item.getSetformaPGTO, item.getSetData, item.getSetValor);
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
                
            }
            else if (codigo == 1) // TELA PRODUTO
            {
                
            }
            else if (codigo == 2) // TELA PEDIDO
            {
                FormPedido formPedido = (FormPedido) testeTela;

                formPedido.preencheDados(ID);

                this.Close();
            }
        }
    }
}
