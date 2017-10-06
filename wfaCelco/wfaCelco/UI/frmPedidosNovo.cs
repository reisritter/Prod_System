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
    public partial class frmPedidosNovo : Form
    {
        private Form FORM = new Form();
        FormulasBLL BLLF = new FormulasBLL();
        ItemFormBLL BLLI = new ItemFormBLL();
        FormulasDTO dtof = new FormulasDTO();
        ProdutosDTO dtop = new ProdutosDTO();
        ItemProdDTO dtoi = new ItemProdDTO();

        public frmPedidosNovo()
        {
            InitializeComponent();

            dtDataEntrega.Value = DateTime.Now.Date;
            dtDataEntrega.MinDate = DateTime.Today;
            try
            {
                nudCodPed.Value = 1 + Convert.ToInt32(BLLI.Informacao("MAX(PEDIDO_ID)", "PEDIDOS", ""));
            }
            catch
            {
                nudCodPed.Value = 1;
            }

            dgvComposicao.ColumnCount = 3;
            dgvComposicao.Columns[0].Name = "Cod. Produto";
            dgvComposicao.Columns[1].Name = "Nome Produto";
            dgvComposicao.Columns[2].Name = "Quantidade Produto";
            dgvComposicao.Columns[0].ReadOnly = true;
            dgvComposicao.Columns[1].ReadOnly = true;
            dgvComposicao.Columns[2].ReadOnly = false;

            cbCliNome.DropDownStyle = ComboBoxStyle.DropDownList;
            BLLF.CliAssoc(cbCliNome);
            cbCliNome.ValueMember = "CLI_ID";
            cbCliNome.DisplayMember = "CLI_NOME_RESPONSAVEL";
            cbCliNome.Update();
            txtCliCod.Text = "" + Convert.ToInt32(cbCliNome.SelectedValue);

            cbProdNome.DropDownStyle = ComboBoxStyle.DropDownList;
            BLLF.ProdAssoc(cbProdNome);
            cbProdNome.ValueMember = "PRODUTO_ID";
            cbProdNome.DisplayMember = "PRODUTO_NOME";
            cbProdNome.Update();
        }

        private void salva()
        {
            dtof.Pedido_data_entrega = dtDataEntrega.Value.ToString("yyyy-MM-dd");
            dtof.Cli_id = int.Parse(cbCliNome.SelectedValue.ToString());
            BLLF.SalvaFormula2(dtof);

            int codigo = Convert.ToInt32(BLLI.Informacao("MAX(PEDIDO_ID)", "PEDIDOS", ""));

            for (int linha = 0; linha < dgvComposicao.Rows.Count; linha++)
            {
                dtoi.codigo_pedido = codigo;
                dtoi.codigo_prod = Convert.ToInt32(this.dgvComposicao.Rows[linha].Cells[0].Value.ToString());
                dtoi.quantidade = Convert.ToInt32(this.dgvComposicao.Rows[linha].Cells[2].Value.ToString());
                BLLI.SalvaComposicao(dtoi);
            }
            MessageBox.Show("Pedido cadastrado com sucesso!");
            this.Close();
        }

        public void RemoveDuplicate(DataGridView dgv)
        {
            for (int currentRow = 0; currentRow < dgv.Rows.Count - 1; currentRow++)
            {
                DataGridViewRow rowToCompare = dgv.Rows[currentRow];
                for (int PLN = currentRow + 1; PLN < dgv.Rows.Count; PLN++)
                {
                    DataGridViewRow row = dgv.Rows[PLN];
                    bool duplicada = true;
                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells["Nome Produto"].Value.Equals(row.Cells["Nome Produto"].Value))
                        {
                            duplicada = false;
                            break;
                        }
                    }
                    if (duplicada)
                    {
                        dgv.Rows.Remove(row);
                        MessageBox.Show("Produto ja inserido. Para alterar a quantidade de duplo clique no campo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PLN--;
                    }
                }
            }
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            DialogResult salvarform = MessageBox.Show("Deseja salvar o pedido?", "Salvar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salvarform.ToString().ToUpper() == "YES")
            {
                if (dgvComposicao.RowCount == 0) MessageBox.Show("Não há itens no pedido!");
                else
                {
                    salva();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (nudQtd.Value == 0)
            {
                MessageBox.Show("Quantidade zero!");
            }
            else
            {
                string ID = BLLI.Informacao("PRODUTO_ID", "PRODUTOS", " WHERE PRODUTO_ID = " + Convert.ToInt32(cbProdNome.SelectedValue));
                string DC = BLLI.Informacao("PRODUTO_NOME", "PRODUTOS", " WHERE PRODUTO_ID = " + Convert.ToInt32(cbProdNome.SelectedValue));
                dgvComposicao.Rows.Add(ID, DC, nudQtd.Value);
                RemoveDuplicate(dgvComposicao);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvComposicao.RowCount == 0)
            {
                MessageBox.Show("Não há itens para excluir!");
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Excluir o item selecionado?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    dgvComposicao.Rows.RemoveAt(dgvComposicao.CurrentRow.Index);
                    MessageBox.Show("Exclusão realizada com sucesso!", "", MessageBoxButtons.OK);
                }
            }
        }

        private void cbCliNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCliCod.Text = "" + cbCliNome.SelectedValue;
            cbCliNome.Update();
        }

        private void dgvComposicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void dgvComposicao_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress +=
            new KeyPressEventHandler(dgvComposicao_KeyPress);
        }
    }
}
