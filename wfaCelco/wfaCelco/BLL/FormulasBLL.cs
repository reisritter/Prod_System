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
    class FormulasBLL
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

        /*==========================
          CONDICAO PARA NOVA FORMULA
          ==========================*/

        public string PRcondicao()
        {
            string comando = "SELECT COUNT(PRODUTO_ID) FROM dbo.G07_PRODUTOS " +
                             "WHERE PRODUTO_TIPO LIKE 'PRODUTO ACABADO';";
            return dal.Informacao(comando);
        }

        public string SGcondicao()
        {
            string comando = "SELECT COUNT(I.PRODUTO_ID) FROM dbo.G07_ITEM_FORMULA I " +
                             "INNER JOIN " +
                             "dbo.G07_PRODUTOS P ON I.PRODUTO_ID = P.PRODUTO_ID " +
                             "WHERE PRODUTO_TIPO LIKE 'PRODUTO ACABADO';";
            return dal.Informacao(comando);
        }

        public string TRcondicao(string PP)
        {
            string comando = "SELECT COUNT(I.FORMULA_ID) FROM dbo.G07_FORMULAS I " +
                             "INNER JOIN " +
                             "dbo.G07_PRODUCAO P ON I.FORMULA_ID = P.FORMULA_ID " +
                             "WHERE I.FORMULA_ID = " + PP + ";";
            return dal.Informacao(comando);
        }


        /*===========================================
          ATUALIZAR O GRID DE COMPOSICAO DAS FORMULAS
          ===========================================*/

        public void AtualizaGrid(DataGridView dgv, string P)
        {
            string comandoSQL = "SELECT	FORMULA_ID       as 'Código da fórmula', "   +
                                "FORMULA_DESCRICAO       as 'Descrição da fórmula' " +
                                "FROM dbo.G07_FORMULAS " + P + ";";
            dal.atualizar(dgv, comandoSQL);
        }

        public void AtualizaGrid2(DataGridView dgv, string P)
        {
            string comandoSQL = "SELECT  ITEM_ID 'Cod. Item', ITEM_QTD 'Quantidade Item', " +
                                "I.PEDIDO_ID 'Cod. Pedido', I.PRODUTO_ID 'Cod. Produto', " +
                                "R.PRODUTO_NOME 'Nome Produto' FROM G07_PEDIDOS P " +
                                "INNER JOIN dbo.G07_ITEM_PEDIDOS I ON I.PEDIDO_ID = P.PEDIDO_ID " +
                                "INNER JOIN dbo.G07_PRODUTOS R ON R.PRODUTO_ID = I.PRODUTO_ID " +
                               "WHERE I.PEDIDO_ID = " + P + ";";
            dal.atualizar(dgv, comandoSQL);
        }

        public void AtualizarProcesso(FormulasDTO dto, string P)
        {
            string comandoSQL = "UPDATE G07_PEDIDOS SET PEDIDO_STATUS = 'CANCELADO' WHERE PEDIDO_ID = " + P + ";";
            dal.ExecutarComandoSQL(comandoSQL);
        }

        /*============================
          ATUALIZAR O GRID DE FORMULAS
          ============================*/

        public void AtualizaGridComp(DataGridView dgv, string P)
        {
            string comando = "SELECT P.PRODUTO_ID AS 'Codigo', "    +
                             "PRODUTO_NOME        AS 'Nome', "      +
                             "FORMULA_ITEM_QTD    AS 'Quantidade' " +
                             "FROM dbo.G07_PRODUTOS P " +
                             "INNER JOIN " +
                             "dbo.G07_ITEM_FORMULA I ON P.PRODUTO_ID = I.PRODUTO_ID " +
                             "WHERE FORMULA_ID = " + P + " AND P.PRODUTO_TIPO LIKE 'MATERIA-PRIMA'";
            dal.atualizar(dgv, comando);
        }

        /*==================
          SALVAR UMA FORMULA
          ==================*/

        public void SalvaFormula(FormulasDTO dto)
        {
            string comando = "INSERT INTO dbo.G07_FORMULAS VALUES ('" + dto.descricao + "');";

            try
            {
                dal.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SalvaFormula2(FormulasDTO dto)
        {
            string comando = "INSERT INTO dbo.G07_PEDIDOS (PEDIDO_DATA, PEDIDO_DATA_ENTREGA, PEDIDO_STATUS, CLI_ID) VALUES (GETDATE(), '" + dto.Pedido_data_entrega + "', 'EM PROCESSO', '" + dto.Cli_id + "')";

            try
            {
                dal.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*=================================
          PRODUTOS CARREGADOS NOS COMBO BOX
          =================================*/

        public void ProdAssoc(ComboBox cb)
        {
            string comando = "SELECT * FROM dbo.G07_PRODUTOS P " +
                             "WHERE P.PRODUTO_ID NOT IN(SELECT PRODUTO_ID " +
                             "FROM dbo.G07_ITEM_FORMULA) AND " +
                             "PRODUTO_TIPO LIKE 'PRODUTO ACABADO';";
            dal.selecnova(cb, comando);
        }


        public void ProdAssoc2(ComboBox cb)
        {
            string comando = "SELECT * FROM dbo.G07_PRODUTOS P ";
            dal.selecnova(cb, comando);
        }

        public void CliAssoc(ComboBox cb)
        {
            string comando = "SELECT * FROM dbo.G07_CLIENTES C ";
            dal.selecnova(cb, comando);
        }

        public void ProdInsumo(ComboBox cb)
        {
            string comando = "SELECT * FROM dbo.G07_PRODUTOS WHERE PRODUTO_TIPO LIKE 'MATERIA-PRIMA'";
            dal.selecnova(cb, comando);
        }

      /*================
        DELETAR FORMULAS
        ================*/

        public void delete(int codigo)
        {
            string comando = "DELETE dbo.G07_ITEM_FORMULA FROM dbo.G07_ITEM_FORMULA I " +
                             " INNER JOIN " +
                             " dbo.G07_PRODUTOS P ON I.PRODUTO_ID = P.PRODUTO_ID " +
                             "WHERE FORMULA_ID = " + codigo + ";";
            dal.ExecutarComandoSQL(comando);

            string comandoF = "DELETE FROM dbo.G07_FORMULAS " +
                             "WHERE FORMULA_ID = " + codigo + ";";
            dal.ExecutarComandoSQL(comandoF);
        }
    }
}
