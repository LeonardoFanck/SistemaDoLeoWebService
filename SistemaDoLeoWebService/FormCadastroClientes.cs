using ServiceReference1;
using SistemaDoLeoWebService.Class;
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

            // MOSTRANDO AS INFORMAÇÕES DO REGISTRO INICIAL NA TELA (ULTIMO REGISTRO)
            getSetStatus = 2;
            validarAcoes();  // 0 -> Novo | 1 -> Edição | 2 -> Visualização
            preencheUF();
            registroInicial();
        }

        private void registroInicial()
        {
            var WebReference = new ServiceReference1.Service1Client();

            //cliente = WebReference.getCliente().Result;

            TxtID.Text = produto.getSetID.ToString();
            TxtNome.Text = produto.getSetNome.ToString();
            TxtValor.Text = produto.getSetValor.ToString();
            foreach (var categoria in categorias)
            {
                if (produto.getSetCategoria == categoria.getSetID)
                {
                    CBoxCategoria.Text = categoria.getSetID + " - " + categoria.getSetNome;
                }
            }
            TxtCusto.Text = produto.getSetCusto.ToString();
            ChkBoxInativo.Checked = produto.getSetStatus;
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

        private void preencheUF()
        {
            /*
            var WebService = new ServiceReference1.Service1Client();

            categorias = new List<Categoria>(WebService.GetListNomeCategoriaAsync().Result);

            CBoxCategoria.Items.Add("");
            foreach (var categoria in categorias)
            {
                CBoxCategoria.Items.Add(categoria.getSetID + " - " + categoria.getSetNome);
            }
            */

            try
            {
                var WebService = new ServiceReference1.Service1Client();

                Estados = new List<Estados>(WebService.getListEstadosAsync().Result);

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

    }
}
