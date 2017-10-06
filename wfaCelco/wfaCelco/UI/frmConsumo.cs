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
    public partial class frmConsumo : Form
    {
        ConsumoBLL bll = new ConsumoBLL();
        private Bitmap bmp,bmp2;

        public frmConsumo()
        {
            InitializeComponent();
            bll.ListaConsumo(dgvConsumo);
            cbbTipoFiltro.SelectedIndex = 0;
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            frmConsumoVincula con = new frmConsumoVincula();
            con.ShowDialog();
            bll.ListaConsumo(dgvConsumo);
        }

        private void btnImprimirRec_Click(object sender, EventArgs e)
        {
            if (dgvConsumo.RowCount > 0)
            {
                int height = gbConsumo.Height;
                int width = gbConsumo.Width;
                bmp = new Bitmap(width, height);
                gbConsumo.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                printPreviewDialogCon.ShowDialog();
            }
            else
            {
                MessageBox.Show("Desculpa não tem nenhum registro para imprimir... ", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocumentCon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void dgvConsumo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvConsumo.RowCount > 0)
            {
                int cod = Int32.Parse(dgvConsumo.CurrentRow.Cells[2].Value.ToString());
                lblOp.Text = cod.ToString();
                lblProduto.Text = bll.NomeProdOP(cod);
                lblDataReg.Text = bll.DataRegProdOP(cod);
                lblDataIn.Text = bll.DataIniProdOP(cod);
                lblDataFim.Text = bll.DataFimProdOP(cod);
                lblQtdeOP.Text = bll.QtdeProdOP(cod);
                bll.ListaItens(dgvDadosItens, cod);
            }
            else
            {
                MessageBox.Show("Desculpa não tem nenhum registro para visualizar Detalhes... ", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void btnImpDet_Click(object sender, EventArgs e)
        {
            int height = groupBox2.Height;
            int width = groupBox2.Width;
            bmp2 = new Bitmap(width, height);
            groupBox2.DrawToBitmap(bmp2, new Rectangle(0, 0, width, height));
            printPreviewDialogDet.ShowDialog();
        }

        private void txtCodOP_ValueChanged(object sender, EventArgs e)
        {
            bll.ListarPorCodigo(dgvConsumo, Int32.Parse(txtCodOP.Value.ToString()));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            bll.ListaConsumo(dgvConsumo);
        }

        private void btnAlterarConsumo_Click(object sender, EventArgs e)
        {
            if (dgvConsumo.SelectedRows.Count == 1)
            {
                string id = dgvConsumo.CurrentRow.Cells[2].Value.ToString();
                Form alterarCon = new frmConsumoAltera(id);
                alterarCon.ShowDialog();
                bll.ListaConsumo(dgvConsumo);
            }
        }

        private void printDocumentDet_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp2, 0, 0);
        }
    }
}
