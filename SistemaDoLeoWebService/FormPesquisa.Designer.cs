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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
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
            BtnBuscaTodos.Text = "Buscar Todos";
            BtnBuscaTodos.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 23);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 23);
            comboBox1.TabIndex = 2;
            // 
            // GridViewPesquisa
            // 
            GridViewPesquisa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewPesquisa.Location = new Point(12, 72);
            GridViewPesquisa.Name = "GridViewPesquisa";
            GridViewPesquisa.RowTemplate.Height = 25;
            GridViewPesquisa.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            GridViewPesquisa.Size = new Size(737, 347);
            GridViewPesquisa.TabIndex = 3;
            // 
            // FormPesquisa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridViewPesquisa);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(BtnBuscaTodos);
            Name = "FormPesquisa";
            Text = "FormPesquisa";
            Load += FormPesquisa_Load;
            ((System.ComponentModel.ISupportInitialize)GridViewPesquisa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscaTodos;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private DataGridView GridViewPesquisa;
    }
}