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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE N�MERO E BACKSPACE
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
            // VAI CHAMAR A FUN��O QUE CONECTA COM O WEB SERVICE
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
                    MessageBox.Show("Operador " + ID + " Inativo");
                    TxtID.Text = "";
                    TxtID.Focus();
                }
                else if (resultado.Equals(2))
                {
                    MessageBox.Show("Operador n�o Cadastrado");
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
            limpaCampos();
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // ENTER
            {
                BtnAcessar.Focus();
            }
        }

        private void limpaCampos()
        {
            TxtSenha.Text = string.Empty;
            LblNomeOperador.Text = string.Empty;
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            // DECLARA��ES
            int ID;
            int Senha;
            var WebReference = new ServiceReference1.Service1Client();

            // VERIFICA SE OS CAMPOS EST�O PREENCHIDOS
            if (TxtID.Text == "")
            {
                MessageBox.Show("Informe um operador!");
                TxtID.Focus();
            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("Informe a senha!");
                TxtSenha.Focus();
            }
            else
            {
                // PEGA OS DADOS DOS TXT'S
                ID = int.Parse(TxtID.Text);
                Senha = int.Parse(TxtSenha.Text);

                // CHAMA A FUN��O DO WEB SERVICE
                int resultado = WebReference.VerificaOperadorAsync(ID).Result;

                // VERIFICA OS RESULTADOS
                if (resultado.Equals(0))
                {
                    LblNomeOperador.Text = WebReference.getNomeOperadorAsync(ID).Result;
                }
                else if (resultado.Equals(1))
                {
                    MessageBox.Show("Operador " + ID + " Inativo");
                    TxtID.Text = "";
                    TxtID.Focus();
                }
                else if (resultado.Equals(2))
                {
                    MessageBox.Show("Operador n�o Cadastrado");
                    TxtID.Text = "";
                    TxtID.Focus();
                }
                else if (resultado.Equals(-1))
                {
                    MessageBox.Show("Ocorreu um erro ao tentar verificar o Operador");
                    TxtID.Text = "";
                    TxtID.Focus();
                }
            }
        }
    }

}