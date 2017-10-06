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
using wfaCelco.DAL;

namespace wfaCelco.UI
{
    public partial class frmAlterarFormula : Form
    {
        AltFormBLL  BLL  = new AltFormBLL();
        ItemFormBLL BLLI = new ItemFormBLL();
        FormulasBLL BLLF = new FormulasBLL();
        FormulasDTO DTO  = new FormulasDTO();
        ItemFormDTO DTOI = new ItemFormDTO();

        public frmAlterarFormula(string codigo)
        {
            InitializeComponent();
            this.Text = "Alterar Fórmula";

            txtDescFormula.Text = BLL.Informacao("FORMULA_DESCRICAO", "FORMULAS", " WHERE FORMULA_ID = " + codigo);
            txtCodProd.Text = BLL.InformacaoInner("P.PRODUTO_ID", "PRODUTOS P", "ITEM_FORMULA I", "P.PRODUTO_ID = I.PRODUTO_ID ", "WHERE FORMULA_ID = " + codigo + " AND P.PRODUTO_TIPO LIKE 'PRODUTO ACABADO'");
            txtNomeProd.Text = BLL.InformacaoInner("P.PRODUTO_NOME", "PRODUTOS P", "ITEM_FORMULA I", "P.PRODUTO_ID = I.PRODUTO_ID ", "WHERE FORMULA_ID = " + codigo + " AND P.PRODUTO_TIPO LIKE 'PRODUTO ACABADO'");
            nudCodForm.Value = Convert.ToInt32(codigo);

            dgvComposicao.ColumnCount = 3;
            dgvComposicao.Columns[0].Name = "Codigo";
            dgvComposicao.Columns[1].Name = "Nome";
            dgvComposicao.Columns[2].Name = "Quantidade";
            dgvComposicao.Columns[0].ReadOnly = true;
            dgvComposicao.Columns[1].ReadOnly = true;
            dgvComposicao.Columns[2].ReadOnly = false;

            BLL.preencherGrid(dgvAux, codigo);

            for (int linha = 0; linha < dgvAux.Rows.Count; linha++)
            {
                string ID   = dgvAux.Rows[linha].Cells[0].Value.ToString();
                string NOME = dgvAux.Rows[linha].Cells[1].Value.ToString();
                string QTD  = dgvAux.Rows[linha].Cells[2].Value.ToString();
                dgvComposicao.Rows.Add(ID, NOME, QTD);
            }

            cbNome.DropDownStyle = ComboBoxStyle.DropDownList;
            BLLF.ProdInsumo(cbNome);
            cbNome.ValueMember = "PRODUTO_ID";
            cbNome.DisplayMember = "PRODUTO_NOME";
            cbNome.Update();
        }

      /*=============================
        INSERIR INSUMOS NA COMPOSICAO
        =============================*/

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (nudQtd.Value == 0)
            {
                MessageBox.Show("Quantidade zero!");
            }
            else
            {
                string ID = BLL.Informacao("PRODUTO_ID", "PRODUTOS", " WHERE PRODUTO_ID = " + Convert.ToInt32(cbNome.SelectedValue));
                string DC = BLL.Informacao("PRODUTO_NOME", "PRODUTOS", " WHERE PRODUTO_ID = " + Convert.ToInt32(cbNome.SelectedValue));
                dgvComposicao.Rows.Add(ID, DC, nudQtd.Value);
                RemoveDuplicate(dgvComposicao);
            }
        }

      /*=======================================
        REMOVER DUPLICIDADES DURANTE A INSERÇÃO
        =======================================*/

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
                        if (!rowToCompare.Cells["Nome"].Value.Equals(row.Cells["Nome"].Value))
                        {
                            duplicada = false;
                            break;
                        }
                    }
                    if (duplicada)
                    {
                        dgv.Rows.Remove(row);
                        MessageBox.Show("Insumo ja inserido. Para alterar a quantidade de duplo clique no campo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PLN--;
                    }
                }
            }
        }

      /*=============================
        EXCLUIR UM ITEM DA COMPOSIÇÃO
        =============================*/

        private void btnExcluirComp_Click(object sender, EventArgs e)
        {
            if (dgvComposicao.RowCount == 0)
            {
                MessageBox.Show("Não há itens para excluir!");
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Excluir o item selecionado da composição?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    dgvComposicao.Rows.RemoveAt(dgvComposicao.CurrentRow.Index);
                    MessageBox.Show("Exclusão realizada com sucesso!", "", MessageBoxButtons.OK);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancela = MessageBox.Show("Deseja realmente cancelar esta operação?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancela.ToString().ToUpper() == "YES")
            {
                this.Close();
                MessageBox.Show("Operação cancelada com sucesso!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      /*==============
        SALVAR FORMULA
        ==============*/

        private void btnSalvarFormula_Click(object sender, EventArgs e)
        {
            if (dgvComposicao.Rows.Count > 0)
            {
                DialogResult salvarform = MessageBox.Show("Deseja salvar fórmula?", "Salvar fórmula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (salvarform.ToString().ToUpper() == "YES")
                {
                    if (dgvComposicao.RowCount == 0) MessageBox.Show("Não há composição para a fórmula!");
                    else
                    {
                        if (txtDescFormula.TextLength == 0)
                        {
                            DialogResult quest = MessageBox.Show("Fórmula sem descrição, deseja realmente prosseguir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (quest.ToString().ToUpper() == "YES") salva();
                        }
                        else salva();
                    }
                }
            }
            else
            {
                MessageBox.Show("Fórmula sem composição.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void salva()
        {
            int codigo = Convert.ToInt32(nudCodForm.Value);
            DTO.descricao = txtDescFormula.Text;
            BLL.update(DTO, codigo);
            BLL.delete(codigo);

            for (int linha = 0; linha < dgvComposicao.Rows.Count; linha++)
            {
                DTOI.codigo_form = codigo;
                DTOI.codigo_prod = Convert.ToInt32(this.dgvComposicao.Rows[linha].Cells[0].Value.ToString());
                DTOI.quantidade = Convert.ToInt32(this.dgvComposicao.Rows[linha].Cells[2].Value.ToString());
                BLLI.SalvaComposicao(DTOI);
            }
            MessageBox.Show("Fórmula modificada com sucesso!");
            this.Close();
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
