using Microsoft.ReportingServices.Diagnostics.Internal;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDoLeoWebService
{
    public partial class FormImpressoes : Form
    {
        public FormImpressoes(DataTable pedido, DataTable itens)
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportEmbeddedResource = @"SistemaDoLeoWebService.Relatorios.ImpressaoPedido.rdlc";

            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Pedido", pedido));
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Itens", itens));

            reportViewer1.RefreshReport();
        }
    }
}
