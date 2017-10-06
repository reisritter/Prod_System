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
    public partial class frmFormulas : Form
    {
        FormulasBLL BLL = new FormulasBLL();
        private Form form = new Form();
        private Bitmap bmp;

        public frmFormulas()
        {
            InitializeComponent();

            dgvRelaForm.ReadOnly = true;
            cbTipoFiltro.SelectedIndex = 0;
        }

        private void frmFormulas_Load(object sender, EventArgs e)
        {
            BLL.AtualizaGrid(dgvRelaForm, "");
            if (dgvRelaComp.Rows.Count > 0 )
                BLL.AtualizaGridComp(dgvRelaComp, dgvRelaForm.CurrentRow.Cells[0].Value.ToString());
        }

        private void dgvRelaForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BLL.AtualizaGridComp(dgvRelaComp, dgvRelaForm.CurrentRow.Cells[0].Value.ToString());
            }
            catch {}
        }

        /*=====================================
          ACIONAR NOVA CADASTRO DE NOVA FORMULA
          =====================================*/

        private void btnNovaFormula_Click(object sender, EventArgs e)
        {
            if(condicao() != 1)
            {
                frmPedidoNovo frm = new frmPedidoNovo();
                frm.ShowDialog();
                BLL.AtualizaGrid(dgvRelaForm, "");
            }
        }

        private int condicao()
        {
            if (BLL.PRcondicao() == BLL.SGcondicao())
            {
                MessageBox.Show("Não há produtos para cadastro!");
                return 1;
            }
            return 0;
        }

      /*====================
        PESQUISA DE FORMULAS
        ====================*/

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            switch(cbTipoFiltro.SelectedIndex)
            {
                default:
                    MessageBox.Show("Selecione um tipo para pesquisa.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 0:
                    BLL.AtualizaGrid(dgvRelaForm, "");
                    BLL.AtualizaGridComp(dgvRelaComp, dgvRelaForm.CurrentCell.Value.ToString());
                    break;
                case 1:
                    try
                    {
                        BLL.AtualizaGrid(dgvRelaForm, "WHERE FORMULA_ID = " + Convert.ToInt32(nudConteudo.Value));
                        BLL.AtualizaGridComp(dgvRelaComp, dgvRelaForm.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        if (dgvRelaComp.DataSource != null) dgvRelaComp.DataSource = null;
                        else dgvRelaComp.Rows.Clear();
                        MessageBox.Show("Fórmula não cadastrada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case 2:
                    try
                    {
                        BLL.AtualizaGrid(dgvRelaForm, "WHERE FORMULA_DESCRICAO = " + "'" + txtConteudo.Text + "'");
                        BLL.AtualizaGridComp(dgvRelaComp, dgvRelaForm.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        if (dgvRelaComp.DataSource != null) dgvRelaComp.DataSource = null;
                        else dgvRelaComp.Rows.Clear();
                        MessageBox.Show("Fórmula não cadastrada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }

        private void cbTipoFiltro_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(cbTipoFiltro.SelectedIndex)
            {
                case 0: nudConteudo.Enabled = false; txtConteudo.Enabled = false; break;
                case 1: nudConteudo.Enabled = true; nudConteudo.Visible = true; txtConteudo.Visible = false; break;
                case 2: txtConteudo.Enabled = true; nudConteudo.Visible = false; txtConteudo.Visible = true; break;
            }
        }

      /*=============================================
        ACIONAR NOVO PROCESSO DE ALTERACAO DE FORMULA
        =============================================*/

        private void btnAlterarFormula_Click(object sender, EventArgs e)
        {
            try
            {
                frmAlterarFormula frm = new frmAlterarFormula(dgvRelaForm.CurrentRow.Cells[0].Value.ToString());
                frm.ShowDialog();
                BLL.AtualizaGrid(dgvRelaForm, "");
            }
            catch
            {
                MessageBox.Show("Nenhuma fórmula selecionada.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


      /*===============
        EXCLUIR FORMULA
        ===============*/

        private void btnExcluirFormula_Click(object sender, EventArgs e)
        {
            if (dgvRelaComp.RowCount == 1)
            {
                if (Convert.ToInt32(BLL.TRcondicao(dgvRelaForm.CurrentRow.Cells[0].Value.ToString())) == 0)
                {
                    DialogResult confirm = MessageBox.Show("Deseja excluir a fórmula selecionada?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (confirm.ToString().ToUpper() == "YES")
                    {
                        BLL.delete(Convert.ToInt32(dgvRelaForm.CurrentRow.Cells[0].Value.ToString()));
                        BLL.AtualizaGrid(dgvRelaForm, "");
                        MessageBox.Show("Fórmula excluida com sucesso!");
                    }
                    if (dgvRelaForm.Rows.Count == 0)
                    {
                        if (dgvRelaComp.DataSource != null) dgvRelaComp.DataSource = null;
                        else dgvRelaComp.Rows.Clear();
                    }
                    else BLL.AtualizaGridComp(dgvRelaComp, dgvRelaForm.CurrentRow.Cells[0].Value.ToString());
                }
                else MessageBox.Show("Fórmula vinculada à uma Ordem de Produção.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Não há registro selecionado para alteração...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dgvRelaComp.RowCount > 0)
            {
                int height = dgvRelaForm.Height;
                dgvRelaForm.Height = dgvRelaForm.RowCount * dgvRelaForm.RowTemplate.Height * 2;
                bmp = new Bitmap(dgvRelaForm.Width, dgvRelaForm.Height);
                dgvRelaForm.DrawToBitmap(bmp, new Rectangle(0, 0, dgvRelaForm.Width, dgvRelaForm.Height));
                dgvRelaForm.Height = height;
                PPD.ShowDialog();
            }
            else MessageBox.Show("Não há registro selecionado para impressão...", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PD_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void nudConteudo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                BLL.AtualizaGrid(dgvRelaForm, "WHERE FORMULA_ID = " + Convert.ToInt32(nudConteudo.Value));
                BLL.AtualizaGridComp(dgvRelaComp, dgvRelaForm.CurrentCell.Value.ToString());
            }
            catch
            {
                if (dgvRelaComp.DataSource != null) dgvRelaComp.DataSource = null;
                else dgvRelaComp.Rows.Clear();
                MessageBox.Show("Fórmula não cadastrada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BLL.AtualizaGrid(dgvRelaForm, "WHERE FORMULA_DESCRICAO LIKE " + "'" + txtConteudo.Text + "%'");
                BLL.AtualizaGridComp(dgvRelaComp, dgvRelaForm.CurrentCell.Value.ToString());
            }
            catch
            {
                if (dgvRelaComp.DataSource != null) dgvRelaComp.DataSource = null;
                else dgvRelaComp.Rows.Clear();
                MessageBox.Show("Fórmula não cadastrada.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
