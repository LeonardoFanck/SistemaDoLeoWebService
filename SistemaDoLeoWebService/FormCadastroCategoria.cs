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
    public partial class FormCadastroCategoria : Form
    {
        private string NomeForm = "Cadastro Categoria";
        private int Status;
        private Categoria categoria;

        public int getSetStatus
        {
            // 0 -> Novo Cadastro | 1 -> Edição | 2 -> Visualização
            get { return this.Status; }
            set { this.Status = value; }
        }

        public FormCadastroCategoria()
        {
            InitializeComponent();
        }

        private void FormCadastroCategoria_Load(object sender, EventArgs e)
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
                ChkBoxInativo.Enabled = true;

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
                ChkBoxInativo.Enabled = true;
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
                ChkBoxInativo.Enabled = false;
            }
        }

        public void limpaCampos()
        {
            TxtNome.Text = string.Empty;
            ChkBoxInativo.Checked = false;
        }

        public void ultimoRegistro()
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                categoria = WebService.GetRegistroInicialCategoriaAsync().Result;

                TxtID.Text = categoria.getSetID.ToString();
                TxtNome.Text = categoria.getSetNome;
                ChkBoxInativo.Checked = categoria.getSetStatus;
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

                categoria = WebService.GetCategoriaAsync(ID).Result;

                TxtID.Text = categoria.getSetID.ToString();
                TxtNome.Text = categoria.getSetNome;
                ChkBoxInativo.Checked = categoria.getSetStatus;
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

                TxtID.Text = WebService.GetProximoRegistroCategoriaAsync().Result.ToString();
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
                    preencheDados(categoria.getSetID);
                }
            }
            else if (getSetStatus == 1)
            {
                validar = MessageBox.Show("Deseja cancelar a Alteração?", NomeForm, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(categoria.getSetID);
                }
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                int ID = WebService.VoltarRegistroCategoriaAsync(Convert.ToInt32(TxtID.Text)).Result;

                preencheDados(ID);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message, NomeForm);
                TxtID.Text = categoria.getSetID.ToString();
            }
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                int ID = WebService.AvancarRegistroCategoriaAsync(Convert.ToInt32(TxtID.Text)).Result;

                preencheDados(ID);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message, NomeForm);
                TxtID.Text = categoria.getSetID.ToString();
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
                    Categoria categoria = new Categoria();
                    categoria.getSetID = ID;
                    categoria.getSetNome = TxtNome.Text;
                    categoria.getSetStatus = ChkBoxInativo.Checked;

                    validarNome(categoria);

                    validarRetorno(WebService.SalvarCategoriaAsync(categoria).Result);
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

            return true;
        }

        public void validarNome(Categoria categoria)
        {
            var WebService = new ServiceReference1.Service1Client();

            int retorno = WebService.ValidarNomeCategoriaAsync(categoria).Result;

            if (retorno == -1)
            {

            }
            else
            {
                throw new Exception("Nome já utilizado no registro: " + retorno);
            }
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
    }
}
