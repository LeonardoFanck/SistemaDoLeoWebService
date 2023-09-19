using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDoLeoWebService
{
    public partial class FormPesquisa : Form
    {
        public FormPesquisa()
        {
            InitializeComponent();
        }

        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            GridViewPesquisa.Columns.Add("treste", "test");

            if (GridViewPesquisa.Rows.Count > 0)
            {
                for (int i = 0; i < GridViewPesquisa.Columns.Count; i++)
                {
                    GridViewPesquisa.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }
    }
}
