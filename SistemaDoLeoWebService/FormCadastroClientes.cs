using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace SistemaDoLeoWebService
{
    public partial class FormCadastroClientes : Form
    {
        private string nomeForm = "Cadastro Cliente";
        private int Status;
        private List<Estados> Estados;
        private Cliente cliente;
        private Operador operador;
        private FormMain formMain;
        private TipoClientes tipoCliente;

        private int getSetStatus
        {
            get { return Status; }
            set { Status = value; }
        }

        public FormCadastroClientes(Operador operador, FormMain formMain)
        {
            InitializeComponent();
            this.operador = operador;
            this.formMain = formMain;
        }

        private void FormCadastroClientes_Load(object sender, EventArgs e)
        {
            // DEFINIR O NOME DO FORM
            this.Text = nomeForm;

            ComboDocumento.Items.Add("CPF");
            ComboDocumento.Items.Add("CNPJ");

            // MOSTRANDO AS INFORMAÇÕES DO REGISTRO INICIAL NA TELA (ULTIMO REGISTRO)
            getSetStatus = 2;
            validarAcoes();  // 0 -> Novo | 1 -> Edição | 2 -> Visualização
            preencheUF();
            registroInicial();
        }

        private void registroInicial()
        {
            var WebService = new ServiceReference1.Service1Client();

            try
            {
                cliente = WebService.GetClienteInicialAsync().Result;
                TxtID.Text = cliente.getSetID.ToString();
                TxtNome.Text = cliente.getSetNome;
                if (cliente.getSetCPF.Length == 14)
                {
                    ComboDocumento.Text = "CPF";
                }
                else // OU == 18
                {
                    ComboDocumento.Text = "CNPJ";
                }
                TxtMDocumento.Text = cliente.getSetCPF;
                TxtEmail.Text = cliente.getSetEmail;
                TxtMDtNasc.Text = cliente.getSetDtNascimento;
                CBoxUF.Text = cliente.getSetEstado;
                TxtCidade.Text = cliente.getSetCidade;
                TxtBairro.Text = cliente.getSetBairro;
                TxtEndereco.Text = cliente.getSetEndereco;
                TxtNumero.Text = cliente.getSetNumero;
                ChkBoxInativo.Checked = cliente.getSetStatus;
                if (cliente.getSetMoradia == 1)
                {
                    RBtnCasa.Checked = true;
                }
                else // OU == 2
                {
                    RBtnApart.Checked = true;
                }

                // TIPO CLIENTE
                tipoCliente = WebService.GetTipoClientesAsync(cliente.getSetID).Result;
                ChkBoxCliente.Checked = tipoCliente.getSetTipoCliente;
                ChkBoxFornecedor.Checked = tipoCliente.getSetTipoFornecedor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar carregar o registro!", nomeForm);
            }
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

                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = true;

                // CAMPOS
                TxtID.Enabled = false;

                TxtNome.Enabled = true;
                ComboDocumento.Enabled = true;
                TxtMDocumento.Enabled = true;
                TxtEmail.Enabled = true;
                TxtMDtNasc.Enabled = true;
                TxtCEP.Enabled = true;
                CBoxUF.Enabled = true;
                TxtCidade.Enabled = true;
                TxtBairro.Enabled = true;
                TxtEndereco.Enabled = true;
                TxtNumero.Enabled = true;
                ChkBoxInativo.Enabled = true;
                ChkBoxCliente.Enabled = true;
                ChkBoxFornecedor.Enabled = true;
                RBtnCasa.Enabled = true;
                RBtnApart.Enabled = true;

                TxtMDtNasc.Focus();
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
                ComboDocumento.Enabled = true;
                TxtMDocumento.Enabled = true;
                TxtEmail.Enabled = true;
                TxtMDtNasc.Enabled = true;
                TxtCEP.Enabled = true;
                CBoxUF.Enabled = true;
                TxtCidade.Enabled = true;
                TxtBairro.Enabled = true;
                TxtEndereco.Enabled = true;
                TxtNumero.Enabled = true;
                ChkBoxInativo.Enabled = true;
                ChkBoxCliente.Enabled = true;
                ChkBoxFornecedor.Enabled = true;
                RBtnCasa.Enabled = true;
                RBtnApart.Enabled = true;

                TxtMDtNasc.Focus();
            }
            else if (getSetStatus == 2)
            {
                // BOTÕES
                BtnNovo.Enabled = true;
                BtnAlterar.Enabled = true;
                BtnAvancar.Enabled = true;
                BtnVoltar.Enabled = true;
                BtnID.Enabled = true;
                BtnCancelar.Enabled = true;

                BtnSalvar.Enabled = false;

                // CAMPOS
                TxtID.Enabled = true;

                TxtNome.Enabled = false;
                ComboDocumento.Enabled = false;
                TxtMDocumento.Enabled = false;
                TxtEmail.Enabled = false;
                TxtMDtNasc.Enabled = false;
                TxtCEP.Enabled = false;
                CBoxUF.Enabled = false;
                TxtCidade.Enabled = false;
                TxtBairro.Enabled = false;
                TxtEndereco.Enabled = false;
                TxtNumero.Enabled = false;
                ChkBoxInativo.Enabled = false;
                ChkBoxCliente.Enabled = false;
                ChkBoxFornecedor.Enabled = false;
                RBtnCasa.Enabled = false;
                RBtnApart.Enabled = false;

                TxtID.Focus();
            }
        }

        public void preencheDados(int ID)
        {
            // 0 -> Novo | 1 -> Edição | 2 -> Visualização
            if (getSetStatus == 0)
            {
                // PEGAR O ID DO PRODUTO
                // SELECT MAX + 1
                //proximoRegistro();
                TxtNome.Text = string.Empty;
                ComboDocumento.Text = string.Empty;
                TxtMDocumento.Text = "CPF";
                TxtEmail.Text = string.Empty;
                TxtMDtNasc.Text = string.Empty;
                TxtCEP.Text = string.Empty;
                CBoxUF.Text = string.Empty;
                TxtCidade.Text = string.Empty;
                TxtBairro.Text = string.Empty;
                TxtEndereco.Text = string.Empty;
                TxtNumero.Text = string.Empty;
                ChkBoxInativo.Checked = false;
                RBtnCasa.Checked = false;
                RBtnApart.Checked = false;
                ChkBoxCliente.Checked = false;
                ChkBoxFornecedor.Checked = false;
            }
            else if (getSetStatus == 2)
            {
                // PREENCHE COM AS INFORMAÇÕES DO CLIENTE
                // SELECT * FROM CLIENTES WHERE (IDCLIENTE)
                try
                {
                    var WebService = new ServiceReference1.Service1Client();

                    cliente = WebService.GetClienteAsync(ID).Result;

                    TxtID.Text = cliente.getSetID.ToString();
                    TxtNome.Text = cliente.getSetNome;
                    if (cliente.getSetCPF.Length == 14)
                    {
                        ComboDocumento.Text = "CPF";
                    }
                    else // OU == 18
                    {
                        ComboDocumento.Text = "CNPJ";
                    }
                    TxtMDocumento.Text = cliente.getSetCPF;
                    TxtEmail.Text = cliente.getSetEmail;
                    TxtMDtNasc.Text = cliente.getSetDtNascimento;
                    TxtCEP.Text = cliente.getSetCEP;
                    CBoxUF.Text = cliente.getSetEstado;
                    TxtCidade.Text = cliente.getSetCidade;
                    TxtBairro.Text = cliente.getSetBairro;
                    TxtEndereco.Text = cliente.getSetEndereco;
                    TxtNumero.Text = cliente.getSetNumero;
                    ChkBoxInativo.Checked = cliente.getSetStatus;
                    if (cliente.getSetMoradia == 1)
                    {
                        RBtnCasa.Checked = true;
                    }
                    else // OU == 2
                    {
                        RBtnApart.Checked = true;
                    }

                    // TIPO CLIENTE
                    tipoCliente = WebService.GetTipoClientesAsync(cliente.getSetID).Result;
                    ChkBoxCliente.Checked = tipoCliente.getSetTipoCliente;
                    ChkBoxFornecedor.Checked = tipoCliente.getSetTipoFornecedor;

                    // MANTEM SEMPRE O TXT ID COM O TEXTO SELECIONADO
                    TxtID.SelectAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void preencheUF()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                Estados = new List<Estados>(WebService.GetListEstadosAsync().Result);

                CBoxUF.Items.Add("");
                foreach (var estado in Estados)
                {
                    CBoxUF.Items.Add(estado.getSetUF);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, nomeForm);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            var WebService = new ServiceReference1.Service1Client();
            int ID;
            int novoID;

            try
            {
                ID = cliente.getSetID;
                novoID = WebService.VoltarRegistroClienteAsync(ID).Result;
                preencheDados(novoID);
                TxtID.Focus();
            }
            catch (Exception ex)
            {
                TxtID.Focus();
                //MessageBox.Show(ex.Message); CLIENTE NÃO LOCALIZADO
            }
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            var WebService = new ServiceReference1.Service1Client();
            int ID;
            int novoID;

            try
            {
                ID = cliente.getSetID;
                novoID = WebService.AvancarRegistroClienteAsync(ID).Result;
                preencheDados(novoID);
                TxtID.Focus();
            }
            catch
            {
                TxtID.Focus();
            }
        }

        private void ComboDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboDocumento.Text.Equals("CPF"))
            {
                TxtMDocumento.Text = string.Empty;
                TxtMDocumento.Mask = "###,###,###-##";
            }
            else // OU .EQUALS("CNPJ")
            {
                TxtMDocumento.Text = string.Empty;
                TxtMDocumento.Mask = "##,###,###/####-##";
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            getSetStatus = 0;
            proximoRegistro();
            validarAcoes();
            preencheDados(Convert.ToInt32(TxtID.Text));
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            getSetStatus = 1;
            validarAcoes();
        }

        public void proximoRegistro()
        {
            var WebService = new ServiceReference1.Service1Client();

            TxtID.Text = WebService.GetProximoRegistroClienteAsync().Result.ToString();
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
                validar = MessageBox.Show("Deseja cancelar o Cadastro?", nomeForm, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(cliente.getSetID);
                }
            }
            else if (getSetStatus == 1)
            {
                validar = MessageBox.Show("Deseja cancelar a Alteração?", nomeForm, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(cliente.getSetID);
                }
            }
            else if (getSetStatus == 2)
            {
                this.Close();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();
                int ID;

                // SE ID -1 É UM NOVO CADASTRO
                // SENÃO ALTERAÇÃO
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

                    Cliente cliente = new Cliente();
                    cliente.getSetID = ID;
                    cliente.getSetNome = TxtNome.Text;
                    cliente.getSetCPF = TxtMDocumento.Text;
                    cliente.getSetEmail = TxtEmail.Text;
                    cliente.getSetDtNascimento = TxtMDtNasc.Text;
                    cliente.getSetCEP = TxtCEP.Text;
                    cliente.getSetEstado = CBoxUF.Text;
                    cliente.getSetCidade = TxtCidade.Text;
                    cliente.getSetBairro = TxtBairro.Text;
                    cliente.getSetEndereco = TxtEndereco.Text;
                    cliente.getSetNumero = TxtNumero.Text;
                    cliente.getSetStatus = ChkBoxInativo.Checked;
                    if (RBtnCasa.Checked == true)
                    {
                        cliente.getSetMoradia = 1;
                    }
                    else // OU RBtnApart == TRUE
                    {
                        cliente.getSetMoradia = 2;
                    }

                    TipoClientes tipoCliente = new TipoClientes();
                    tipoCliente.getSetTipoCliente = ChkBoxCliente.Checked;
                    tipoCliente.getSetTipoFornecedor = ChkBoxFornecedor.Checked;

                    validarRetorno(WebService.SalvarClienteAsync(cliente, tipoCliente).Result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void validarRetorno(int retorno)
        {
            if (retorno == 0)
            {
                MessageBox.Show("Registro alterado com Sucesso!", nomeForm);
                getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                validarAcoes();
            }
            else if (retorno == 1)
            {
                MessageBox.Show("Registro cadastrado com Sucesso!", nomeForm);
                getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                validarAcoes();
                registroInicial();
            }
            else if (retorno == 2)
            {
                MessageBox.Show("Ocorreu algum erro ao tentar finalizar a Operação", nomeForm);
            }
        }

        public bool validarCampos()
        {
            if (TxtMDtNasc.Text.Equals("  /  /"))
            {
                MessageBox.Show("Necessário informar uma Data de Nascimento", nomeForm);
                TxtMDtNasc.Focus();
                return false;
            }
            else if (TxtNome.Text == "")
            {
                MessageBox.Show("Necessário informar um Nome", nomeForm);
                TxtNome.Focus();
                return false;
            }
            else if (TxtMDocumento.Text.Length != 14 && TxtMDocumento.Text.Length != 18)
            {
                MessageBox.Show("Necessário informar um Documento", nomeForm);
                TxtMDocumento.Focus();
                return false;
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("Necessário informar um Email", nomeForm);
                TxtEmail.Focus();
                return false;
            }
            else if (TxtCEP.Text.Equals("  .   -"))
            {
                MessageBox.Show("Necessário informar um CEP!", nomeForm);
                TxtCEP.Focus();
                return false;
            }
            else if (CBoxUF.Text == "")
            {
                MessageBox.Show("Necessário informar uma UF", nomeForm);
                CBoxUF.Focus();
                return false;
            }
            else if (TxtCidade.Text == "")
            {
                MessageBox.Show("Necessário informar uma Cidade", nomeForm);
                TxtCidade.Focus();
                return false;
            }
            else if (TxtBairro.Text == "")
            {
                MessageBox.Show("Necessário informar um Bairro", nomeForm);
                TxtBairro.Focus();
                return false;
            }
            else if (TxtEndereco.Text == "")
            {
                MessageBox.Show("Necessário informar um Endereço", nomeForm);
                TxtEndereco.Focus();
                return false;
            }
            else if (TxtNumero.Text == "")
            {
                MessageBox.Show("Necessário informar um número", nomeForm);
                TxtNumero.Focus();
                return false;
            }
            else if (RBtnApart.Checked == false && RBtnCasa.Checked == false)
            {
                MessageBox.Show("Necessário informar uma Moradia", nomeForm);
                RBtnCasa.Focus();
                return false;
            }
            else if (ChkBoxCliente.Checked == false && ChkBoxFornecedor.Checked == false)
            {
                MessageBox.Show("Necessário informar um Tipo", nomeForm);
                ChkBoxCliente.Focus();
                return false;
            }

            return true;
        }

        private void BtnID_Click(object sender, EventArgs e)
        {
            FormPesquisa formPesquisa = new FormPesquisa(0, this); // 0 -> Pesquisa Cliente

            formMain.Enabled = false;

            // FUNÇÃO PARA QUANDO FECHAR O CONFIGURAÇÕES GERAIS, ATIVAR NOVAMENTE O FORMA MAIN
            formPesquisa.FormClosed += (sender, e) =>
            {
                formMain.Enabled = true;
                TxtID.Focus();
            };

            formPesquisa.Show();
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {

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
                FormPesquisa formPesquisa = new FormPesquisa(0, this); // 0 -> Pesquisa Cliente

                formMain.Enabled = false;

                // FUNÇÃO PARA QUANDO FECHAR O CONFIGURAÇÕES GERAIS, ATIVAR NOVAMENTE O FORMA MAIN
                formPesquisa.FormClosed += (sender, e) =>
                {
                    formMain.Enabled = true;
                    TxtID.Focus();
                };

                formPesquisa.Show();
            }
        }

        private void FormCadastroClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27) // ESC
            {
                if (getSetStatus == 2)
                {
                    Close();
                    e.Handled = true;
                }
                else
                {
                    validarCancelamento();
                    e.Handled = true;
                }
            }
        }

        private void FormCadastroClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (getSetStatus != 2)
            {
                if (e.KeyValue == (char)Keys.F3)
                {
                    BtnSalvar_Click(sender, e);
                }
            }
            else
            {
                if (e.KeyValue == (char)Keys.F2)
                {
                    BtnNovo_Click(sender, e);
                }
            }
        }

        private async void TxtCEP_Leave(object sender, EventArgs e)
        {

        }

        private void TxtMDtNasc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                TxtNome.Focus();
                e.Handled = true;
            }
        }

        private void TxtMDtNasc_Leave(object sender, EventArgs e)
        {
            if (TxtMDtNasc.Text != "  /  /")
            {
                validarData(TxtMDtNasc.Text);
            }
        }

        private void validarData(string data)
        {
            // DATA INVÁLIDA
            if (!DateTime.TryParse(data, out DateTime date))
            {
                MessageBox.Show("Data Inválida!", nomeForm);

                TxtMDtNasc.Text = string.Empty;
                TxtMDtNasc.Focus();
            }
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                ComboDocumento.Focus();
                e.Handled = true;
            }
        }

        private void ComboDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                TxtMDocumento.Focus();
                e.Handled = true;
            }
        }

        private void TxtMDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                TxtEmail.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                TxtCEP.Focus();
                e.Handled = true;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (!TxtEmail.Text.Equals(""))
            {
                if (!validarEmail(TxtEmail.Text))
                {
                    MessageBox.Show("Email Inválido!", nomeForm);
                    TxtEmail.Focus();
                }
            }
        }

        private bool validarEmail(string email)
        {
            try
            {
                var endEmail = new System.Net.Mail.MailAddress(email);
                return endEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void TxtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                try
                {
                    if (!TxtCEP.Text.Equals("  .   -"))
                    {
                        var consulta = new CorreiosService.AtendeClienteClient();
                        string CEP = TxtCEP.Text;

                        // RETIRA OS CARACTERES ESPECIAIS
                        CEP = CEP.Replace(".", "").Replace("-", "");

                        // FAZ A CONSULTA NA API DO CORREIOS
                        var resultado = consulta.consultaCEPAsync(CEP).Result;

                        // PREENCHE OS CAMPOS
                        CBoxUF.Text = resultado.@return.uf;
                        TxtCidade.Text = resultado.@return.cidade;
                        TxtBairro.Text = resultado.@return.bairro;
                        TxtEndereco.Text = resultado.@return.end;

                        CBoxUF.Focus();
                        e.Handled = true;
                    }
                    else
                    {
                        CBoxUF.Focus();
                        e.Handled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, nomeForm);
                }
            }
        }

        private void CBoxUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                TxtCidade.Focus();
                e.Handled = true;
            }
        }

        private void TxtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                TxtBairro.Focus();
                e.Handled = true;
            }
        }

        private void TxtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                TxtEndereco.Focus();
                e.Handled = true;
            }
        }

        private void TxtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                TxtNumero.Focus();
                e.Handled = true;
            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                RBtnCasa.Focus();
                e.Handled = true;
            }
        }

        private void RBtnCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                ChkBoxCliente.Focus();
                e.Handled = true;
            }
        }

        private void RBtnApart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                ChkBoxCliente.Focus();
                e.Handled = true;
            }
        }

        private void ChkBoxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                BtnSalvar.Focus();
                e.Handled = true;
            }
        }

        private void ChkBoxFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                BtnSalvar.Focus();
                e.Handled = true;
            }
        }

        private void TxtMDtNasc_Enter(object sender, EventArgs e)
        {
            TxtMDtNasc.SelectAll();
        }

        private void TxtCEP_Enter(object sender, EventArgs e)
        {
            TxtCEP.SelectAll();
        }

        private bool validarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        private bool validarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void TxtMDocumento_Leave(object sender, EventArgs e)
        {
            if (ComboDocumento.Text.Equals("CPF"))
            {
                if (!TxtMDocumento.Text.Equals("   .   .   -"))
                {
                    if (!validarCPF(TxtMDocumento.Text))
                    {
                        MessageBox.Show("Documento Inválido!", nomeForm);
                        TxtMDocumento.Text = string.Empty;
                        TxtMDocumento.Focus();
                    }
                }
            }
            else if (ComboDocumento.Text.Equals("CNPJ"))
            {
                if (!TxtMDocumento.Text.Equals("  .   .   /    -"))
                {
                    if (!validarCNPJ(TxtMDocumento.Text))
                    {
                        MessageBox.Show("Documento Inválido!", nomeForm);
                        TxtMDocumento.Text = string.Empty;
                        TxtMDocumento.Focus();
                    }
                }
            }
        }
    }
}
