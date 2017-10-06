using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaCelco.DAL;
using wfaCelco.DTO;
using wfaCelco.UI;

namespace wfaCelco.BLL
{
    class RecursosBLL
    {
        AcessoBD dal   = new AcessoBD();
        globalDAL dalg = new globalDAL();

        public void ItemRecurso(DataGridView dgv, string codigo)
        {
            //string comando = "SELECT B.RECURSO_ID,B.RECURSO_NOME,B.RECURSO_QTD FROM G07_RECURSOS B INNER JOIN G07_ITEM_RECURSO A ON B.RECURSO_ID = A.RECURSO_ID WHERE A.PRODUCAO_ID =" + codigo;
            string comando = "SELECT * FROM dbo.G07_ITEM_RECURSO WHERE PRODUCAO_ID = " + codigo;
            dalg.atualizar(dgv, comando);
        }

        public void update(ProducaoDTO dto, string codigo)
        {
            string comando = "UPDATE dbo.G07_PRODUCAO " +
                "SET PRODUCAO_QTD = " + dto.Producao_qtd + ", " +
                " PRODUCAO_DATA_INICIO = '" + dto.Producao_data_inicio + "', " +
                " PRODUCAO_DATA_FIM = '" + dto.Producao_data_fim + "', " +
                " PRODUCAO_OBS = '" + dto.Producao_obs + "', " +
                " PRODUTO_ID = " + dto.Produto_id +
                " WHERE PRODUCAO_ID = " + codigo + ";";

            string comando2 = "DELETE FROM dbo.G07_ITEM_RECURSO WHERE PRODUCAO_ID = " + codigo;

            try
            {
                dalg.ExecutarComandoSQL(comando);
                dalg.ExecutarComandoSQL(comando2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*======================================
          PARA CAPTURAR DADOS UNITARIOS DO BANCO
          ======================================*/

        public string Informacao(string PP, string SP, string TP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + TP + ";";
            return dalg.Informacao(comando);
        }
        
        /*=====================================
          PARA SALVAR ITENS DE RECURSO NO BANCO
          =====================================*/

        public void SalvaItemRec(ItemRecDTO dto)
        {
            string comando = "INSERT INTO G07_ITEM_RECURSO VALUES" +
                             "(" + dto.QTD + "," + dto.REC_ID + "," + dto.PROD_ID + ");";

            try
            {
                dalg.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        //lista todos os recursos ativos
        public void ListaRecursos(DataGridView dgv)
        {
            string comando = "SELECT RECURSO_ID AS 'CODIGO', RECURSO_NOME AS 'NOME DO RECURSO', RECURSO_TIPO AS 'TIPO DE RECURSO', RECURSO_QTD AS 'QTDE. DE RECURSO', RECURSO_STATUS AS 'STATUS DO RECURSO' FROM G07_RECURSOS WHERE RECURSO_STATUS='ATIVADO'";
            dgv.DataSource = dal.Consulta(comando);
        }

        //insere os recursos
        public void InsereRecurso(RecursosDTO dto)
        {
            string comando = "INSERT INTO G07_RECURSOS (RECURSO_TIPO,RECURSO_NOME,RECURSO_QTD, RECURSO_STATUS) VALUES ('"+dto.Recurso_tipo+"','"+dto.Recurso_nome+"',"+dto.Recurso_qtde+",'ATIVADO')";
            dal.ExecutaComandoSQL(comando);
        }

        //alterar o recurso selecionado
        public void AlteraRecurso(RecursosDTO dto)
        {
            string comando = "UPDATE G07_RECURSOS SET RECURSO_TIPO = '"+dto.Recurso_tipo+"', RECURSO_NOME='"+dto.Recurso_nome+"', RECURSO_QTD="+dto.Recurso_qtde+" WHERE RECURSO_ID="+dto.Recurso_id+"";
            dal.ExecutaComandoSQL(comando);
        }

        public frmRecursoNovo.Recursos buscaRecById(int id)
        {
            string populaForm = "SELECT * FROM G07_RECURSOS WHERE RECURSO_ID = " + id;

            DataTable datatable = dal.buscaById(populaForm);
            return constroiRecursoFromDataTable(datatable);
        }

        public frmRecursoNovo.Recursos constroiRecursoFromDataTable(DataTable dt)
        {
            frmRecursoNovo.Recursos rec = new frmRecursoNovo.Recursos();
            rec.id = (int)dt.Rows[0]["RECURSO_ID"];
            rec.tipo_recurso = dt.Rows[0]["RECURSO_TIPO"].ToString();
            rec.qtde_recurso = (int)dt.Rows[0]["RECURSO_QTD"];
            rec.nome_recurso = dt.Rows[0]["RECURSO_NOME"].ToString();

            return rec;
        }

        //desativa o recurso selecionado
        public void DesativaRec(RecursosDTO dto)
        {
            string comandoSql = "UPDATE G07_RECURSOS SET RECURSO_STATUS='DESATIVADO' WHERE RECURSO_ID="+dto.Recurso_id+"";
            dal.ExecutaComandoSQL(comandoSql);
        }

        /* ============================
         * ============================
         * =====area de pesquisa=======*/
        public void ConsultaPorStatus(DataGridView dgv, string status)
        {
            string comandoSql = "SELECT RECURSO_ID AS 'CODIGO', RECURSO_NOME AS 'NOME DO RECURSO', "+
                                "RECURSO_TIPO AS 'TIPO DE RECURSO', RECURSO_QTD AS 'QTDE. DE RECURSO', "+
                                "RECURSO_STATUS AS 'STATUS DO RECURSO' FROM G07_RECURSOS WHERE RECURSO_STATUS='"+status+"'";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        public void ConsultaPorRec(DataGridView dgv, string nomeRec)
        {
            string comandoSql = "SELECT RECURSO_ID AS 'CODIGO', RECURSO_NOME AS 'NOME DO RECURSO', " +
                    "RECURSO_TIPO AS 'TIPO DE RECURSO', RECURSO_QTD AS 'QTDE. DE RECURSO', " +
                    "RECURSO_STATUS AS 'STATUS DO RECURSO' FROM G07_RECURSOS WHERE RECURSO_NOME LIKE '" + nomeRec + "%'";
            dgv.DataSource = dal.Consulta(comandoSql);
        }
    }
}
