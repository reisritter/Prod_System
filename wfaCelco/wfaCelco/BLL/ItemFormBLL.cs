using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using wfaCelco.DAL;
using wfaCelco.DTO;

namespace wfaCelco.BLL
{
    class ItemFormBLL
    {
        globalDAL dal = new globalDAL();

      /*======================================
        PARA CAPTURAR DADOS UNITARIOS DO BANCO
        ======================================*/

        public string Informacao(string PP, string SP, string TP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + TP + ";";
            return dal.Informacao(comando);
        }

        /*==================================
          SALVAR A COMPOSICAO DE UMA FORMULA
          ==================================*/

        public void SalvaComposicao(ItemProdDTO dto)
        {
            string comando = "INSERT INTO G07_ITEM_PEDIDOS(PEDIDO_ID, PRODUTO_ID, ITEM_QTD) VALUES" +
                             "(" + dto.codigo_pedido + "," + dto.codigo_prod + "," + dto.quantidade + ");";

            try
            {
                dal.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SalvaComposicao(ItemFormDTO dto)
        {
            string comando = "INSERT INTO G07_ITEM_FORMULA (FORMULA_ID, PRODUTO_ID, FORMULA_ITEM_QTD) VALUES" +
                             "(" + dto.codigo_form + "," + dto.codigo_prod + "," + dto.quantidade + ");";

            try
            {
                dal.ExecutarComandoSQL(comando);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

      /*===============================
        ATUALIZAR A TABELA DATAGRIDVIEW
        ===============================*/

        public void Atualiza(DataGridView dgv, int n)
        {
            string comando = "SELECT   PRODUTO_ID        AS 'Código do produto', " +
                                      "PRODUTO_DESCRICAO AS 'Descrição' "          +
                                 "FROM dbo.G07_PRODUTOS"                           +
                                 " WHERE PRODUTO_ID = " + n + ";";
            dal.atualizar(dgv, comando);
        }

      /*===========================================
        EXCLUIR UMA FORMULA E UM ITEM DE COMPOSICAO
        ===========================================*/

        public void EXComposicao(int selecao)
        {
            string comando = "DELETE FROM dbo.G07_ITEM_FORMULA " +
                             "WHERE PRODUTO_ID = " +  selecao +";";
            dal.ExecutarComandoSQL(comando);
        }

        public void EXFormula(int selecao)
        {
            string comando = "DELETE FROM dbo.G07_FORMULAS " +
                             "WHERE FORMULA_ID = " + selecao + ";";
            dal.ExecutarComandoSQL(comando);
        }
    }
}
