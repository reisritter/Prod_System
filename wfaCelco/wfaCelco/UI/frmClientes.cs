using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaCelco.BLL;


namespace wfaCelco.UI
{
    public partial class frmClientes : Form
    {
        ClienteBLL cliBll = new ClienteBLL();
        private Bitmap bmp;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnNovoCli_Click(object sender, EventArgs e)
        {
            Form objCliente = new frmCadastroCli();
            objCliente.ShowDialog();
            cliBll.consultarCli(dgvCliente);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cliBll.consultarCli(dgvCliente);
            txtBuscaCli.Focus();
        }

        private void btnBuscaCli_Click(object sender, EventArgs e)
        {
            cliBll.buscarCli(dgvCliente,txtBuscaCli.Text);
        }

        private void btnAtuaCli_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count == 1)
            {
                string id = dgvCliente.SelectedRows[0].Cells[0].Value.ToString();
                Form objCliente = new frmCadastroCli(id);
                objCliente.ShowDialog();
                cliBll.consultarCli(dgvCliente);
            }
            else
            {
                MessageBox.Show("Selecione um cliente!"); 
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int height = dgvCliente.Height;
            dgvCliente.Height = dgvCliente.RowCount * dgvCliente.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvCliente.Width, dgvCliente.Height);
            dgvCliente.DrawToBitmap(bmp, new Rectangle(0, 0, dgvCliente.Width, dgvCliente.Height));
            dgvCliente.Height = height;
            printPreviewDialogCli.ShowDialog(); 
        }

        private void printDocumentCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0); 
        }
    }
}
