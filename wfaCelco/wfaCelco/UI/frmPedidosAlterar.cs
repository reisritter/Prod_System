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
    public partial class frmPedidosAlterar : Form
    {
        AltFormBLL BLL = new AltFormBLL();
        ItemFormBLL BLLI = new ItemFormBLL();
        FormulasBLL BLLF = new FormulasBLL();
        FormulasDTO DTO = new FormulasDTO();
        ItemProdDTO DTOI = new ItemProdDTO();
        public frmPedidosAlterar()
        {
            InitializeComponent();
        }

        private void salva()
        {
            int codigo = Convert.ToInt32(nudCodPed.Value);
            DTO.Pedido_data_entrega = dtDataEntrega.Value.ToString("yyyy-MM-dd");
            BLL.update(DTO, codigo);
            BLL.delete(codigo);

            for (int linha = 0; linha < dgvComposicao.Rows.Count; linha++)
            {
                DTOI.codigo_pedido = codigo;
                DTOI.codigo_prod = Convert.ToInt32(this.dgvComposicao.Rows[linha].Cells[0].Value.ToString());
                DTOI.quantidade = Convert.ToInt32(this.dgvComposicao.Rows[linha].Cells[2].Value.ToString());
                BLLI.SalvaComposicao(DTOI);
            }
            MessageBox.Show("Pedido alterado com sucesso!");
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

        public frmPedidosAlterar(string codigo)
        {
            InitializeComponent();
            nudCodPed.Value = Convert.ToInt32(BLLF.Informacao("PEDIDO_ID", "PEDIDOS ", "WHERE PEDIDO_ID = " + codigo));
            txtCliNome.Text = BLLF.Informacao("CLI_ID", "PEDIDOS ", "WHERE PEDIDO_ID = " + codigo);
            dtDataEntrega.Text = BLLF.Informacao("PEDIDO_DATA_ENTREGA", "PEDIDOS ", "WHERE PEDIDO_ID = " + codigo);

            txtCliCod.Text = BLLF.Informacao("C.CLI_ID", "CLIENTES C ", " INNER JOIN " +
                                              "dbo.G07_PEDIDOS P ON C.CLI_ID = P.CLI_ID WHERE P.PEDIDO_ID = " + codigo);

            txtCliNome.Text = BLLF.Informacao("CLI_NOME_RESPONSAVEL", "CLIENTES C ", "INNER JOIN " +
                                              "dbo.G07_PEDIDOS P ON C.CLI_ID = P.CLI_ID WHERE P.PEDIDO_ID = " + codigo);

            cbProdNome.DropDownStyle = ComboBoxStyle.DropDownList;
            BLLF.ProdAssoc2(cbProdNome);
            cbProdNome.ValueMember = "PRODUTO_ID";
            cbProdNome.DisplayMember = "PRODUTO_NOME";
            cbProdNome.Update();

            dgvComposicao.ColumnCount = 3;
            dgvComposicao.Columns[0].Name = "Cod. Produto";
            dgvComposicao.Columns[1].Name = "Nome Produto";
            dgvComposicao.Columns[2].Name = "Quantidade Produto";
            dgvComposicao.Columns[0].ReadOnly = true;
            dgvComposicao.Columns[1].ReadOnly = false;
            dgvComposicao.Columns[2].ReadOnly = false;

            BLLF.AtualizaGrid2(dgvAux, codigo);

            for (int linha = 0; linha < dgvAux.Rows.Count; linha++)
            {
                string ID = dgvAux.Rows[linha].Cells[3].Value.ToString();
                string COD = dgvAux.Rows[linha].Cells[3].Value.ToString();
                string NOME = BLL.Informacao("PRODUTO_NOME", "PRODUTOS", " WHERE PRODUTO_ID = " + COD);
                string QTD = dgvAux.Rows[linha].Cells[1].Value.ToString();
                dgvComposicao.Rows.Add(ID, NOME, QTD);
            }
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            if (dgvComposicao.Rows.Count > 0)
            {
                DialogResult salvarform = MessageBox.Show("Deseja salvar um novo pedido?", "Salvar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (salvarform.ToString().ToUpper() == "YES")
                {
                    if (dgvComposicao.RowCount == 0) MessageBox.Show("Não há itens no pedido!");
                    else
                    {
                        salva();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pedido sem itens.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
