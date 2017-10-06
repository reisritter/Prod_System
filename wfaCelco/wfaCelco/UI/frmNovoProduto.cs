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
    public partial class frmNovoProduto : Form
    {
        private readonly ProdutosBLL produtosBll = new ProdutosBLL();
        EstoqueBLL estoqueBLL = new EstoqueBLL();
        EstoqueDAL estoqueDAL = new EstoqueDAL();

        private Produto produto; 

        //models: classe que representa a estrutura do banco de dados para auxiliar no popular a tabela 
        public class Produto
        {
            public int id;
            public string nome;
            public string desc;
            public string categ;
            public int status;
            public string tipo;
         
            public Produto()
            {

            }

            public Produto(int id)
            {
                this.id = id;
            }
        }

        public frmNovoProduto()
        {
            InitializeComponent();
            cbxTipo.SelectedIndex = 0;
            txtNomeProd.Focus();
        }

        public frmNovoProduto(string id)
        {
            produto = produtosBll.buscaProdById(int.Parse(id));

            InitializeComponent();
            carregarDadosDoUpdateProd();
            disableOrEnableLessCheck();
            txtNomeProd.Focus();

            if (produto != null) gbEstoqueAtual.Enabled = false;
            else gbEstoqueAtual.Enabled = true;
        }

        private void disableOrEnableLessCheck()
        {
            bool check = rdbInativo.Checked ? false : true; 

            txtNomeProd.Enabled = check;
            txtDescProd.Enabled = check;
            txtCategProd.Enabled = check;
            cbxTipo.Enabled = check; 
        } 

        private void txtNomeProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
              e.KeyChar != 'á' && e.KeyChar != 'Á' && e.KeyChar != 'À' && e.KeyChar != 'à'
              && e.KeyChar != 'ã' && e.KeyChar != 'É' && e.KeyChar != 'é' && e.KeyChar != 'è'
              && e.KeyChar != 'Í' && e.KeyChar != 'í' && e.KeyChar != 'Ó' && e.KeyChar != 'ó'
              && e.KeyChar != 'õ' && e.KeyChar != 'Ú' && e.KeyChar != 'ú' && e.KeyChar != 'ç'
              && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                MessageBox.Show("Digite apenas letras!");
                e.KeyChar = (Char)0;
            }
        }

        private void txtCategProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') &&
               e.KeyChar != 'á' && e.KeyChar != 'Á' && e.KeyChar != 'À' && e.KeyChar != 'à'
               && e.KeyChar != 'ã' && e.KeyChar != 'É' && e.KeyChar != 'é' && e.KeyChar != 'è'
               && e.KeyChar != 'Í' && e.KeyChar != 'í' && e.KeyChar != 'Ó' && e.KeyChar != 'ó'
               && e.KeyChar != 'õ' && e.KeyChar != 'Ú' && e.KeyChar != 'ú' && e.KeyChar != 'ç'
               && e.KeyChar != (char)8 && e.KeyChar != (char)32)
            {
                MessageBox.Show("Digite apenas letras!");
                e.KeyChar = (Char)0;
            }
        }

        private bool valida()
        {
            bool bStatus = false;

            if (chbProdutoEstoque.Checked && txtEstoqueAtual.Text == "")
            {
                EPProdutos.SetError(txtEstoqueAtual, "Preencha este campo!");
                txtNomeProd.Focus();
                bStatus = true;
            }
            else
                EPProdutos.SetError(txtEstoqueAtual, "");

            if (txtNomeProd.Text == "")
            {
                EPProdutos.SetError(txtNomeProd, "Preencha este campo!");
                txtNomeProd.Focus();
                bStatus = true;
            }
            else
                EPProdutos.SetError(txtNomeProd, "");

            if (txtCategProd.Text == "")
            {
                EPProdutos.SetError(txtCategProd, "Preencha este campo!");
                txtCategProd.Focus(); 
                bStatus = true;
            }
            else
                EPProdutos.SetError(txtCategProd, "");

            if (txtDescProd.Text == "")
            {
                EPProdutos.SetError(txtDescProd, "Preencha este campo!");
                txtDescProd.Focus(); 
                bStatus = true;
            }
            else
                EPProdutos.SetError(txtDescProd, "");

            if (cbxTipo.Text == "")
            {
                EPProdutos.SetError(cbxTipo, "Escolha uma opção!");
                cbxTipo.Focus();
                bStatus = true;
            }
            else
                EPProdutos.SetError(cbxTipo, "");

            return bStatus;
        }

        private void carregarDadosDoUpdateProd()
        {
            txtNomeProd.Text = produto.nome;
            txtDescProd.Text = produto.desc;
            txtCategProd.Text = produto.categ;
            cbxTipo.Text = produto.tipo;

            if(produto.status == 0)
            {
                rdbAtivo.Checked = true;
            }
            else
            {
                rdbInativo.Checked = true; 
            }
                                       
        }

        private void btnIncluiProd_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (produto == null)
            {
                //INSERT                
                if (MessageBox.Show("Deseja inserir este produto?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int status = rdbAtivo.Checked ? 0 : 1;
                    produtosBll.inserirProd(txtNomeProd.Text, txtDescProd.Text, txtCategProd.Text, status, cbxTipo.Text);

                    if (chbProdutoEstoque.Checked)
                        estoqueDAL.Insere_Estoque(Convert.ToInt32(txtEstoqueAtual.Text), 1, estoqueBLL.Consulta_UltimoProduto());

                    MessageBox.Show("Produto inserido com sucesso!");
                    if (MessageBox.Show("Deseja inserir outro produto?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtDescProd.Text = "";
                        txtCategProd.Text = "";
                        rdbAtivo.Checked = true;
                        cbxTipo.Text = "";
                        txtNomeProd.Text = "";
                        txtNomeProd.Focus();
                    }
                    else
                        this.Close();

                }
                else
                    txtNomeProd.Focus();
            }
            else
            {
                //UPDATE
                DialogResult answer1 = MessageBox.Show("Deseja atualizar este produto?", "", MessageBoxButtons.YesNo);

                if (answer1 == DialogResult.Yes)
                {
                    int status = rdbAtivo.Checked ? 0 : 1;

                    produtosBll.atualizarProd(produto.id, txtNomeProd.Text, txtDescProd.Text, txtCategProd.Text, status, cbxTipo.Text);
                    MessageBox.Show("Produto atualizado com sucesso!");
                    this.Close();
                }
                else
                {
                    txtNomeProd.Focus();
                }
            }
        }

        private void btnCancelaProd_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            disableOrEnableLessCheck(); 
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            disableOrEnableLessCheck(); 
        }

        private void chbProdutoEstoque_CheckedChanged(object sender, EventArgs e)
        {
            if (chbProdutoEstoque.Checked)
                txtEstoqueAtual.Enabled = true;
            else txtEstoqueAtual.Enabled = false;
        }

        private void txtEstoqueAtual_TextChanged(object sender, EventArgs e)
        {
            if (txtEstoqueAtual.Text == "")
                txtEstoqueAtual.Text = "0";
        }

        private void txtEstoqueAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                if (e.KeyChar == 48 && Convert.ToInt32(txtEstoqueAtual.Text) == 0)
                    e.Handled = true;
                else if ((e.KeyChar > 48 && e.KeyChar <= 57) && Convert.ToInt32(txtEstoqueAtual.Text) == 0)
                {
                    e.Handled = true;
                    txtEstoqueAtual.Text = (e.KeyChar - 48).ToString();
                    txtEstoqueAtual.Select(txtEstoqueAtual.Text.Length, 0);
                }
                else
                    e.Handled = false;
            }

            else e.Handled = true;
        }

        private void txtEstoqueAtual_EnabledChanged(object sender, EventArgs e)
        {
            if (txtEstoqueAtual.Enabled)
                txtEstoqueAtual.Text = "0";
        }
    }
}
