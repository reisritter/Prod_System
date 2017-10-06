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
    class AltFormBLL
    {
        globalDAL dal = new globalDAL();

      /*=============================
        SALVAR A ALTERACAO DA FORMULA
        =============================*/

        public void update(FormulasDTO dto, int codigo)
        {
            string comando = "UPDATE dbo.G07_FORMULAS " +
                             "SET FORMULA_DESCRICAO = " + "'" + dto.descricao + "'" +
                             " WHERE FORMULA_ID = " + codigo + ";";
            dal.ExecutarComandoSQL(comando);
        }

      /*======================================
        PARA CAPTURAR DADOS UNITARIOS DO BANCO
        ======================================*/

        public string Informacao(string PP, string SP, string TP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + TP + ";";
            return dal.Informacao(comando);
        }

        public string InformacaoInner(string PP, string SP, string TP, string QP, string QIP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + " INNER JOIN dbo.G07_" + TP + " ON " + QP + QIP + ";";
            return dal.Informacao(comando);
        }

        public string Dados(string PP, string SP, string TP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + TP + ";";
            return dal.Dados(comando);
        }

        /*===========================================
          ATUALIZAR O GRID DE COMPOSICAO DAS FORMULAS
          ===========================================*/

        public void preencherGrid(DataGridView dgv,string P)
        {
            string comando = "SELECT P.PRODUTO_ID, PRODUTO_NOME, FORMULA_ITEM_QTD FROM dbo.G07_PRODUTOS P " +
                             "INNER JOIN " +
                             "dbo.G07_ITEM_FORMULA I ON P.PRODUTO_ID = I.PRODUTO_ID " +
                             "WHERE FORMULA_ID = " + P + " AND P.PRODUTO_TIPO LIKE 'MATERIA-PRIMA'";
            dal.atualizar(dgv, comando);
        }

      /*=========================================
        DELETANDO ITENS DA COMPOSICAO DA FORMULAS
        =========================================*/

        public void delete(int codigo)
        {
            string comando = "DELETE dbo.G07_ITEM_FORMULA FROM dbo.G07_ITEM_FORMULA I " +
                             " INNER JOIN " +
                             " dbo.G07_PRODUTOS P ON I.PRODUTO_ID = P.PRODUTO_ID " +
                             "WHERE FORMULA_ID = " + codigo + " AND P.PRODUTO_TIPO LIKE 'MATERIA-PRIMA'" + ";";
            dal.ExecutarComandoSQL(comando);
        }
    }
}
