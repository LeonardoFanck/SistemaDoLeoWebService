namespace SistemaDoLeoWebService
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtID = new TextBox();
            TxtSenha = new TextBox();
            BtnAcessar = new Button();
            BtnFinalizar = new Button();
            LblNomeOperador = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 48);
            label1.Name = "label1";
            label1.Size = new Size(477, 86);
            label1.TabIndex = 0;
            label1.Text = "Sistema Do Leo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(119, 170);
            label2.Name = "label2";
            label2.Size = new Size(133, 46);
            label2.TabIndex = 1;
            label2.Text = "Usuário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(119, 226);
            label3.Name = "label3";
            label3.Size = new Size(111, 46);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // TxtID
            // 
            TxtID.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtID.Location = new Point(258, 173);
            TxtID.MaxLength = 4;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(92, 43);
            TxtID.TabIndex = 3;
            TxtID.TextChanged += TxtID_TextChanged;
            TxtID.Enter += TxtID_Enter;
            TxtID.KeyPress += TxtID_KeyPress;
            TxtID.Leave += TxtID_Leave;
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSenha.Location = new Point(258, 229);
            TxtSenha.MaxLength = 4;
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '*';
            TxtSenha.Size = new Size(92, 43);
            TxtSenha.TabIndex = 4;
            TxtSenha.TextChanged += TxtSenha_TextChanged;
            TxtSenha.Enter += TxtSenha_Enter;
            TxtSenha.KeyPress += TxtSenha_KeyPress;
            // 
            // BtnAcessar
            // 
            BtnAcessar.Location = new Point(408, 170);
            BtnAcessar.Name = "BtnAcessar";
            BtnAcessar.Size = new Size(131, 51);
            BtnAcessar.TabIndex = 5;
            BtnAcessar.Text = "Acessar";
            BtnAcessar.UseVisualStyleBackColor = true;
            BtnAcessar.Click += BtnAcessar_Click;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Location = new Point(408, 232);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(131, 51);
            BtnFinalizar.TabIndex = 6;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // LblNomeOperador
            // 
            LblNomeOperador.AutoSize = true;
            LblNomeOperador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblNomeOperador.Location = new Point(239, 324);
            LblNomeOperador.Name = "LblNomeOperador";
            LblNomeOperador.Size = new Size(0, 32);
            LblNomeOperador.TabIndex = 7;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 410);
            ControlBox = false;
            Controls.Add(LblNomeOperador);
            Controls.Add(BtnFinalizar);
            Controls.Add(BtnAcessar);
            Controls.Add(TxtSenha);
            Controls.Add(TxtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema do Leo - Login";
            Load += Form1_Load;
            KeyDown += FormLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtID;
        private TextBox TxtSenha;
        private Button BtnAcessar;
        private Button BtnFinalizar;
        private Label LblNomeOperador;
    }
}