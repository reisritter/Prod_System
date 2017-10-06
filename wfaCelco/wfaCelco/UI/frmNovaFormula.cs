using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaCelco.BLL;
using wfaCelco.DTO;

namespace wfaCelco.UI
{
    public partial class frmPedidoNovo : Form
    {
        private Form FORM = new Form();
        FormulasBLL  BLLF = new FormulasBLL();
        ItemFormBLL  BLLI = new ItemFormBLL();
        FormulasDTO  dtof = new FormulasDTO();
        ProdutosDTO  dtop = new ProdutosDTO();
        ItemFormDTO  dtoi = new ItemFormDTO(); 

        public frmPedidoNovo()
        {
            InitializeComponent();
            this.Text = "Nova fórmula";

            try
            {
                nudCodForm.Value = 1 + Convert.ToInt32(BLLI.Informacao("MAX(FORMULA_ID)", "FORMULAS", ""));
            }
            catch
            {
                nudCodForm.Value = 1;
            }

            dgvComposicao.ColumnCount = 3;
            dgvComposicao.Columns[0].Name = "Codigo";
            dgvComposicao.Columns[1].Name = "Nome";
            dgvComposicao.Columns[2].Name = "Quantidade";
            dgvComposicao.Columns[0].ReadOnly = true;
            dgvComposicao.Columns[1].ReadOnly = true;
            dgvComposicao.Columns[2].ReadOnly = false;

            cbProdFormula.DropDownStyle = ComboBoxStyle.DropDownList;
            BLLF.ProdAssoc(cbProdFormula);
            cbProdFormula.ValueMember = "PRODUTO_ID";
            cbProdFormula.DisplayMember = "PRODUTO_NOME";
            cbProdFormula.Update();
            txtCodProd.Text = "" + Convert.ToInt32(cbProdFormula.SelectedValue);

            cbNome.DropDownStyle = ComboBoxStyle.DropDownList;
            BLLF.ProdInsumo(cbNome);
            cbNome.ValueMember = "PRODUTO_ID";
            cbNome.DisplayMember = "PRODUTO_NOME";
            cbNome.Update();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProdFormula_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodProd.Text = "" + cbProdFormula.SelectedValue;
            cbProdFormula.Update();
        }

        private void cbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNome.Update();
        }

      /*==============
        SALVAR FORMULA
        ==============*/

        private void btnSalvarFormula_Click(object sender, EventArgs e)
        {
            DialogResult salvarform = MessageBox.Show("Deseja salvar uma nova fórmula?", "Salvar fórmula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(salvarform.ToString().ToUpper() == "YES")
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

        private void salva()
        {
            dtof.descricao = txtDescFormula.Text;
            BLLF.SalvaFormula(dtof);

            int codigo = Convert.ToInt32(BLLI.Informacao("MAX(FORMULA_ID)", "FORMULAS", ""));
            dtoi.codigo_form = codigo;
            dtoi.codigo_prod = Convert.ToInt32(txtCodProd.Text);
            dtoi.quantidade  = 1;
            BLLI.SalvaComposicao(dtoi);

            for (int linha = 0; linha < dgvComposicao.Rows.Count; linha++)
            {
                dtoi.codigo_form = codigo;
                dtoi.codigo_prod = Convert.ToInt32(this.dgvComposicao.Rows[linha].Cells[0].Value.ToString());
                dtoi.quantidade  = Convert.ToInt32(this.dgvComposicao.Rows[linha].Cells[2].Value.ToString());
                BLLI.SalvaComposicao(dtoi);
            }
            MessageBox.Show("Fórmula cadastrada com sucesso!");
            this.Close();
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
                string ID  = BLLI.Informacao("PRODUTO_ID", "PRODUTOS", " WHERE PRODUTO_ID = " + Convert.ToInt32(cbNome.SelectedValue));
                string DC  = BLLI.Informacao("PRODUTO_NOME", "PRODUTOS", " WHERE PRODUTO_ID = " + Convert.ToInt32(cbNome.SelectedValue));
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
                    if(duplicada)
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

        private void btnExcluir_Click(object sender, EventArgs e)
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