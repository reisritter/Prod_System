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
using wfaCelco.DAL;

namespace wfaCelco.UI
{
    public partial class frmEstoqueProd : Form
    {
        int qtd = 0, estoque = 0, idProd, qtdTotalNovo;
        frmProdutos frmProdutos = new frmProdutos();
        EstoqueBLL estoqueBLL = new EstoqueBLL();
        EstoqueDAL estoqueDAL = new EstoqueDAL();
        PedidoDAL pedidoDAL = new PedidoDAL();
        PedidoBLL pedidoBLL = new PedidoBLL();
        ProdutosBLL produtoBLL = new ProdutosBLL();

        string msgSalvar = "Deseja atualizar o estoque?";
        string msgZero = "Quantidade precisa ser diferente de 0!";
        string msgNegativo = "Quantidade total precisa ser positiva!";


        public frmEstoqueProd(frmProdutos p)
        {
            InitializeComponent();

            frmProdutos = p;

            idProd = Convert.ToInt32(frmProdutos.dgvProd.CurrentRow.Cells[0].Value.ToString());
            string nomeProd = frmProdutos.dgvProd.CurrentRow.Cells[1].Value.ToString();

            estoque = estoqueBLL.Consulta_QTDE_ESTQOUE(idProd);
            qtdTotalNovo = (qtd + estoque);

            txtAdd.Text = qtd.ToString();
            lblNomeProduto.Text = nomeProd;
            lblQtde.Text = estoque.ToString();
            lblNovaQtde.Text = estoque.ToString();
        }

        private void btnSalvaEstoque_Click(object sender, EventArgs e)
        {
            if (qtd != 0)
            {
                if (qtdTotalNovo >= 0)
                {
                    if (MessageBox.Show(msgSalvar + " ", "Estoque", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        estoqueDAL.Update_Estoque(qtdTotalNovo, idProd);
                        if (rdbCompra.Checked)
                        {
                            pedidoDAL.Insere_Pedido(new DateTime(2016, 1, 12), 1, idProd);
                            pedidoDAL.Insere_Item_Pedido(qtdTotalNovo, pedidoBLL.Consulta_Ultimo_Pedido(), idProd);
                        }
                        Close();
                        produtoBLL.consultarProd(frmProdutos.dgvProd);
                    }
                }
                else
                    MessageBox.Show(msgNegativo);

            }
            else
                MessageBox.Show(msgZero);
        }

        private void btnCancelaCli_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                if (e.KeyChar == 48 && Convert.ToInt32(txtAdd.Text) == 0)
                    e.Handled = true;
                else if ((e.KeyChar > 48 && e.KeyChar <= 57) && Convert.ToInt32(txtAdd.Text) == 0)
                {
                    e.Handled = true;
                    txtAdd.Text = (e.KeyChar - 48).ToString();
                    txtAdd.Select(txtAdd.Text.Length, 0);
                }
                else
                    e.Handled = false;
            }
        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            if (txtAdd.Text == "")
                txtAdd.Text = "0";
            else
            {
                qtd = Convert.ToInt32(txtAdd.Text);
                qtdTotalNovo = (qtd + estoque);
            }

            if (qtd < 0)
            {
                rdbCorrecao.Checked = true;
                rdbCompra.Enabled = false;
            }

            else rdbCompra.Enabled = true;


            lblNovaQtde.Text = qtdTotalNovo.ToString();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (qtd < 0)
                estoqueBLL.Mult_Menos_Um(qtd, txtAdd);
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (qtd > 0)
                estoqueBLL.Mult_Menos_Um(qtd, txtAdd);
        }
    }
}
