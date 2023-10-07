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
    public partial class FormRelatorioPedidos : Form
    {
        private string nomeForm = "Relatório de Pedidos";
        private Operador operador;
        private FormMain formMain;

        public FormRelatorioPedidos(Operador operador, FormMain formMain)
        {
            InitializeComponent();
            this.operador = operador;
            this.formMain = formMain;

            this.Text = nomeForm;
        }

        private void TxtDtInicio_Leave(object sender, EventArgs e)
        {
            if (TxtDtInicio.Text == "  /  /")
            {
                DateTime date = DateTime.Now;

                TxtDtInicio.Text = date.ToString();
            }
            else
            {
                if (validarData(TxtDtInicio.Text))
                {
                    TxtDtInicio.Text = string.Empty;
                    TxtDtInicio.Focus();
                }
            }
        }

        private bool validarData(string data)
        {
            // DATA INVÁLIDA
            if (!DateTime.TryParse(data, out DateTime date))
            {
                MessageBox.Show("Data Inválida!", nomeForm);

                return true;
            }
            else
            {
                return false;
            }
        }

        private void TxtDtFinal_Leave(object sender, EventArgs e)
        {
            if (TxtDtFinal.Text == "  /  /")
            {
                DateTime date = DateTime.Now;

                TxtDtFinal.Text = date.ToString();
            }
            else
            {
                if (validarData(TxtDtFinal.Text))
                {
                    TxtDtFinal.Text = string.Empty;
                    TxtDtFinal.Focus();
                }
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

                TxtCliente.Text = cliente.getSetID.ToString();
                TxtClienteNome.Text = cliente.getSetNome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, nomeForm);
                TxtCliente.Text = string.Empty;
                TxtClienteNome.Text = string.Empty;
                TxtCliente.Focus();
            }
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            TxtClienteNome.Text = string.Empty;
        }

        private void TxtFormaPGTO_TextChanged(object sender, EventArgs e)
        {
            TxtFormaPGTONome.Text = string.Empty;
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

                TxtFormaPGTO.Text = formaPGTO.getSetID.ToString();
                TxtFormaPGTONome.Text = formaPGTO.getSetNome;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " - " + ex.Source, nomeForm);
                TxtFormaPGTO.Text = string.Empty;
                TxtFormaPGTONome.Text = string.Empty;
                TxtFormaPGTO.Focus();
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa(0, this); // 0 -> Pesquisa Cliente

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(pesquisa);
        }

        private void validarPesquisa(FormPesquisa pesquisa)
        {
            formMain.Enabled = false;

            // FUNÇÃO PARA QUANDO FECHAR O CONFIGURAÇÕES GERAIS, ATIVAR NOVAMENTE O FORMA MAIN
            pesquisa.FormClosed += (sender, e) =>
            {
                formMain.Enabled = true;

            };

            pesquisa.Show();
        }

        private void BtnFormaPGTO_Click(object sender, EventArgs e)
        {
            FormPesquisa pesquisa = new FormPesquisa(3, this); // 3 -> Pesquisa Forma PGTO

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(pesquisa);
        }

        private void TxtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(0, this); // 0 -> Pesquisa Cliente

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

        private void TxtDtInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtDtFinal.Focus();

                e.Handled = true;
            }
        }

        private void TxtDtFinal_KeyPress(object sender, KeyPressEventArgs e)
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
                BtnBuscar.Focus();

                e.Handled = true;
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                buscarRelatorio();
            }
        }

        private void buscarRelatorio()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();
                List<PedidoComDados> pedidos;
                string cliente;
                string formaPGTO;

                if (TxtCliente.Text.Equals(""))
                {
                    cliente = "0";
                }
                else
                {
                    cliente = TxtCliente.Text;
                }

                if (TxtFormaPGTO.Text.Equals(""))
                {
                    formaPGTO = "0";
                }
                else
                {
                    formaPGTO = TxtFormaPGTO.Text;
                }

                pedidos = new List<PedidoComDados>(WebService.GetRelatorioPedidoAsync(TxtDtInicio.Text, TxtDtFinal.Text, cliente, formaPGTO).Result);

                finalizarRelatorio(pedidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} - {ex.Source}", nomeForm);
            }
        }

        private void finalizarRelatorio(List<PedidoComDados> pedidos)
        {
            DataTable dtPedido = new DataTable();

            dtPedido.Columns.Add("CodPedido");
            dtPedido.Columns.Add("Data");
            dtPedido.Columns.Add("Cliente");
            dtPedido.Columns.Add("FormaPGTO");
            dtPedido.Columns.Add("PedidoValor");
            dtPedido.Columns.Add("PedidoDesconto");
            dtPedido.Columns.Add("PedidoValorTotal");

            foreach (var pedido in pedidos)
            {
                dtPedido.Rows.Add(pedido.getSetID, pedido.getSetData,
                    pedido.getSetCliente, pedido.getSetFormaPGTO,
                    pedido.getSetValor, pedido.getSetDesconto, pedido.getSetValorTotal);
            }

            // ABRE O FORMULÁRIO DE IMPESSAO
            using (var formImpressao = new FormImpressoes(dtPedido))
                formImpressao.ShowDialog();
        }

        private bool validarCampos()
        {
            if (TxtDtInicio.Text.Equals("  /  /"))
            {
                MessageBox.Show("Necessário informar uma data Inicial!", nomeForm);
                TxtDtInicio.Focus();

                return false;
            }
            else if (TxtDtFinal.Text.Equals("  /  /"))
            {
                MessageBox.Show("Necessário informar uma data Final!", nomeForm);
                TxtDtFinal.Focus();

                return false;
            }

            return true;
        }

        private void FormRelatorioPedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void TxtDtInicio_Enter(object sender, EventArgs e)
        {
            TxtDtInicio.SelectAll();
        }

        private void TxtDtFinal_Enter(object sender, EventArgs e)
        {
            TxtDtFinal.SelectAll();
        }

        private void TxtCliente_Enter(object sender, EventArgs e)
        {
            TxtCliente.SelectAll();
        }

        private void TxtFormaPGTO_Enter(object sender, EventArgs e)
        {
            TxtFormaPGTO.SelectAll();
        }
    }
}
