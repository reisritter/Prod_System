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
    public partial class frmRecursos : Form
    {
        RecursosBLL bll = new RecursosBLL();
        RecursosDTO dto = new RecursosDTO();
        private Bitmap bmp;

        void ContaRegistros()
        {
            int count = dgvRecursos.Rows.Count;
            label1.Text = "";
            label1.Text = "Encontrado(s) " + count + " registro(s).";
        }

        public frmRecursos()
        {
            InitializeComponent();
            bll.ListaRecursos(dgvRecursos);
            ContaRegistros();
            cbbTipoFiltro.SelectedIndex = 0;
        }

        private void btnAddRecurso_Click(object sender, EventArgs e)
        {
            Form novoRec = new frmRecursoNovo();
            novoRec.ShowDialog();
            bll.ListaRecursos(dgvRecursos);
            ContaRegistros();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvRecursos.SelectedRows.Count == 1)
            {
                string id = dgvRecursos.SelectedRows[0].Cells[0].Value.ToString();
                Form alterarRec = new frmRecursoNovo(id);
                alterarRec.ShowDialog();
                ContaRegistros();
                bll.ListaRecursos(dgvRecursos);
            }
            else
            {
                MessageBox.Show("Selecione um cliente!");
            }
            
        }

        private void btnDesativaRec_Click(object sender, EventArgs e)
        {
            if (dgvRecursos.RowCount > 0)
            {
                if(dgvRecursos.CurrentRow.Cells[4].Value.ToString() != "DESATIVADO")
                {
                    if(MessageBox.Show("Deseja desativar este recurso?", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dto.Recurso_id = Int32.Parse(dgvRecursos.CurrentRow.Cells[0].Value.ToString());
                        bll.DesativaRec(dto);
                        MessageBox.Show("Recurso desativado com sucesso!!", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bll.ListaRecursos(dgvRecursos);
                    }
                }
                else
                    MessageBox.Show("Recurso já Desativado...", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Não existem dados cadastrados...", "ATENÇÃO [M E N S A G E M]",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImprimirRec_Click(object sender, EventArgs e)
        {
            if(dgvRecursos.RowCount > 0)
            {
                int height = dgvRecursos.Height;
                dgvRecursos.Height = dgvRecursos.RowCount * dgvRecursos.RowTemplate.Height * 2;
                bmp = new Bitmap(dgvRecursos.Width, dgvRecursos.Height);
                dgvRecursos.DrawToBitmap(bmp, new Rectangle(0, 0, dgvRecursos.Width, dgvRecursos.Height));
                dgvRecursos.Height = height;
                printPreviewDialogRec.ShowDialog();
            }
            else
            {
                MessageBox.Show("Desculpa não tem nenhum registro para imprimir... ", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocumentRec_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0); 
        }

        private void cbbTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTipoFiltro.SelectedIndex == 0)
            {
                rbAtivos.Visible = true;
                rbDestivados.Visible = true;
                txtValorPesq.Visible = false;
            }
            if (cbbTipoFiltro.SelectedIndex == 1)
            {
                rbAtivos.Visible = false;
                rbDestivados.Visible = false;
                txtValorPesq.Visible = true;
                txtValorPesq.Focus();
            }
        }

        private void rbAtivos_CheckedChanged(object sender, EventArgs e)
        {
            string status = "";
            if (rbAtivos.Checked)
            {
                status = "ATIVADO";
                bll.ConsultaPorStatus(dgvRecursos, status);
                ContaRegistros();
            }
        }

        private void rbDestivados_CheckedChanged(object sender, EventArgs e)
        {
            string status = "";
            if (rbDestivados.Checked)
            {
                status = "DESATIVADO";
                bll.ConsultaPorStatus(dgvRecursos, status);
                ContaRegistros();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cbbTipoFiltro.SelectedIndex = 0;
            rbAtivos.Visible = true;
            rbDestivados.Visible = true;
            txtValorPesq.Visible = false;
            bll.ListaRecursos(dgvRecursos);
            ContaRegistros();
        }

        private void txtValorPesq_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtValorPesq_TextChanged(object sender, EventArgs e)
        {
            bll.ConsultaPorRec(dgvRecursos, txtValorPesq.Text);
        }
    }
}
