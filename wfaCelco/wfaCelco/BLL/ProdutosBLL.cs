using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data; 
using wfaCelco.DAL;
using wfaCelco.UI; 

namespace wfaCelco.BLL
{
    class ProdutosBLL
    {
        ProdutosDAL produtosDal = new ProdutosDAL();

        public void consultarProd(DataGridView dgv)
        {
            string consultaSQL = "SELECT P.PRODUTO_ID    as 'Produto'," +
                                 "P.PRODUTO_NOME         as 'Nome'," +
                                 "P.PRODUTO_DESCRICAO    as 'Nome/Descrição'," +
                                 "P.PRODUTO_TIPO         as 'Tipo', S.ESTOQUE_QTD as Quantidade FROM G07_PRODUTOS P LEFT JOIN G07_ESTOQUE S ON S.PRODUTO_ID = P.PRODUTO_ID";
            produtosDal.Consultar(dgv, consultaSQL);
        }

        public void buscarProd(DataGridView dgv, string txt)
        {
            string buscarSQL = "SELECT PRODUTO_ID    as 'Produto'," +
                                 "PRODUTO_NOME         as 'Nome'," +
                                 "PRODUTO_DESCRICAO    as 'Nome/Descrição'," +
                                 "PRODUTO_TIPO         as 'Tipo' FROM G07_PRODUTOS WHERE PRODUTO_NOME = '" + txt + "'"; 
            produtosDal.Consultar(dgv, buscarSQL);
        }

        public void inserirProd(string nome, string desc, string categ, int status, string tipo)
        {
            string sqlProd = String.Format("INSERT INTO G07_PRODUTOS(PRODUTO_NOME, PRODUTO_DESCRICAO, PRODUTO_CATEGORIA, PRODUTO_STATUS, PRODUTO_TIPO) VALUES ('{0}','{1}','{2}',{3},'{4}')", nome, desc, categ, status, tipo);
            produtosDal.Inserir(sqlProd); 
        }

        public frmNovoProduto.Produto buscaProdById(int id)
        {
            string populaForm = "SELECT * FROM G07_PRODUTOS WHERE PRODUTO_ID = " + id;

            DataTable datatable = produtosDal.buscaProdById(populaForm);
            return constroiProdutoFromDataTable(datatable);
        }

        public void atualizarProd(int id, string nome, string desc, string categ, int status, string tipo)
        {
            string updateSQL = String.Format("UPDATE G07_PRODUTOS SET " +
                                                "PRODUTO_NOME = '{1}'," +
                                                "PRODUTO_DESCRICAO = '{2}'," +
                                                "PRODUTO_CATEGORIA = '{3}'," +
                                                "PRODUTO_STATUS = {4}," +
                                                "PRODUTO_TIPO = '{5}'" +
                                                " WHERE PRODUTO_ID = {0}",
                                                id,
                                                nome,
                                                desc,
                                                categ,
                                                status,
                                                tipo);

            produtosDal.Atualizar(updateSQL);
        }

        public frmNovoProduto.Produto constroiProdutoFromDataTable(DataTable dt)
        {

            frmNovoProduto.Produto produto = new frmNovoProduto.Produto();

            produto.id = (int)dt.Rows[0]["PRODUTO_ID"];
            produto.nome = dt.Rows[0]["PRODUTO_NOME"].ToString();
            produto.desc = dt.Rows[0]["PRODUTO_DESCRICAO"].ToString();
            produto.categ = dt.Rows[0]["PRODUTO_CATEGORIA"].ToString();
            produto.status = int.Parse(dt.Rows[0]["PRODUTO_STATUS"].ToString()); 
            produto.tipo = dt.Rows[0]["PRODUTO_TIPO"].ToString();

            return produto;
        }
    }
}
