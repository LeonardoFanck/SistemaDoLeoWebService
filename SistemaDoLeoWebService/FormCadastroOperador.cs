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
    public partial class FormCadastroOperador : Form
    {
        private string NomeForm = "Cadastro Operador";
        private int Status;
        private Operador operadorLogado;
        private Operador operador;
        private FormMain formMain;

        public FormCadastroOperador(Operador operadorLogado, FormMain formMain)
        {
            this.operadorLogado = operadorLogado;
            this.formMain = formMain;

            InitializeComponent();
        }

        public int getSetStatus
        {
            // 0 -> Novo Cadastro | 1 -> Edição | 2 -> Visualização
            get { return this.Status; }
            set { this.Status = value; }
        }

        private void FormCadastroOperador_Load(object sender, EventArgs e)
        {
            this.Text = NomeForm;
            getSetStatus = 2; // 2 -> Visualização
            validarAcoes();  // 0 -> Novo | 1 -> Edição | 2 -> Visualização
            ultimoRegistro();
        }

        public void validarAcoes()
        {
            if (getSetStatus == 0)
            {
                // BOTÕES
                BtnNovo.Enabled = false;
                BtnAlterar.Enabled = false;
                BtnAvancar.Enabled = false;
                BtnVoltar.Enabled = false;
                BtnID.Enabled = false;

                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = true;

                // CAMPOS
                TxtID.Enabled = false;

                TxtNome.Enabled = true;
                TxtSenha.Enabled = true;
                ChkInativo.Enabled = true;
                ChkOperador.Enabled = true;
                ChkCategoria.Enabled = true;
                ChkCliente.Enabled = true;
                ChkProduto.Enabled = true;
                ChkFormaPGTO.Enabled = true;
                ChkTabelaUsuarios.Enabled = true;
                ChkPedido.Enabled = true;
                ChkEntrada.Enabled = true;

                // PERMISSÃO ADMIN
                if (operadorLogado.getSetAdmin == true)
                {
                    ChkAdmin.Enabled = true;
                    ChkVerificarSenha.Visible = true;
                }

                // LIMPAR CAMPOS
                limpaCampos();
            }
            else if (getSetStatus == 1)
            {
                // BOTÕES
                BtnNovo.Enabled = false;
                BtnAlterar.Enabled = false;
                BtnAvancar.Enabled = false;
                BtnVoltar.Enabled = false;
                BtnID.Enabled = false;

                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = true;

                // CAMPOS
                TxtID.Enabled = false;

                TxtNome.Enabled = true;
                TxtSenha.Enabled = true;
                ChkInativo.Enabled = true;
                ChkOperador.Enabled = true;
                ChkCategoria.Enabled = true;
                ChkCliente.Enabled = true;
                ChkProduto.Enabled = true;
                ChkFormaPGTO.Enabled = true;
                ChkTabelaUsuarios.Enabled = true;
                ChkPedido.Enabled = true;
                ChkEntrada.Enabled = true;

                // PERMISSÃO ADMIN
                if (operadorLogado.getSetAdmin == true)
                {
                    ChkAdmin.Enabled = true;
                    ChkVerificarSenha.Visible = true;
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

                BtnCancelar.Enabled = false;
                BtnSalvar.Enabled = false;

                // CAMPOS
                TxtID.Enabled = true;

                TxtNome.Enabled = false;
                TxtSenha.Enabled = false;
                ChkAdmin.Enabled = false;
                ChkInativo.Enabled = false;
                ChkOperador.Enabled = false;
                ChkCategoria.Enabled = false;
                ChkCliente.Enabled = false;
                ChkProduto.Enabled = false;
                ChkFormaPGTO.Enabled = false;
                ChkTabelaUsuarios.Enabled = false;
                ChkPedido.Enabled = false;
                ChkEntrada.Enabled = false;

                // PERMISSÃO ADMIN
                if (operadorLogado.getSetAdmin == true)
                {
                    ChkVerificarSenha.Visible = true;
                }
            }
        }

        public void limpaCampos()
        {
            TxtNome.Text = string.Empty;
            TxtSenha.Text = string.Empty;

            ChkInativo.Checked = false;
            ChkAdmin.Checked = false;
            ChkOperador.Checked = false;
            ChkCategoria.Checked = false;
            ChkCliente.Checked = false;
            ChkProduto.Checked = false;
            ChkFormaPGTO.Checked = false;
            ChkTabelaUsuarios.Checked = false;
            ChkPedido.Checked = false;
            ChkEntrada.Checked = false;
        }

        public void ultimoRegistro()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                operador = WebService.GetRegistroInicialOperadorAsync().Result;

                TxtID.Text = operador.getSetID.ToString();
                TxtNome.Text = operador.getSetNome;
                TxtSenha.Text = operador.getSetSenha;
                ChkAdmin.Checked = operador.getSetAdmin;
                ChkInativo.Checked = operador.getSetStatus;
                ChkOperador.Checked = operador.getSetCadastroOperador;
                ChkCategoria.Checked = operador.getSetCadastroCategoria;
                ChkCliente.Checked = operador.getSetCadastroCliente;
                ChkProduto.Checked = operador.getSetCadastroProduto;
                ChkFormaPGTO.Checked = operador.getSetCadastroFormaPGTO;
                ChkTabelaUsuarios.Checked = operador.getSetTabelaUsuario;
                ChkPedido.Checked = operador.getSetPedidos;
                ChkEntrada.Checked = operador.getSetEntrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, NomeForm);
            }
        }

        public void preencheDados(int ID)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                operador = WebService.GetOperadorAsync(ID).Result;

                TxtID.Text = operador.getSetID.ToString();
                TxtNome.Text = operador.getSetNome;
                TxtSenha.Text = operador.getSetSenha;
                ChkAdmin.Checked = operador.getSetAdmin;
                ChkInativo.Checked = operador.getSetStatus;
                ChkOperador.Checked = operador.getSetCadastroOperador;
                ChkCategoria.Checked = operador.getSetCadastroCategoria;
                ChkCliente.Checked = operador.getSetCadastroCliente;
                ChkProduto.Checked = operador.getSetCadastroProduto;
                ChkFormaPGTO.Checked = operador.getSetCadastroFormaPGTO;
                ChkTabelaUsuarios.Checked = operador.getSetTabelaUsuario;
                ChkPedido.Checked = operador.getSetPedidos;
                ChkEntrada.Checked = operador.getSetEntrada;

                TxtID.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, NomeForm);
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

                TxtID.Text = WebService.GetProximoRegistroOperadorAsync().Result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, NomeForm);
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
                validar = MessageBox.Show("Deseja cancelar o Cadastro?", NomeForm, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(operador.getSetID);
                }
            }
            else if (getSetStatus == 1)
            {
                validar = MessageBox.Show("Deseja cancelar a Alteração?", NomeForm, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(operador.getSetID);
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

                int ID = WebService.VoltarRegistroOperadorAsync(Convert.ToInt32(TxtID.Text)).Result;

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

                int ID = WebService.AvancarRegistroOperadorAsync(Convert.ToInt32(TxtID.Text)).Result;

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
                    Operador operador = new Operador();
                    operador.getSetID = ID;
                    operador.getSetNome = TxtNome.Text;
                    operador.getSetSenha = TxtSenha.Text;
                    operador.getSetAdmin = ChkAdmin.Checked;
                    operador.getSetStatus = ChkInativo.Checked;
                    operador.getSetCadastroOperador = ChkOperador.Checked;
                    operador.getSetCadastroCategoria = ChkCategoria.Checked;
                    operador.getSetCadastroCliente = ChkCliente.Checked;
                    operador.getSetCadastroProduto = ChkProduto.Checked;
                    operador.getSetCadastroFormaPGTO = ChkFormaPGTO.Checked;
                    operador.getSetTabelaUsuario = ChkTabelaUsuarios.Checked;
                    operador.getSetPedidos = ChkPedido.Checked;
                    operador.getSetEntrada = ChkEntrada.Checked;

                    // NÃO IMPLEMENTEI AINDA -> VOU VER
                    //validarNome(operador);

                    validarRetorno(WebService.SalvarOperadorAsync(operador).Result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, NomeForm);
            }
        }

        public bool validarCampos()
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Necessário informar um Nome", NomeForm);
                TxtNome.Focus();
                return false;
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("Necessário informar uma Senha", NomeForm);
                TxtSenha.Focus();
                return false;
            }

            return true;
        }

        public void validarRetorno(int retorno)
        {
            if (retorno == 0)
            {
                MessageBox.Show("Registro alterado com Sucesso!", NomeForm);
                getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                validarAcoes();
            }
            else if (retorno == 1)
            {
                MessageBox.Show("Registro cadastrado com Sucesso!", NomeForm);
                getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                validarAcoes();
                ultimoRegistro();
            }
        }

        private void ChkVerificarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVerificarSenha.Checked)
            {
                TxtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
            }
        }

        private void FormCadastroOperador_FormClosing(object sender, FormClosingEventArgs e)
        {
            atualizarOperadorLogado();
        }

        public void atualizarOperadorLogado()
        {
            var WebService = new ServiceReference1.Service1Client();

            // ATUALIZA AS INFORMAÇÕES DO OPERADOR QUE ESTÁ SENDO UTILIZADO NO MOMENTO
            this.operadorLogado = WebService.GetOperadorAsync(operador.getSetID).Result;
            this.formMain.getSetOperador = this.operadorLogado;
            this.formMain.validarTelas();
        }

        private void BtnID_Click(object sender, EventArgs e)
        {
            FormPesquisa formPesquisa = new FormPesquisa(5, this); // 5 -> Pesquisa Operador

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

        private void FormCadastroOperador_KeyPress(object sender, KeyPressEventArgs e)
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
                    TxtNome.Focus();
                }
                else if (!TxtID.Text.Equals(""))
                {
                    preencheDados(Convert.ToInt32(TxtID.Text));

                    TxtID.Focus();
                }

                e.Handled = true;
            }
        }

        private void TxtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F4)
            {
                FormPesquisa pesquisa = new FormPesquisa(5, this); // 5 -> Pesquisa Operador

                validarPesquisa(pesquisa);
            }
        }
    }
}
