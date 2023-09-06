namespace SistemaDoLeoWebService
{
    partial class FormCadastroOperador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnID = new Button();
            TxtID = new TextBox();
            label1 = new Label();
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            tabControl1 = new TabControl();
            TabDados = new TabPage();
            TabTelas = new TabPage();
            ChkVerificarSenha = new CheckBox();
            TxtSenha = new TextBox();
            label3 = new Label();
            ChkAdmin = new CheckBox();
            ChkBoxInativo = new CheckBox();
            checkBox1 = new CheckBox();
            TxtNome = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            TabDados.SuspendLayout();
            TabTelas.SuspendLayout();
            SuspendLayout();
            // 
            // BtnID
            // 
            BtnID.Location = new Point(68, 20);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 63;
            BtnID.Text = "->";
            BtnID.UseVisualStyleBackColor = true;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(129, 21);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 59;
            label1.Text = "ID";
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(186, 413);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 58;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(150, 413);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 57;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(368, 403);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 56;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(265, 403);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 55;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(574, 403);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 54;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(471, 403);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 53;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabDados);
            tabControl1.Controls.Add(TabTelas);
            tabControl1.Location = new Point(12, 69);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(770, 328);
            tabControl1.TabIndex = 69;
            // 
            // TabDados
            // 
            TabDados.Controls.Add(ChkAdmin);
            TabDados.Controls.Add(ChkBoxInativo);
            TabDados.Controls.Add(ChkVerificarSenha);
            TabDados.Controls.Add(TxtSenha);
            TabDados.Controls.Add(label3);
            TabDados.Location = new Point(4, 24);
            TabDados.Name = "TabDados";
            TabDados.Padding = new Padding(3);
            TabDados.Size = new Size(762, 300);
            TabDados.TabIndex = 0;
            TabDados.Text = "Dados";
            TabDados.UseVisualStyleBackColor = true;
            // 
            // TabTelas
            // 
            TabTelas.Controls.Add(checkBox1);
            TabTelas.Location = new Point(4, 24);
            TabTelas.Name = "TabTelas";
            TabTelas.Padding = new Padding(3);
            TabTelas.Size = new Size(762, 300);
            TabTelas.TabIndex = 1;
            TabTelas.Text = "Telas";
            TabTelas.UseVisualStyleBackColor = true;
            // 
            // ChkVerificarSenha
            // 
            ChkVerificarSenha.AutoSize = true;
            ChkVerificarSenha.Location = new Point(434, 17);
            ChkVerificarSenha.Name = "ChkVerificarSenha";
            ChkVerificarSenha.Size = new Size(38, 19);
            ChkVerificarSenha.TabIndex = 73;
            ChkVerificarSenha.Text = "👁️";
            ChkVerificarSenha.UseVisualStyleBackColor = true;
            // 
            // TxtSenha
            // 
            TxtSenha.Location = new Point(59, 15);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '*';
            TxtSenha.Size = new Size(369, 23);
            TxtSenha.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 18);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 71;
            label3.Text = "Senha";
            // 
            // ChkAdmin
            // 
            ChkAdmin.AutoSize = true;
            ChkAdmin.Location = new Point(31, 101);
            ChkAdmin.Name = "ChkAdmin";
            ChkAdmin.Size = new Size(102, 19);
            ChkAdmin.TabIndex = 75;
            ChkAdmin.Text = "Administrador";
            ChkAdmin.UseVisualStyleBackColor = true;
            // 
            // ChkBoxInativo
            // 
            ChkBoxInativo.AutoSize = true;
            ChkBoxInativo.Location = new Point(31, 64);
            ChkBoxInativo.Name = "ChkBoxInativo";
            ChkBoxInativo.Size = new Size(62, 19);
            ChkBoxInativo.TabIndex = 74;
            ChkBoxInativo.Text = "Inativo";
            ChkBoxInativo.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(10, 20);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(328, 26);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(369, 23);
            TxtNome.TabIndex = 74;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 29);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 73;
            label2.Text = "Nome";
            // 
            // FormCadastroOperador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtNome);
            Controls.Add(label2);
            Controls.Add(tabControl1);
            Controls.Add(BtnID);
            Controls.Add(TxtID);
            Controls.Add(label1);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            Name = "FormCadastroOperador";
            Text = "FormCadastroOperador";
            tabControl1.ResumeLayout(false);
            TabDados.ResumeLayout(false);
            TabDados.PerformLayout();
            TabTelas.ResumeLayout(false);
            TabTelas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnID;
        private TextBox TxtID;
        private Label label1;
        private Button BtnAvancar;
        private Button BtnVoltar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private TabControl tabControl1;
        private TabPage TabDados;
        private CheckBox ChkAdmin;
        private CheckBox ChkBoxInativo;
        private CheckBox ChkVerificarSenha;
        private TextBox TxtSenha;
        private Label label3;
        private TabPage TabTelas;
        private CheckBox checkBox1;
        private TextBox TxtNome;
        private Label label2;
    }
}