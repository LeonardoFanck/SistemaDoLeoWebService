namespace SistemaDoLeoWebService
{
    partial class FormCadastroFormaPGTO
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
            BtnAvancar = new Button();
            BtnVoltar = new Button();
            BtnAlterar = new Button();
            BtnNovo = new Button();
            BtnCancelar = new Button();
            BtnSalvar = new Button();
            BtnID = new Button();
            TxtNome = new TextBox();
            TxtID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ChkBoxInativo = new CheckBox();
            SuspendLayout();
            // 
            // BtnAvancar
            // 
            BtnAvancar.Location = new Point(82, 101);
            BtnAvancar.Name = "BtnAvancar";
            BtnAvancar.Size = new Size(30, 25);
            BtnAvancar.TabIndex = 46;
            BtnAvancar.TabStop = false;
            BtnAvancar.Text = ">";
            BtnAvancar.UseVisualStyleBackColor = true;
            BtnAvancar.Click += BtnAvancar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(46, 101);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(30, 25);
            BtnVoltar.TabIndex = 45;
            BtnVoltar.TabStop = false;
            BtnVoltar.Text = "<";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(239, 96);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(97, 35);
            BtnAlterar.TabIndex = 44;
            BtnAlterar.TabStop = false;
            BtnAlterar.Text = "Alterar";
            BtnAlterar.UseVisualStyleBackColor = true;
            BtnAlterar.Click += BtnAlterar_Click;
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(136, 96);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(97, 35);
            BtnNovo.TabIndex = 43;
            BtnNovo.TabStop = false;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            BtnNovo.Click += BtnNovo_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(445, 96);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(97, 35);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnSalvar
            // 
            BtnSalvar.Location = new Point(342, 96);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(97, 35);
            BtnSalvar.TabIndex = 3;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = true;
            BtnSalvar.Click += BtnSalvar_Click;
            // 
            // BtnID
            // 
            BtnID.Location = new Point(192, 24);
            BtnID.Name = "BtnID";
            BtnID.Size = new Size(41, 23);
            BtnID.TabIndex = 1;
            BtnID.TabStop = false;
            BtnID.Text = "<-";
            BtnID.UseVisualStyleBackColor = true;
            BtnID.Click += BtnID_Click;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(67, 54);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(475, 23);
            TxtNome.TabIndex = 2;
            TxtNome.KeyPress += TxtNome_KeyPress;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(67, 24);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(100, 23);
            TxtID.TabIndex = 0;
            TxtID.KeyDown += TxtID_KeyDown;
            TxtID.KeyPress += TxtID_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 57);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 48;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 47;
            label1.Text = "ID";
            // 
            // ChkBoxInativo
            // 
            ChkBoxInativo.AutoSize = true;
            ChkBoxInativo.Location = new Point(274, 28);
            ChkBoxInativo.Name = "ChkBoxInativo";
            ChkBoxInativo.Size = new Size(62, 19);
            ChkBoxInativo.TabIndex = 52;
            ChkBoxInativo.TabStop = false;
            ChkBoxInativo.Text = "Inativo";
            ChkBoxInativo.UseVisualStyleBackColor = true;
            // 
            // FormCadastroFormaPGTO
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 155);
            Controls.Add(ChkBoxInativo);
            Controls.Add(BtnID);
            Controls.Add(TxtNome);
            Controls.Add(TxtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAvancar);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnNovo);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnSalvar);
            KeyPreview = true;
            Name = "FormCadastroFormaPGTO";
            Text = "FormCadastroFormaPGTO";
            Load += FormCadastroFormaPGTO_Load;
            KeyDown += FormCadastroFormaPGTO_KeyDown;
            KeyPress += FormCadastroFormaPGTO_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAvancar;
        private Button BtnVoltar;
        private Button BtnAlterar;
        private Button BtnNovo;
        private Button BtnCancelar;
        private Button BtnSalvar;
        private Button BtnID;
        private TextBox TxtNome;
        private TextBox TxtID;
        private Label label2;
        private Label label1;
        private CheckBox ChkBoxInativo;
    }
}