using Microsoft.VisualBasic;
using System.Data;

namespace SistemaDoLeoWebService
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                TxtSenha.Focus();
            }
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            // VAI CHAMAR A FUNÇÃO QUE CONECTA COM O WEB SERVICE
            // E CHAMAR O VALIDA OPERADOR

            int ID;
            var WebReference = new ServiceReference1.Service1Client();

            if (TxtID.Text != "")
            {
                ID = int.Parse(TxtID.Text);
                int resultado = WebReference.VerificaOperadorAsync(ID).Result;

                if (resultado.Equals(0))
                {
                    LblNomeOperador.Text = WebReference.getNomeOperadorAsync(ID).Result;
                }
                else if (resultado.Equals(1))
                {
                    MessageBox.Show("Operador " + ID + " Inativo", nomeForm());
                    TxtID.Text = "";
                    TxtID.Focus();
                }
                else if (resultado.Equals(2))
                {
                    MessageBox.Show("Operador não Cadastrado", nomeForm());
                    TxtID.Text = "";
                    TxtID.Focus();
                }
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            limpaCamposMenosID();
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                BtnAcessar.Focus();
                e.Handled = true;
            }
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

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            // DECLARAÇÕES
            int ID;
            int Senha;
            var WebReference = new ServiceReference1.Service1Client();

            // VERIFICA SE OS CAMPOS ESTÃO PREENCHIDOS
            if (TxtID.Text == "")
            {
                MessageBox.Show("Informe um operador!", nomeForm());
                TxtID.Focus();
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("Informe a senha!", nomeForm());
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
                    MessageBox.Show("Deu tudo certo!", nomeForm());
                }
                else if (resultado.Equals(1))
                {
                    MessageBox.Show("Senha incorreta!", nomeForm());
                    limpaCampos();
                    TxtID.Focus();
                }
                else if (resultado.Equals(2))
                {
                    MessageBox.Show("Operador " + ID + " inativo!", nomeForm());
                    limpaCampos();
                    TxtID.Focus();
                }
                else if (resultado.Equals(3))
                {
                    MessageBox.Show("Operador " + ID + " não Cadastrado", nomeForm());
                    limpaCampos();
                    TxtID.Focus();
                }
                else if (resultado.Equals(-1))
                {
                    MessageBox.Show("Ocorreu um erro ao tentar verificar o Operador", nomeForm());
                    limpaCampos();
                    TxtID.Focus();
                }
            }
        }

        private string nomeForm()
        {
            return "Login";
        }
    }

}