﻿using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDoLeoWebService
{
    public partial class FormCadastroFormaPGTO : Form
    {
        private string NomeForm = "Cadastro Forma de Pagamentos";
        private int Status;
        private FormaPGTO formaPGTO;
        private Operador operador;
        private FormMain formMain;

        public int getSetStatus
        {
            // 0 -> Novo Cadastro | 1 -> Edição | 2 -> Visualização
            get { return this.Status; }
            set { this.Status = value; }
        }

        public FormCadastroFormaPGTO(Operador operador, FormMain formMain)
        {
            this.operador = operador;
            this.formMain = formMain;

            InitializeComponent();
        }

        private void FormCadastroFormaPGTO_Load(object sender, EventArgs e)
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

                TxtNome.Focus();
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

                TxtNome.Focus();
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

                TxtID.Focus();
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

                formaPGTO = WebService.GetRegistroInicialFormaPGTOAsync().Result;

                TxtID.Text = formaPGTO.getSetID.ToString();
                TxtNome.Text = formaPGTO.getSetNome;
                ChkBoxInativo.Checked = formaPGTO.getSetStatus;
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

                formaPGTO = WebService.GetFormaPGTOAsync(ID).Result;

                TxtID.Text = formaPGTO.getSetID.ToString();
                TxtNome.Text = formaPGTO.getSetNome;
                ChkBoxInativo.Checked = formaPGTO.getSetStatus;

                TxtID.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, NomeForm);

                TxtID.Text = formaPGTO.getSetID.ToString();
                TxtID.SelectAll();
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

                TxtID.Text = WebService.GetProximoRegistroFormaPGTOAsync().Result.ToString();
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
                    preencheDados(formaPGTO.getSetID);
                }
            }
            else if (getSetStatus == 1)
            {
                validar = MessageBox.Show("Deseja cancelar a Alteração?", NomeForm, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencheDados(formaPGTO.getSetID);
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

                int ID = WebService.VoltarRegistroFormaPGTOAsync(Convert.ToInt32(TxtID.Text)).Result;

                preencheDados(ID);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message, NomeForm);
                TxtID.Text = formaPGTO.getSetID.ToString();
            }
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                var WebService = new ServiceReference1.Service1Client();

                int ID = WebService.AvancarRegistroFormaPGTOAsync(Convert.ToInt32(TxtID.Text)).Result;

                preencheDados(ID);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("" + ex.Message, NomeForm);
                TxtID.Text = formaPGTO.getSetID.ToString();
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
                    FormaPGTO formaPGTO = new FormaPGTO();
                    formaPGTO.getSetID = ID;
                    formaPGTO.getSetNome = TxtNome.Text;
                    formaPGTO.getSetStatus = ChkBoxInativo.Checked;

                    validarNome(formaPGTO);

                    validarRetorno(WebService.SalvarFormaPGTOAsync(formaPGTO).Result);
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

        public void validarNome(FormaPGTO formaPGTO)
        {
            var WebService = new ServiceReference1.Service1Client();

            int retorno = WebService.ValidarNomeFormaPGTOAsync(formaPGTO).Result;

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

        private void BtnID_Click(object sender, EventArgs e)
        {
            FormPesquisa formPesquisa = new FormPesquisa(3, this); // 3 -> LISTA FORMA PGTO

            formMain.Enabled = false;

            // CHAMA A FUNÇÃO QUE VALIDA O DESATIVAMENTO DO FORM MAIN QUANDO FECHA A LISTA DE PESQUISA
            validarPesquisa(formPesquisa);
        }

        private void validarPesquisa(FormPesquisa pesquisa)
        {
            // FUNÇÃO PARA QUANDO FECHAR O CONFIGURAÇÕES GERAIS, ATIVAR NOVAMENTE O FORMA MAIN
            pesquisa.FormClosed += (sender, e) =>
            {
                formMain.Enabled = true;
                TxtID.Focus();
            };

            pesquisa.Show();
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
                FormPesquisa pesquisa = new FormPesquisa(3, this); // 3 -> LISTA FORMA PGTO

                validarPesquisa(pesquisa);
            }
        }

        private void FormCadastroFormaPGTO_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                BtnSalvar.Focus();

                e.Handled = true;
            }
        }

        private void FormCadastroFormaPGTO_KeyDown(object sender, KeyEventArgs e)
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
    }
}
