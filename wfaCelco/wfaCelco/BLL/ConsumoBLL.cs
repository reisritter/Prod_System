using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaCelco.DTO;
using wfaCelco.DAL;
using System.Windows.Forms;

namespace wfaCelco.BLL
{
    class ConsumoBLL
    {
        AcessoBD dal = new AcessoBD();

        public void ListaConsumo(DataGridView dgv)
        {
            string comandoSql = "SELECT " +
                                "C.CONSUMO_DATA AS 'DATA DE REGISTRO', " +
                                "C.CONSUMO_QTD AS 'QTDE. CONSUMIDA', " +
                                "P.PRODUCAO_ID AS 'COD. OP' FROM G07_CONSUMO C " +
                                "INNER JOIN G07_PRODUCAO P " +
                                "ON P.PRODUCAO_ID = C.PRODUCAO_ID";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        public void ListaOP(DataGridView dgv)
        {
            string comandoSql = "SELECT a.PRODUCAO_ID AS 'COD. OP',a.PRODUCAO_QTD AS 'QTDE. PRODUÇÃO',i.PRODUTO_NOME AS 'NOME PRODUTO' FROM G07_PRODUCAO a INNER JOIN G07_PRODUTOS i on a.PRODUTO_ID=i.PRODUTO_ID WHERE a.PRODUCAO_STATUS='ABERTO'";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        public void ListaItens(DataGridView dgv, int codOP)
        {
            string comandoSql = "SELECT I.PRODUTO_ID AS 'COD. PROD.', A.PRODUTO_NOME AS 'NOME DO INSUMO', I.FORMULA_ITEM_QTD AS 'QUANTIDADE NECESSÁRIA' FROM G07_ITEM_FORMULA I inner join G07_PRODUTOS A " +
                                "ON A.PRODUTO_ID=I.PRODUTO_ID WHERE FORMULA_ID=(SELECT FORMULA_ID FROM G07_PRODUCAO WHERE PRODUCAO_ID="+codOP+ ") "+
                                "AND PRODUTO_TIPO LIKE 'MATERIA-PRIMA'";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        public void ListaValorEstoque(DataGridView dgv, int campo)
        {
            string comandoSql = "SELECT * FROM G07_ESTOQUE WHERE PRODUTO_ID="+campo+"";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        public void AlteraValorEstoque(int campo_0, int campo_2)
        {
            string comandoSql = "UPDATE G07_ESTOQUE SET ESTOQUE_QTD-=" + campo_2 + " WHERE PRODUTO_ID=" + campo_0 + "";
            dal.ExecutaComandoSQL(comandoSql);
        }

        public void InserirConsumo(ConsumoDTO dto)
        {
            string comandoSql = "INSERT INTO G07_CONSUMO(CONSUMO_DATA,CONSUMO_QTD,LOCAL_ID,PRODUTO_ID,PRODUCAO_ID) " +
                                "VALUES (GETDATE(),"+dto.Consumo_qtde+","+dto.Local_id+","+dto.Produto_id+","+dto.Producao_id+")";
            dal.ExecutaComandoSQL(comandoSql);
        }

        public void AlteraConsumo(ConsumoDTO dto, int cod)
        {
            string comandoSql = "UPDATE G07_CONSUMO SET CONSUMO_QTD="+dto.Consumo_qtde+",LOCAL_ID="+dto.Local_id+",PRODUTO_ID="+dto.Produto_id+", PRODUCAO_ID="+dto.Producao_id+""+
                                " WHERE PRODUCAO_ID="+cod+"";
            dal.ExecutaComandoSQL(comandoSql);
        }

        public void ListarPorCodigo(DataGridView dgv, int codOp)
        {
            string comandoSql = "SELECT DISTINCT " +
                    "C.CONSUMO_DATA AS 'DATA DE REGISTRO', " +
                    "C.CONSUMO_QTD AS 'QTDE. CONSUMIDA', " +
                    "P.PRODUCAO_ID AS 'COD. OP' FROM G07_CONSUMO C " +
                    "INNER JOIN G07_PRODUCAO P " +
                    "ON P.PRODUCAO_ID = C.PRODUCAO_ID WHERE C.PRODUCAO_ID = "+codOp+"";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        /*
         area de procura de dados específicos
             */
        public string NomeProdOP(int codOp)
        {
            string comando = "SELECT B.PRODUTO_NOME FROM G07_PRODUCAO A " +
                             "INNER JOIN G07_PRODUTOS B ON A.PRODUTO_ID =B.PRODUTO_ID WHERE A.PRODUCAO_ID="+codOp+"";
            return dal.Informacao(comando);
        }

        public string DataIniProdOP(int codOp)
        {
            string comando = "SELECT A.PRODUCAO_DATA_INICIO FROM G07_PRODUCAO A " +
                             "INNER JOIN G07_PRODUTOS B ON A.PRODUTO_ID =B.PRODUTO_ID WHERE A.PRODUCAO_ID=" + codOp + "";
            return dal.Informacao(comando);
        }

        public string DataFimProdOP(int codOp)
        {
            string comando = "SELECT A.PRODUCAO_DATA_FIM FROM G07_PRODUCAO A " +
                             "INNER JOIN G07_PRODUTOS B ON A.PRODUTO_ID =B.PRODUTO_ID WHERE A.PRODUCAO_ID=" + codOp + "";
            return dal.Informacao(comando);
        }

        public string QtdeProdOP(int codOp)
        {
            string comando = "SELECT A.PRODUCAO_QTD FROM G07_PRODUCAO A " +
                             "INNER JOIN G07_PRODUTOS B ON A.PRODUTO_ID =B.PRODUTO_ID WHERE A.PRODUCAO_ID=" + codOp + "";
            return dal.Informacao(comando);
        }

        public string DataRegProdOP(int codOp)
        {
            string comando = "SELECT A.PRODUCAO_DATA_REG FROM G07_PRODUCAO A " +
                             "INNER JOIN G07_PRODUTOS B ON A.PRODUTO_ID =B.PRODUTO_ID WHERE A.PRODUCAO_ID=" + codOp + "";
            return dal.Informacao(comando);
        }
    }
}
