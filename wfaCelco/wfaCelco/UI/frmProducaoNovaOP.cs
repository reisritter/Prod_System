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
    public partial class frmProducaoNovaOP : Form
    {
        
        ProducaoBLL bll = new ProducaoBLL();
        ProducaoDTO dto = new ProducaoDTO();
        RecursosBLL BLL = new RecursosBLL();
        ItemRecDTO DTO  = new ItemRecDTO();
        int cod = 0;

        //int IDProd = 0;

        public frmProducaoNovaOP()
        {
            InitializeComponent();

            dtInicio.Value   = DateTime.Now.Date;
            dtInicio.MinDate = DateTime.Today;
            dtFim.Value      = DateTime.Now.Date;
            dtFim.MinDate    = DateTime.Today;
            bll.consultaProdutosAtivos(cbbProdutos);

            // Especifica INDEX/VALOR no ComboBox do Produtos
            this.cbbProdutos.ValueMember = "PRODUTO_ID";
            this.cbbProdutos.DisplayMember = "PRODUTO_NOME";

            // Especifica INDEX/VALOR no ComboBox do Nome do Recursos
            this.cbbNomeRec.ValueMember = "RECURSO_ID";
            this.cbbNomeRec.DisplayMember = "RECURSO_NOME";
            this.cbbTipoRec.SelectedIndex = 0;

            // Linhas GRID ITEM
            dgvItem.ColumnCount = 3;
            dgvItem.Columns[0].Name = "Código do recurso";
            dgvItem.Columns[1].Name = "Nome";
            dgvItem.Columns[2].Name = "Quantidade";
            dgvItem.Columns[0].ReadOnly = true;
            dgvItem.Columns[1].ReadOnly = true;
            dgvItem.Columns[2].ReadOnly = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' && e.KeyChar > '9') || e.KeyChar == ',' || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z'))
            {
                MessageBox.Show("CAMPO PREENCHIDO INCORRETAMENTE...");
                e.KeyChar = (char)0;
                txtQtde.Focus();
            }
        }

        private void cbbTipoRec_SelectedIndexChanged(object sender, EventArgs e)
        {
            //preenche o ComboBox [Nome do Recurso] com o tipo de recurso
            if (cbbTipoRec.SelectedIndex == 0)
            {
                string tipo = cbbTipoRec.SelectedItem.ToString();
                bll.consultaRecursos(cbbNomeRec, tipo);
            }
            if (cbbTipoRec.SelectedIndex == 1)
            {
                string tipo = cbbTipoRec.SelectedItem.ToString();
                bll.consultaRecursos(cbbNomeRec, tipo);
            }
        }

      /*========================
        SALVAR ORDEM DE PRODUCAO
        ========================*/

        private void btnSalvarOP_Click(object sender, EventArgs e)
        {
            if (dgvItem.Rows.Count > 0)
            {
                DialogResult salvarform = MessageBox.Show("Deseja salvar ordem?", "Salvar Ordem de Produção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (salvarform.ToString().ToUpper() == "YES")
                {
                    if (dgvItem.RowCount == 0) MessageBox.Show("Ordem sem recursos!");
                    else
                    {
                        if (txtObs.TextLength == 0)
                        {
                            DialogResult quest = MessageBox.Show("Ordem sem observação, deseja realmente prosseguir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (quest.ToString().ToUpper() == "YES") salva();
                        }
                        else salva();
                    }
                }
            }
            else
            {
                MessageBox.Show("Ordem sem recursos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool Verifica()
        {
            if(txtQtde.Value > 100)
            {
                errorProvider1.SetError(txtQtde, "Coloque um valor abaixo de 101");
                return false;
            }
            return true;
        }

        public void salva()
        {
            if (Convert.ToDateTime(this.dtInicio.Value.ToString("yyyy-MM-dd")) <= Convert.ToDateTime(this.dtFim.Value.ToString("yyyy-MM-dd")))
            {
                if(Verifica())
                {
                    dto.Producao_data_inicio = this.dtInicio.Value.ToString("yyyy-MM-dd");
                    dto.Producao_data_fim = this.dtFim.Value.ToString("yyyy-MM-dd");
                    dto.Producao_qtd = int.Parse(this.txtQtde.Text);
                    dto.Producao_obs = txtObs.Text;
                    dto.Produto_id = Int32.Parse(cbbProdutos.SelectedValue.ToString());
                    dto.FORM = Convert.ToInt32(BLL.Informacao("I.FORMULA_ID", "ITEM_FORMULA I", " INNER JOIN " +
                                                              "dbo.G07_PRODUTOS P ON I.PRODUTO_ID = P.PRODUTO_ID " +
                                                              "WHERE I.PRODUTO_ID = " + cbbProdutos.SelectedValue));
                    bll.NovaOP(dto);

                    int codigo = Convert.ToInt32(BLL.Informacao("MAX(PRODUCAO_ID)", "PRODUCAO", ""));

                    for (int linha = 0; linha < dgvItem.Rows.Count; linha++)
                    {
                        DTO.REC_ID = Convert.ToInt32(dgvItem.CurrentRow.Cells[0].Value);
                        DTO.PROD_ID = codigo;
                        DTO.QTD = Convert.ToInt32(dgvItem.CurrentRow.Cells[2].Value);
                        BLL.SalvaItemRec(DTO);
                    }
                    MessageBox.Show("OP (Ordem de Produção) registrada com sucesso!!!", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Datas incorretas verifique os intervalos...", "A T E N Ç Ã O   [M E N S A G E M] ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtInicio.Focus();
            }
        }

      /*================
        INSERIR RECURSOS
        ================*/

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int QTD = Convert.ToInt32(BLL.Informacao("RECURSO_QTD", "RECURSOS", " WHERE RECURSO_ID = " + cbbNomeRec.ValueMember));
            if (numQTD.Value == 0)
            {
                MessageBox.Show("Quantidade zero!");
            }
            else if(numQTD.Value > QTD)
            {
                MessageBox.Show("Quantidade excedida. O máximo disponível é: " + QTD);
            }
            else
            {
                string ID = BLL.Informacao("RECURSO_ID", "RECURSOS", " WHERE RECURSO_ID = " + Convert.ToInt32(cbbNomeRec.SelectedValue));
                string DC = BLL.Informacao("RECURSO_NOME", "RECURSOS", " WHERE RECURSO_ID = " + Convert.ToInt32(cbbNomeRec.SelectedValue));
                dgvItem.Rows.Add(ID, DC, numQTD.Value);
                RemoveDuplicate(dgvItem);
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
                        MessageBox.Show("Recurso ja inserido. Para alterar a quantidade de duplo clique no campo.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (dgvItem.RowCount == 0)
            {
                MessageBox.Show("Não há itens para excluir!");
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Excluir o item selecionado da composição?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    dgvItem.Rows.RemoveAt(dgvItem.CurrentRow.Index);
                }
            }
        }

        private void dgvItem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int QTD = Convert.ToInt32(BLL.Informacao("RECURSO_QTD", "RECURSOS", " WHERE RECURSO_ID = " + dgvItem.CurrentRow.Cells[0].Value));
            int POS = Convert.ToInt32(dgvItem.CurrentRow.Cells[2].Value);
            if (POS > QTD)
            {
                MessageBox.Show("Quantidade excedida. O máximo disponível é: " + QTD, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvItem.CurrentRow.Cells[2].Value = cod;
            }
            else if (dgvItem.CurrentRow.Cells[2].Value == null)
            {
                MessageBox.Show("Quantidade em branco!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvItem.CurrentRow.Cells[2].Value = cod;
            }
            else if (POS == 0)
            {
                MessageBox.Show("Quantidade inválida!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dgvItem.CurrentRow.Cells[2].Value = cod;
            }
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cod = Convert.ToInt32(dgvItem.CurrentRow.Cells[2].Value);
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

        private void cbbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("" + cbbProdutos.SelectedValue.ToString());
        }

        private void cbbProdutos_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("" + cbbProdutos.SelectedValue.ToString());
            txtPed.Text = bll.consultaPedidoProd(Convert.ToInt32(cbbProdutos.SelectedValue.ToString()));
        }
    }
}
