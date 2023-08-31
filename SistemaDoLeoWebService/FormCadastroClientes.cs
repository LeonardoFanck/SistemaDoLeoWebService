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
    public partial class FormCadastroClientes : Form
    {
        private string nomeForm = "Cadastro Cliente";
        private int Status;
        private List<Estados> Estados;
        private Cliente cliente;
        private TipoClientes tipoCliente;

        private int getSetStatus
        {
            get { return Status; }
            set { Status = value; }
        }

        public FormCadastroClientes()
        {
            InitializeComponent();
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
                CBoxUF.Enabled = true;
                TxtCidade.Enabled = true;
                TxtEndereco.Enabled = true;
                TxtNumero.Enabled = true;
                ChkBoxInativo.Enabled = true;
                ChkBoxCliente.Enabled = true;
                ChkBoxFornecedor.Enabled = true;
                RBtnCasa.Enabled = true;
                RBtnApart.Enabled = true;

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
                CBoxUF.Enabled = true;
                TxtCidade.Enabled = true;
                TxtEndereco.Enabled = true;
                TxtNumero.Enabled = true;
                ChkBoxInativo.Enabled = true;
                ChkBoxCliente.Enabled = true;
                ChkBoxFornecedor.Enabled = true;
                RBtnCasa.Enabled = true;
                RBtnApart.Enabled = true;
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
                CBoxUF.Enabled = false;
                TxtCidade.Enabled = false;
                TxtEndereco.Enabled = false;
                TxtNumero.Enabled = false;
                ChkBoxInativo.Enabled = false;
                ChkBoxCliente.Enabled = false;
                ChkBoxFornecedor.Enabled = false;
                RBtnCasa.Enabled = false;
                RBtnApart.Enabled = false;
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
                CBoxUF.Text = string.Empty;
                TxtCidade.Text = string.Empty;
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
                    CBoxUF.Text = cliente.getSetEstado;
                    TxtCidade.Text = cliente.getSetCidade;
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
            var WebService = new ServiceReference1.Service1Client();
            int ID;

            ID = Convert.ToInt32(TxtID.Text);

            if (validarCampos() == true)
            {

                Cliente cliente = new Cliente();
                cliente.getSetID = ID;
                cliente.getSetNome = TxtNome.Text;
                cliente.getSetCPF = TxtMDocumento.Text;
                cliente.getSetEmail = TxtEmail.Text;
                cliente.getSetDtNascimento = TxtMDtNasc.Text;
                cliente.getSetEstado = CBoxUF.Text;
                cliente.getSetCidade = TxtCidade.Text;
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

                //validarRetorno(WebService.SalvarProdutoAsync(produto).Result); CRIAR O SALVAR CLIENTE e TIPO CLIENTE
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
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Necessário informar um Nome", nomeForm);
                TxtNome.Focus();
                return false;
            }
            else if (TxtMDocumento.Text.Length != 14 || TxtMDocumento.Text.Length != 19)
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
            else if (TxtMDtNasc.Text == "")
            {
                MessageBox.Show("Necessário informar uma Data de Nascimento", nomeForm);
                TxtMDtNasc.Focus();
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
    }
}
