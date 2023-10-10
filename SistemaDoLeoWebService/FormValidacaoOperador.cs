using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDoLeoWebService
{
    public partial class FormValidacaoOperador : Form
    {
        private Operador operador;
        private string nomeForm = "Liberação de Acesso";
        private object TelaFonte;

        public FormValidacaoOperador(object telaFonte)
        {
            InitializeComponent();

            this.TelaFonte = telaFonte;

            this.Text = nomeForm;

            validarTelas();

            TxtID.Focus();
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                TxtSenha.Focus();
            }
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            // VAI CHAMAR A FUNÇÃO QUE CONECTA COM O WEB SERVICE
            // E CHAMAR O VALIDA OPERADOR

            int ID;
            var WebReference = new ServiceReference1.Service1Client();
            try
            {
                if (TxtID.Text != "")
                {
                    ID = int.Parse(TxtID.Text);
                    int resultado = WebReference.VerificaOperadorAsync(ID).Result;

                    if (resultado.Equals(0))
                    {
                        if (TxtID.Text.Equals("0"))
                        {
                            LblNomeOperador.Text = "Administrador";

                            definirPermissoesADMIN();
                        }
                        else
                        {
                            operador = WebReference.GetOperadorAsync(ID).Result;
                            LblNomeOperador.Text = operador.getSetNome;
                        }
                    }
                    else if (resultado.Equals(1))
                    {
                        MessageBox.Show("Operador " + ID + " Inativo", nomeForm);
                        TxtID.Text = "";
                        TxtID.Focus();
                    }
                    else if (resultado.Equals(2))
                    {
                        MessageBox.Show("Operador não Cadastrado", nomeForm);
                        TxtID.Text = "";
                        TxtID.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void definirPermissoesADMIN()
        {
            operador = new Operador();
            operador.getSetID = 0;
            operador.getSetNome = "Administrador";
            operador.getSetSenha = TxtSenha.ToString();
            operador.getSetAdmin = true;
            operador.getSetStatus = false;
            operador.getSetCadastroOperador = true;
            operador.getSetCadastroCategoria = true;
            operador.getSetCadastroCliente = true;
            operador.getSetCadastroProduto = true;
            operador.getSetCadastroFormaPGTO = true;
            operador.getSetTabelaUsuario = true;
            operador.getSetPedidos = true;
            operador.getSetEntrada = true;
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            limpaCamposMenosID();
        }

        private void limpaCampos()
        {
            TxtID.Text = string.Empty;
            TxtSenha.Text = string.Empty;
            LblNomeOperador.Text = string.Empty;
        }

        private void limpaCamposMenosID()
        {
            TxtSenha.Text = string.Empty;
            LblNomeOperador.Text = string.Empty;
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                BtnAcessar.Focus();
                e.Handled = true;
            }
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            // DECLARAÇÕES
            int ID;
            int Senha;
            var WebReference = new ServiceReference1.Service1Client();

            // VERIFICA SE OS CAMPOS ESTÃO PREENCHIDOS
            if (TxtID.Text == "")
            {
                MessageBox.Show("Informe um operador!", nomeForm);
                TxtID.Focus();
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("Informe a senha!", nomeForm);
                TxtSenha.Focus();
            }
            else
            {
                // PEGA OS DADOS DOS TXT'S
                ID = int.Parse(TxtID.Text);
                Senha = int.Parse(TxtSenha.Text);

                // CHAMA A FUNÇÃO DO WEB SERVICE
                int resultado = WebReference.VerificaLoginAsync(ID, Senha).Result;

                // VERIFICA OS RESULTADOS
                if (resultado.Equals(0))
                {
                    // DEU TUDO CERTO -> LIBERA AS ALTERAÇÕES
                    validarRetorno();
                }
                else if (resultado.Equals(1))
                {
                    MessageBox.Show("Senha incorreta!", nomeForm);
                    limpaCampos();
                    TxtID.Focus();
                }
                else if (resultado.Equals(2))
                {
                    MessageBox.Show("Operador " + ID + " inativo!", nomeForm);
                    limpaCampos();
                    TxtID.Focus();
                }
                else if (resultado.Equals(3))
                {
                    MessageBox.Show("Operador " + ID + " não Cadastrado", nomeForm);
                    limpaCampos();
                    TxtID.Focus();
                }
                else if (resultado.Equals(-1))
                {
                    MessageBox.Show("Ocorreu um erro ao tentar verificar o Operador", nomeForm);
                    limpaCampos();
                    TxtID.Focus();
                }
            }
        }

        private void validarTelas()
        {
            if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormPedido, Text: Pedidos")
            {
                this.Text += " - Pedidos";
            }
            else if (TelaFonte.ToString() == "SistemaDoLeoWebService.FormEntrada, Text: Pedido Entrada")
            {
                this.Text += " - Entradas";
            }
        }

        private void validarRetorno()
        {
            if (operador.getSetAdmin)
            {
                if (this.Text.Equals(nomeForm + " - Pedidos"))
                {
                    FormPedido pedido = (FormPedido)TelaFonte;

                    pedido.liberarPedido(true);

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show($"Usuário {operador.getSetID} não autorizado a fazer a liberação!", nomeForm);
                limpaCampos();
                TxtID.Focus();
            }

        }

        private void ValidacaoOperador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtID_Enter(object sender, EventArgs e)
        {
            TxtID.SelectAll();
        }

        private void TxtSenha_Enter(object sender, EventArgs e)
        {
            TxtSenha.SelectAll();
        }
    }
}
