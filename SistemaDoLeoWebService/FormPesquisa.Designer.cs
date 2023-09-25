namespace SistemaDoLeoWebService
{
    partial class FormPesquisa
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
            BtnBuscaTodos = new Button();
            TxtDados = new TextBox();
            ComboBoxTipo = new ComboBox();
            GridViewPesquisa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GridViewPesquisa).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscaTodos
            // 
            BtnBuscaTodos.Location = new Point(689, 20);
            BtnBuscaTodos.Name = "BtnBuscaTodos";
            BtnBuscaTodos.Size = new Size(85, 27);
            BtnBuscaTodos.TabIndex = 0;
            BtnBuscaTodos.TabStop = false;
            BtnBuscaTodos.Text = "Buscar Todos";
            BtnBuscaTodos.UseVisualStyleBackColor = true;
            // 
            // TxtDados
            // 
            TxtDados.Location = new Point(146, 24);
            TxtDados.Name = "TxtDados";
            TxtDados.Size = new Size(331, 23);
            TxtDados.TabIndex = 1;
            TxtDados.TextChanged += TxtDados_TextChanged;
            TxtDados.KeyPress += TxtDados_KeyPress;
            // 
            // ComboBoxTipo
            // 
            ComboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTipo.FormattingEnabled = true;
            ComboBoxTipo.Location = new Point(23, 24);
            ComboBoxTipo.Name = "ComboBoxTipo";
            ComboBoxTipo.Size = new Size(117, 23);
            ComboBoxTipo.TabIndex = 2;
            ComboBoxTipo.TabStop = false;
            ComboBoxTipo.SelectedIndexChanged += ComboBoxTipo_SelectedIndexChanged;
            // 
            // GridViewPesquisa
            // 
            GridViewPesquisa.AllowUserToAddRows = false;
            GridViewPesquisa.BackgroundColor = SystemColors.ControlLight;
            GridViewPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewPesquisa.Location = new Point(12, 72);
            GridViewPesquisa.MultiSelect = false;
            GridViewPesquisa.Name = "GridViewPesquisa";
            GridViewPesquisa.ReadOnly = true;
            GridViewPesquisa.RowTemplate.Height = 25;
            GridViewPesquisa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewPesquisa.Size = new Size(737, 347);
            GridViewPesquisa.TabIndex = 3;
            GridViewPesquisa.TabStop = false;
            GridViewPesquisa.MouseDoubleClick += GridViewPesquisa_MouseDoubleClick;
            // 
            // FormPesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(799, 450);
            Controls.Add(GridViewPesquisa);
            Controls.Add(ComboBoxTipo);
            Controls.Add(TxtDados);
            Controls.Add(BtnBuscaTodos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormPesquisa";
            Text = "FormPesquisa";
            Load += FormPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)GridViewPesquisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscaTodos;
        private TextBox TxtDados;
        private ComboBox ComboBoxTipo;
        private DataGridView GridViewPesquisa;
    }
}