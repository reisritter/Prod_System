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
    public partial class frmProdutos : Form
    {
        static string MSG1 = "Selecione um produto!";
        static string MSG2 = "Selecione um produto com estoque!";

        ProdutosBLL prodBll = new ProdutosBLL();

        private Bitmap bmp;

        public frmProdutos()
        {
            InitializeComponent();
            txtBuscaProd.Focus(); 
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            Form objProdutos = new frmNovoProduto();
            objProdutos.ShowDialog();
            prodBll.consultarProd(dgvProd); 
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            prodBll.consultarProd(dgvProd);
            txtBuscaProd.Focus(); 
        }

        private void btnAtualProd_Click(object sender, EventArgs e)
        {
            if (dgvProd.SelectedRows.Count == 1)
            {
                string id = dgvProd.SelectedRows[0].Cells[0].Value.ToString();
                Form objProduto = new frmNovoProduto(id);
                objProduto.ShowDialog();
                prodBll.consultarProd(dgvProd);
            }
            else
            {
                MessageBox.Show("Selecione um produto!");
            }
        }

        private void btnBuscaProd_Click(object sender, EventArgs e)
        {
            prodBll.buscarProd(dgvProd, txtBuscaProd.Text); 
        }

        private void btnImprime_Click(object sender, EventArgs e)
        {
            int height = dgvProd.Height;
            dgvProd.Height = dgvProd.RowCount * dgvProd.RowTemplate.Height * 2;
            bmp = new Bitmap(dgvProd.Width, dgvProd.Height);
            dgvProd.DrawToBitmap(bmp, new Rectangle(0, 0, dgvProd.Width, dgvProd.Height));
            dgvProd.Height = height;
            printPreviewDialogProd.ShowDialog();
        }

        private void printDocumentProduto_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            if (dgvProd.SelectedRows.Count == 1)
            {
                if (dgvProd.CurrentRow.Cells[4].Value.ToString() != "")
                {
                    frmEstoqueProd frm = new frmEstoqueProd(this);
                    frm.ShowDialog();
                }
                else MessageBox.Show(MSG2);

            }
            else MessageBox.Show(MSG1);
        }
    }
}
