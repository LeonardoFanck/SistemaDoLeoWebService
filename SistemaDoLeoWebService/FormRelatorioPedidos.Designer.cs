namespace SistemaDoLeoWebService
{
    partial class FormRelatorioPedidos
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
            TxtDtInicio = new MaskedTextBox();
            TxtDtFinal = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            BtnBuscar = new Button();
            BtnSair = new Button();
            TxtFormaPGTONome = new TextBox();
            TxtClienteNome = new TextBox();
            BtnFormaPGTO = new Button();
            TxtFormaPGTO = new TextBox();
            label3 = new Label();
            BtnCliente = new Button();
            TxtCliente = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // TxtDtInicio
            // 
            TxtDtInicio.Location = new Point(99, 31);
            TxtDtInicio.Mask = "00/00/0000";
            TxtDtInicio.Name = "TxtDtInicio";
            TxtDtInicio.Size = new Size(74, 23);
            TxtDtInicio.TabIndex = 0;
            TxtDtInicio.ValidatingType = typeof(DateTime);
            TxtDtInicio.KeyPress += TxtDtInicio_KeyPress;
            TxtDtInicio.Leave += TxtDtInicio_Leave;
            // 
            // TxtDtFinal
            // 
            TxtDtFinal.Location = new Point(99, 67);
            TxtDtFinal.Mask = "00/00/0000";
            TxtDtFinal.Name = "TxtDtFinal";
            TxtDtFinal.Size = new Size(74, 23);
            TxtDtFinal.TabIndex = 1;
            TxtDtFinal.ValidatingType = typeof(DateTime);
            TxtDtFinal.KeyPress += TxtDtFinal_KeyPress;
            TxtDtFinal.Leave += TxtDtFinal_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 34);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 2;
            label1.Text = "Data Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 70);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 3;
            label2.Text = "Data Final";
            // 
            // BtnBuscar
            // 
            BtnBuscar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BtnBuscar.Location = new Point(159, 194);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(86, 35);
            BtnBuscar.TabIndex = 4;
            BtnBuscar.Text = "Buscar";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // BtnSair
            // 
            BtnSair.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSair.Location = new Point(358, 194);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(86, 35);
            BtnSair.TabIndex = 5;
            BtnSair.TabStop = false;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // TxtFormaPGTONome
            // 
            TxtFormaPGTONome.Enabled = false;
            TxtFormaPGTONome.Location = new Point(227, 134);
            TxtFormaPGTONome.Name = "TxtFormaPGTONome";
            TxtFormaPGTONome.Size = new Size(354, 23);
            TxtFormaPGTONome.TabIndex = 106;
            TxtFormaPGTONome.TabStop = false;
            // 
            // TxtClienteNome
            // 
            TxtClienteNome.Enabled = false;
            TxtClienteNome.Location = new Point(227, 100);
            TxtClienteNome.Name = "TxtClienteNome";
            TxtClienteNome.Size = new Size(354, 23);
            TxtClienteNome.TabIndex = 105;
            TxtClienteNome.TabStop = false;
            // 
            // BtnFormaPGTO
            // 
            BtnFormaPGTO.Location = new Point(180, 134);
            BtnFormaPGTO.Name = "BtnFormaPGTO";
            BtnFormaPGTO.Size = new Size(41, 23);
            BtnFormaPGTO.TabIndex = 104;
            BtnFormaPGTO.TabStop = false;
            BtnFormaPGTO.Text = "->";
            BtnFormaPGTO.UseVisualStyleBackColor = true;
            BtnFormaPGTO.Click += BtnFormaPGTO_Click;
            // 
            // TxtFormaPGTO
            // 
            TxtFormaPGTO.Location = new Point(100, 134);
            TxtFormaPGTO.Name = "TxtFormaPGTO";
            TxtFormaPGTO.Size = new Size(74, 23);
            TxtFormaPGTO.TabIndex = 3;
            TxtFormaPGTO.TextChanged += TxtFormaPGTO_TextChanged;
            TxtFormaPGTO.KeyDown += TxtFormaPGTO_KeyDown;
            TxtFormaPGTO.KeyPress += TxtFormaPGTO_KeyPress;
            TxtFormaPGTO.Leave += TxtFormaPGTO_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 137);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 103;
            label3.Text = "Forma PGTO";
            // 
            // BtnCliente
            // 
            BtnCliente.Location = new Point(180, 100);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(41, 23);
            BtnCliente.TabIndex = 102;
            BtnCliente.TabStop = false;
            BtnCliente.Text = "->";
            BtnCliente.UseVisualStyleBackColor = true;
            BtnCliente.Click += BtnCliente_Click;
            // 
            // TxtCliente
            // 
            TxtCliente.Location = new Point(100, 100);
            TxtCliente.Name = "TxtCliente";
            TxtCliente.Size = new Size(74, 23);
            TxtCliente.TabIndex = 2;
            TxtCliente.TextChanged += TxtCliente_TextChanged;
            TxtCliente.KeyDown += TxtCliente_KeyDown;
            TxtCliente.KeyPress += TxtCliente_KeyPress;
            TxtCliente.Leave += TxtCliente_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 103);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 101;
            label4.Text = "Cliente";
            // 
            // FormRelatorioPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 249);
            Controls.Add(TxtFormaPGTONome);
            Controls.Add(TxtClienteNome);
            Controls.Add(BtnFormaPGTO);
            Controls.Add(TxtFormaPGTO);
            Controls.Add(label3);
            Controls.Add(BtnCliente);
            Controls.Add(TxtCliente);
            Controls.Add(label4);
            Controls.Add(BtnSair);
            Controls.Add(BtnBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtDtFinal);
            Controls.Add(TxtDtInicio);
            Name = "FormRelatorioPedidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRelatorioPedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox TxtDtInicio;
        private MaskedTextBox TxtDtFinal;
        private Label label1;
        private Label label2;
        private Button BtnBuscar;
        private Button BtnSair;
        private TextBox TxtFormaPGTONome;
        private TextBox TxtClienteNome;
        private Button BtnFormaPGTO;
        private TextBox TxtFormaPGTO;
        private Label label3;
        private Button BtnCliente;
        private TextBox TxtCliente;
        private Label label4;
    }
}