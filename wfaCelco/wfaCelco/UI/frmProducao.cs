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
using wfaCelco.DTO;

namespace wfaCelco.UI
{
    public partial class frmProducao : Form
    {
        ProducaoBLL bll = new ProducaoBLL();
        ProducaoDTO dto = new ProducaoDTO();
        RecursosBLL BLL = new RecursosBLL();
        private Bitmap bmp;

        void ContaRegistros()
        {
            int count = dgProdOP.Rows.Count;
            label3.Text = "";
            label3.Text = "Encontrado(s) " + count + " registro(s).";
        }

        public frmProducao()
        {
            InitializeComponent();
            bll.AtualizaGrid(dgProdOP);
            ContaRegistros();
            cbbTipoFiltro.SelectedIndex = 0;
        }

        private void btnNovaOP_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(BLL.Informacao("COUNT(I.PRODUTO_ID)", "ITEM_FORMULA I", " INNER JOIN " +
                                               "dbo.G07_PRODUTOS P ON I.PRODUTO_ID = P.PRODUTO_ID " +
                                               "WHERE P.PRODUTO_TIPO LIKE 'PRODUTO ACABADO'")) > 0)
            {
                Form cadOP = new frmProducaoNovaOP();
                cadOP.ShowDialog();
                bll.AtualizaGrid(dgProdOP);
                ContaRegistros();
            }
            else MessageBox.Show("Não há produtos para cadastro.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmProducao_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarOP_Click(object sender, EventArgs e)
        {
            if (dgProdOP.RowCount > 0)
            {
                if (dgProdOP.CurrentRow.Cells[6].Value.ToString() != "CANCELADO")
                {
                    if (MessageBox.Show("Deseja Cancelar esta Ordem de Produção (OP)? ", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string status = "CANCELADO";
                        dto.Producao_id = int.Parse(dgProdOP.CurrentRow.Cells[0].Value.ToString());
                        dto.Producao_status = status;
                        bll.AlterarCampoStatus(dto);
                        MessageBox.Show("OP Cancelada com sucesso!!");
                        bll.AtualizaGrid(dgProdOP);
                    }
                    else
                        MessageBox.Show("OP já Cancelado...", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Não existem dados cadastrados...", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEncerrarOP_Click(object sender, EventArgs e)
        {
            if (dgProdOP.RowCount > 0)
            {
                if (dgProdOP.CurrentRow.Cells[6].Value.ToString() != "ENCERRADO")
                {
                    if (MessageBox.Show("Deseja Encerrar esta Ordem de Produção (OP)? ", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        string status = "ENCERRADO";
                        dto.Producao_id = int.Parse(dgProdOP.CurrentRow.Cells[0].Value.ToString());
                        dto.Producao_status = status;
                        bll.AlterarCampoStatus(dto);
                        MessageBox.Show("OP Encerrada com sucesso!!");
                        bll.AtualizaGrid(dgProdOP);
                    }
                    else
                        MessageBox.Show("OP já Encerrado...", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Não existem dados cadastrados...", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnAlterarOP_Click(object sender, EventArgs e)
        {
            if (dgProdOP.Rows.Count > 0)          
            {
                frmProducaoAltera altProd = new frmProducaoAltera(Convert.ToString(dgProdOP.CurrentRow.Cells[0].Value));
                altProd.ShowDialog();
                bll.AtualizaGrid(dgProdOP);
                ContaRegistros();
            }
            else MessageBox.Show("Não existem dados cadastrados...", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgProdOP_Click(object sender, EventArgs e)
        {
            if (dgProdOP.CurrentRow.Cells[4].Value.ToString() == "ENCERRADO")
            {
                btnEncerrarOP.Enabled = false;
            }
            else
                if (dgProdOP.CurrentRow.Cells[4].Value.ToString() == "CANCELADO")
                {
                    btnCancelarOP.Enabled = false;
                }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbbTipoFiltro.SelectedIndex = 0;
            rdbAberto.Visible = true;
            rdbAberto.Checked = true;
            rdbCancelado.Visible = true;
            rdbEncerrado.Visible = true;
            txtValorPesq.Visible = false;
            bll.AtualizaGrid(dgProdOP);
            ContaRegistros();
        }

        private void cbbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTipoFiltro.SelectedIndex == 0)
            {
                rdbAberto.Visible = true;
                rdbCancelado.Visible = true;
                rdbEncerrado.Visible = true;
                txtValorPesq.Visible = false;
            }
            if (cbbTipoFiltro.SelectedIndex == 1)
            {
                rdbAberto.Visible = false;
                rdbCancelado.Visible = false;
                rdbEncerrado.Visible = false;
                txtValorPesq.Visible = true;
                txtValorPesq.Focus();
            }
        }

        private void rdbAberto_CheckedChanged(object sender, EventArgs e)
        {
            string status = "";
            if (rdbAberto.Checked)
            {
                status = "ABERTO";
                bll.ConsultaPorStatus(dgProdOP, status);
                ContaRegistros();
            }
        }

        private void rdbCancelado_CheckedChanged(object sender, EventArgs e)
        {
            string status = "";
            if (rdbCancelado.Checked)
            {
                status = "CANCELADO";
                bll.ConsultaPorStatus(dgProdOP, status);
                ContaRegistros();
            }
        }

        private void rdbEncerrado_CheckedChanged(object sender, EventArgs e)
        {
            string status = "";
            if (rdbEncerrado.Checked)
            {
                status = "ENCERRADO";
                bll.ConsultaPorStatus(dgProdOP, status);
                ContaRegistros();
            }
        }

        private void txtValorPesq_TextChanged(object sender, EventArgs e)
        {
            bll.ConsultaPorProduto(dgProdOP, txtValorPesq.Text);
            ContaRegistros();
        }

        private void txtValorPesq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                bll.ConsultaPorProduto(dgProdOP, txtValorPesq.Text);
            }
        }

        private void printDocumentProd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btnEmitirOP_Click(object sender, EventArgs e)
        {
            if (dgProdOP.RowCount > 0)
            {
                int height = dgProdOP.Height;
                dgProdOP.Height = dgProdOP.RowCount * dgProdOP.RowTemplate.Height * 2;
                bmp = new Bitmap(dgProdOP.Width, dgProdOP.Height);
                dgProdOP.DrawToBitmap(bmp, new Rectangle(0, 0, dgProdOP.Width, dgProdOP.Height));
                dgProdOP.Height = height;
                printPreviewDialogProd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Desculpa não tem nenhum registro para imprimir... ", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
