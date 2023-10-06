using Microsoft.VisualBasic;
using ServiceReference1;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;

namespace SistemaDoLeoWebService
{
    public partial class FormLogin : Form
    {
        private Thread thread;
        private Operador operador;

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
                    // CHAMA O FORM MAIN
                    this.Close();
                    thread = new Thread(abriNovaJanela); // CRIA UMA NOVA THREAD PASSANDO O METODO QUE CHAMA A NOVA TELA
                    thread.SetApartmentState(ApartmentState.STA); // DEFINE O ESTADO DA THREAD ANTES DELA SER INICIALIZADA
                    thread.Start(); // STARTA A THREAD
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

        private void abriNovaJanela()
        {
            Application.Run(new FormMain(operador));
        }

        private string nomeForm()
        {
            return "Login";
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    }

}