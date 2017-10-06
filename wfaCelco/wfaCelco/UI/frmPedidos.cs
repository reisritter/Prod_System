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
using wfaCelco.UI;
using wfaCelco.DTO;

namespace wfaCelco.UI
{
    public partial class frmPedidos : Form
    {
        PedidosBLL BLL = new PedidosBLL();
        PedidosDTO dto = new PedidosDTO();
        private Form form = new Form();
        private Bitmap bmp;

        public frmPedidos()
        {
            InitializeComponent();

            dgvPedidos.ReadOnly = true;
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            BLL.AtualizaGridPedidos(dgvPedidos, "");
            try
            {
                BLL.AtualizaGridItens(dgvItens, Convert.ToString(dgvPedidos.CurrentRow.Cells[0].Value));
            }
            catch { }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                BLL.AtualizaGridItens(dgvItens, dgvPedidos.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }*/
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            if (condicao() != 1)
            {
                Form frm = new frmPedidosNovo();
                frm.ShowDialog();
                BLL.AtualizaGridPedidos(dgvPedidos, "");
            }
        }

        private int condicao()
        {
            if (BLL.Condicao1() == BLL.Condicao2())
            {
                MessageBox.Show("Não há produtos para cadastro!");
                return 1;
            }
            return 0;
        }

        private void btnAlterarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                frmPedidosAlterar frm = new frmPedidosAlterar(dgvPedidos.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
                BLL.AtualizaGridPedidos(dgvPedidos, "");
                BLL.AtualizaGridItens(dgvItens, dgvPedidos.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Nenhum pedido selecionado.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            BLL.AtualizarProcesso(dto, dgvPedidos.CurrentRow.Cells[0].Value.ToString());
            BLL.AtualizaGridPedidos(dgvPedidos, "");
        }

        private void btnRelatorioPedido_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.RowCount > 0)
            {
                int height = dgvPedidos.Height;
                dgvPedidos.Height = dgvPedidos.RowCount * dgvPedidos.RowTemplate.Height * 2;
                bmp = new Bitmap(dgvPedidos.Width, dgvPedidos.Height);
                dgvPedidos.DrawToBitmap(bmp, new Rectangle(0, 0, dgvPedidos.Width, dgvPedidos.Height));
                dgvPedidos.Height = height;
                printPreviewDialogPed.ShowDialog();
            }
            else
            {
                MessageBox.Show("Desculpa não tem nenhum registro para imprimir... ", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocumentPed_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BLL.AtualizaGridItens(dgvItens, dgvPedidos.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
        }
    }
    
}
