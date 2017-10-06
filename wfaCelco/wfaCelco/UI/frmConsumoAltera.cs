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
    public partial class frmConsumoAltera : Form
    {
        ConsumoBLL bll = new ConsumoBLL();        
        private int id;

        private decimal ValorTotal()
        {
            int total = 0;
            int i = 0;
            for (i = 0; i < dgvItemFormula.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(dgvItemFormula.Rows[i].Cells[2].Value);
            }
            return total;
        }

        public frmConsumoAltera()
        {
            InitializeComponent();
        }

        public frmConsumoAltera(string id)
        {
            this.id = Int32.Parse(id);
            MessageBox.Show(""+id);
            InitializeComponent();
            bll.ListaOP(dgvOp);
        }

        private void dgvOp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cod = Int32.Parse(dgvOp.CurrentRow.Cells[0].Value.ToString());
            bll.ListaItens(dgvItemFormula, cod);
            if (dgvItemFormula.Rows.Count > 0)
                txtQtdeTotal.Text = ValorTotal().ToString();
        }

        private void dgvItemFormula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int val = Int32.Parse(dgvItemFormula.CurrentRow.Cells[0].Value.ToString());
            if (dgvItemFormula.Rows.Count > 0)
                bll.ListaValorEstoque(dgvValorEstoque, val);
        }

        private void btnSalvaAlter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Confirmar esta alteração?", "ATENÇÃO [M E N S A G E M]", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvValorEstoque.RowCount > 0 && dgvOp.RowCount > 0 && dgvItemFormula.RowCount > 0)
                {
                    int i = 0;
                    for (i = 0; i < dgvItemFormula.Rows.Count; i++)
                    {
                        //altera valores no estoque
                        int campo_0 = Int32.Parse(dgvItemFormula.Rows[i].Cells[0].Value.ToString()),
                            campo_2 = Int32.Parse(dgvItemFormula.Rows[i].Cells[2].Value.ToString());
                        bll.AlteraValorEstoque(campo_0, campo_2);
                        //insere os valores em consumo
                        ConsumoDTO dto = new ConsumoDTO();
                        dto.Consumo_qtde = Int32.Parse(txtQtdeTotal.Text);
                        dto.Local_id = Int32.Parse(dgvValorEstoque.CurrentRow.Cells[1].Value.ToString());
                        dto.Produto_id = Int32.Parse(dgvValorEstoque.CurrentRow.Cells[2].Value.ToString());
                        dto.Producao_id = Int32.Parse(dgvOp.CurrentRow.Cells[0].Value.ToString());
                        bll.AlteraConsumo(dto, this.id);
                    }

                    MessageBox.Show("Alteração Realizada com Sucesso!!!", "ATENÇÃO [M E N S A G E M]");
                    this.Close();
                }
                else
                    MessageBox.Show("Não Existe Dados para Mostrar...", "INFORMAÇÃO [M E N S A G E M]", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
