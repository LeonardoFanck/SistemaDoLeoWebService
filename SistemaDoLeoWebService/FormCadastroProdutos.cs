using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace SistemaDoLeoWebService
{
    public partial class FormCadastroProdutos : Form
    {
        private int State;
        private Produto produto;
        private List<Categoria> categorias;
        private String nomeForm = "Cadastro Produto";

        public FormCadastroProdutos()
        {
            InitializeComponent();
        }

        private void BtnID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionou");
        }

        private void TxtID_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("->" + (byte)e.KeyValue);
            if (e.KeyValue == 115) // F4
            {
                BtnID_Click(sender, e);
            }
        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("->" + (byte)e.KeyChar);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // SOMENTE NÚMERO E BACKSPACE
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13) // ENTER
            {
                //buscarProduto();

                TxtID.Focus();
                e.Handled = true;
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
        }

        private void TxtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44) // SOMENTE NÚMERO E BACKSPACE E ,
            {
                e.Handled = true;
            }
        }

        private void FormCadastroProdutos_Load(object sender, EventArgs e)
        {
            // DEFINIR O NOME DO FORM
            this.Text = nomeForm;

            // MOSTRANDO AS INFORMAÇÕES DO PRODUTO INICIAL NA TELA
            getSetStatus = 2;
            validarAcoes();  // 0 -> Novo | 1 -> Edição | 2 -> Visualização
            preencheCategoria();
            PrimeiroProduto();
        }

        private void validarAcoes()  // 0 -> Novo | 1 -> Edição | 2 -> Visualização
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
                TxtValor.Enabled = true;
                TxtCusto.Enabled = true;
                ChkBoxInativo.Enabled = true;
                CBoxCategoria.Enabled = true;
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
                TxtValor.Enabled = true;
                TxtCusto.Enabled = true;
                ChkBoxInativo.Enabled = true;
                CBoxCategoria.Enabled = true;
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
                TxtValor.Enabled = false;
                TxtCusto.Enabled = false;
                ChkBoxInativo.Enabled = false;
                CBoxCategoria.Enabled = false;
            }
        }

        private void preencherDados(int ID)
        {
            // 0 -> Novo | 1 -> Edição | 2 -> Visualização
            if (getSetStatus == 0)
            {
                // PEGAR O ID DO PRODUTO
                // SELECT MAX + 1
                TxtID.Text = string.Empty;
                TxtNome.Text = string.Empty;
                CBoxCategoria.Text = string.Empty;
                TxtValor.Text = string.Empty;
                TxtCusto.Text = string.Empty;
                TxtEstoque.Text = string.Empty;
            }
            else if (getSetStatus == 2)
            {
                // PREENCHE COM AS INFORMAÇÕES DO PRODUTO
                // SELECT * FROM PRODUTO WHERE (ID PRODUTO)
                // EXECUTE CALCULA ESTOQUE (ID PRODUTO)
                try
                {
                    var WebReference = new ServiceReference1.Service1Client();

                    produto = WebReference.GetProdutoAsync(ID).Result;

                    TxtID.Text = produto.getSetID.ToString();
                    TxtNome.Text = produto.getSetNome.ToString();
                    foreach (var categoria in categorias)
                    {
                        if (produto.getSetCategoria == categoria.getSetID)
                        {
                            CBoxCategoria.Text = categoria.getSetID + " - " + categoria.getSetNome;
                        }
                    }
                    TxtValor.Text = produto.getSetValor.ToString();
                    TxtCusto.Text = produto.getSetCusto.ToString();
                    ChkBoxInativo.Checked = produto.getSetStatus;

                    TxtEstoque.Text = WebReference.GetEstoqueProdutoAsync(produto.getSetID).Result.ToString();
                }
                catch (Exception e)
                {

                }

            }
        }

        public void PrimeiroProduto()
        {
            var WebReference = new ServiceReference1.Service1Client();

            produto = WebReference.GetProdutoInicialAsync().Result;

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

            TxtEstoque.Text = WebReference.GetEstoqueProdutoAsync(produto.getSetID).Result.ToString();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            var WebService = new ServiceReference1.Service1Client();
            int ID;
            int novoID;

            try
            {
                //ID = Convert.ToInt32(TxtID.Text);
                ID = produto.getSetID;
                novoID = WebService.VoltarRegistroProdutoAsync(ID).Result;
                preencherDados(novoID);
                TxtID.Focus();
            }
            catch
            {
                TxtID.Focus();
            }
        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            var WebService = new ServiceReference1.Service1Client();
            int ID;
            int novoID;

            try
            {
                //ID = Convert.ToInt32(TxtID.Text);
                ID = produto.getSetID;
                novoID = WebService.AvancarRegistroProdutoAsync(ID).Result;
                preencherDados(novoID);
                TxtID.Focus();
            }
            catch
            {
                TxtID.Focus();
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            getSetStatus = 0; // STATUS 0 -> NOVO PRODUTO
            validarAcoes();
            preencherDados(produto.getSetID);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            validarCancelamento();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            getSetStatus = 1; // STATUS 1 -> ALTERAÇÃO
            validarAcoes();
        }

        public void validarCancelamento()
        {
            DialogResult validar;

            if (getSetStatus == 0)
            {
                validar = MessageBox.Show("Deseja cancelar o cadastro do Produto?", nomeForm, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencherDados(produto.getSetID);
                }
            }
            else if (getSetStatus == 1)
            {
                validar = MessageBox.Show("Deseja cancelar a alteração do Produto?", nomeForm, MessageBoxButtons.YesNo);

                if (validar == System.Windows.Forms.DialogResult.Yes)
                {
                    getSetStatus = 2; // STATUS 2 -> VISUALIZAÇÃO
                    validarAcoes();
                    preencherDados(produto.getSetID);
                }
            }
            else if (getSetStatus == 2)
            {
                this.Close();
            }
        }

        public void preencheCategoria()
        {
            var WebService = new ServiceReference1.Service1Client();

            categorias = new List<Categoria>(WebService.GetListNomeCategoriaAsync().Result);

            CBoxCategoria.Items.Add("");
            foreach (var categoria in categorias)
            {
                CBoxCategoria.Items.Add(categoria.getSetID + " - " + categoria.getSetNome);
            }
        }

        public int getSetStatus
        {
            get { return this.State; }
            set { this.State = value; }
        }
    }
}
