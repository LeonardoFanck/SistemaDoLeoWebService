namespace SistemaDoLeoWebService
{
    partial class FormValidacaoOperador
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
            LblNomeOperador = new Label();
            BtnFinalizar = new Button();
            BtnAcessar = new Button();
            TxtSenha = new TextBox();
            TxtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // LblNomeOperador
            // 
            LblNomeOperador.AutoSize = true;
            LblNomeOperador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LblNomeOperador.Location = new Point(245, 355);
            LblNomeOperador.Name = "LblNomeOperador";
            LblNomeOperador.Size = new Size(0, 32);
            LblNomeOperador.TabIndex = 15;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.Location = new Point(414, 263);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(131, 51);
            BtnFinalizar.TabIndex = 14;
            BtnFinalizar.Text = "Finalizar";
            BtnFinalizar.UseVisualStyleBackColor = true;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // BtnAcessar
            // 
            BtnAcessar.Location = new Point(414, 201);
            BtnAcessar.Name = "BtnAcessar";
            BtnAcessar.Size = new Size(131, 51);
            BtnAcessar.TabIndex = 13;
            BtnAcessar.Text = "Acessar";
            BtnAcessar.UseVisualStyleBackColor = true;
            BtnAcessar.Click += BtnAcessar_Click;
            // 
            // TxtSenha
            // 
            TxtSenha.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSenha.Location = new Point(264, 260);
            TxtSenha.MaxLength = 4;
            TxtSenha.Name = "TxtSenha";
            TxtSenha.PasswordChar = '*';
            TxtSenha.Size = new Size(92, 43);
            TxtSenha.TabIndex = 12;
            TxtSenha.Enter += TxtSenha_Enter;
            TxtSenha.KeyPress += TxtSenha_KeyPress;
            // 
            // TxtID
            // 
            TxtID.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            TxtID.Location = new Point(264, 204);
            TxtID.MaxLength = 4;
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(92, 43);
            TxtID.TabIndex = 11;
            TxtID.TextChanged += TxtID_TextChanged;
            TxtID.Enter += TxtID_Enter;
            TxtID.KeyPress += TxtID_KeyPress;
            TxtID.Leave += TxtID_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(125, 257);
            label3.Name = "label3";
            label3.Size = new Size(111, 46);
            label3.TabIndex = 10;
            label3.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 201);
            label2.Name = "label2";
            label2.Size = new Size(133, 46);
            label2.TabIndex = 9;
            label2.Text = "Usuário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 31);
            label1.Name = "label1";
            label1.Size = new Size(477, 86);
            label1.TabIndex = 8;
            label1.Text = "Sistema Do Leo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(170, 126);
            label4.Name = "label4";
            label4.Size = new Size(337, 47);
            label4.TabIndex = 16;
            label4.Text = "Liberação de Acesso";
            // 
            // FormValidacaoOperador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 417);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(LblNomeOperador);
            Controls.Add(BtnFinalizar);
            Controls.Add(BtnAcessar);
            Controls.Add(TxtSenha);
            Controls.Add(TxtID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormValidacaoOperador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ValidacaoOperador";
            KeyDown += ValidacaoOperador_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblNomeOperador;
        private Button BtnFinalizar;
        private Button BtnAcessar;
        private TextBox TxtSenha;
        private TextBox TxtID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}