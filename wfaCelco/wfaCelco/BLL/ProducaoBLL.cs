using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaCelco.DAL;
using wfaCelco.DTO;

namespace wfaCelco.BLL
{
    class ProducaoBLL
    {
        AcessoBD dal= new AcessoBD();

        public void AtualizaGrid(DataGridView dgv)
        {
            string comandoSQL = "SELECT  producao.PRODUCAO_ID AS 'Nro OP'," +
                                        "produto.PRODUTO_ID AS 'CODIGO DO PRODUTO'," +
                                        "produto.PRODUTO_NOME AS 'NOME DO PRODUTO'," +
                                        "producao.PRODUCAO_DATA_INICIO AS 'Data do Início da Produção'," +
                                        "producao.PRODUCAO_DATA_FIM AS 'Data do Fim da Produção'," +
                                        "producao.PRODUCAO_QTD AS 'Quantidade Requerida'," +
                                        "producao.PRODUCAO_STATUS AS 'Status da OP' FROM G07_PRODUCAO AS producao " +
                                        "INNER JOIN G07_PRODUTOS AS produto ON producao.PRODUTO_ID = produto.PRODUTO_ID";
            dgv.DataSource = dal.Consulta(comandoSQL);

        }

        public void NovaOP(ProducaoDTO dto)
        {
            string comando = "INSERT INTO G07_PRODUCAO (PRODUCAO_DATA_INICIO,PRODUCAO_DATA_FIM,PRODUCAO_QTD,PRODUCAO_STATUS, PRODUCAO_DATA_REG,PRODUCAO_OBS, PRODUTO_ID, FORMULA_ID)" +
                             "VALUES ('"+dto.Producao_data_inicio+"','"+dto.Producao_data_fim+"',"+dto.Producao_qtd+",'ABERTO', GETDATE(),'"+dto.Producao_obs+"',"+dto.Produto_id+","+dto.FORM+");";

            try
            {
                dal.ExecutaComandoSQL(comando);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarCampoStatus(ProducaoDTO dto)
        {
            string comando = "UPDATE G07_PRODUCAO SET PRODUCAO_STATUS = '" + dto.Producao_status + "' WHERE PRODUCAO_ID =" + dto.Producao_id + " ";
            dal.ExecutaComandoSQL(comando);
        }

        public void ConsultaPorStatus(DataGridView dgv, string status)
        {
            string comandoSql = "SELECT  producao.PRODUCAO_ID AS 'Nro OP'," +
                                        "produto.PRODUTO_ID AS 'CODIGO DO PRODUTO'," +
                                        "produto.PRODUTO_NOME AS 'NOME DO PRODUTO'," +
                                        "producao.PRODUCAO_DATA_INICIO AS 'Data do Início da Produção'," +
                                        "producao.PRODUCAO_DATA_FIM AS 'Data do Fim da Produção'," +
                                        "producao.PRODUCAO_QTD AS 'Quantidade Requerida'," +
                                        "producao.PRODUCAO_STATUS AS 'Status da OP' FROM G07_PRODUCAO AS producao " +
                                        "INNER JOIN G07_PRODUTOS AS produto ON producao.PRODUTO_ID = produto.PRODUTO_ID "+
                                        "where producao.PRODUCAO_STATUS='"+status+"'";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        public void ConsultaPorProduto(DataGridView dgv, string nome)
        {
            string comandoSql = "SELECT  producao.PRODUCAO_ID AS 'Nro OP'," +
                                        "produto.PRODUTO_ID AS 'CODIGO DO PRODUTO'," +
                                        "produto.PRODUTO_NOME AS 'NOME DO PRODUTO'," +
                                        "producao.PRODUCAO_DATA_INICIO AS 'Data do Início da Produção'," +
                                        "producao.PRODUCAO_DATA_FIM AS 'Data do Fim da Produção'," +
                                        "producao.PRODUCAO_QTD AS 'Quantidade Requerida'," +
                                        "producao.PRODUCAO_STATUS AS 'Status da OP' FROM G07_PRODUCAO AS producao " +
                                        "INNER JOIN G07_PRODUTOS AS produto ON producao.PRODUTO_ID = produto.PRODUTO_ID " +
                                        "WHERE produto.PRODUTO_NOME LIKE '" + nome + "%'";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        public void PreencheGridProdutoProd(DataGridView dgv)
        {
            string comandoSql = "SELECT PRODUTO_ID AS 'Código do Produto', PRODUTO_NOME AS 'Nome do Produto' FROM G07_PRODUTOS WHERE PRODUTO_STATUS=1";
            dgv.DataSource = dal.Consulta(comandoSql);
        }

        public void consultaProdutosAtivos(ComboBox cbb)
        {
            //string comandoSql = "SELECT A.PRODUTO_ID, A.PRODUTO_NOME FROM G07_PRODUTOS A INNER JOIN G07_ITEM_FORMULA B ON B.PRODUTO_ID= A.PRODUTO_ID WHERE A.PRODUTO_STATUS=1 AND A.PRODUTO_TIPO='PRODUTO ACABADO'";
            string comandoSql = "SELECT B.PRODUTO_ID,B.PRODUTO_NOME FROM G07_ITEM_PEDIDOS A " +
                                "INNER JOIN G07_PRODUTOS B ON(A.PRODUTO_ID = B.PRODUTO_ID) " +
                                "INNER JOIN G07_PEDIDOS C ON(C.PEDIDO_ID = A.PEDIDO_ID) " +
                                "INNER JOIN G07_ITEM_FORMULA D ON(D.PRODUTO_ID = B.PRODUTO_ID) " +
                                "WHERE C.PEDIDO_STATUS = 'EM PROCESSO' AND B.PRODUTO_STATUS=1 AND B.PRODUTO_TIPO='PRODUTO ACABADO'";
            cbb.DataSource = dal.Consulta(comandoSql);
        }

        public string consultaPedidoProd(int codProd)
        {
            string comandoSql = "SELECT A.PEDIDO_ID FROM G07_ITEM_PEDIDOS A "+
                                "INNER JOIN G07_PEDIDOS B ON(A.PEDIDO_ID = B.PEDIDO_ID) "+
                                "WHERE A.PRODUTO_ID = "+codProd+" AND B.PEDIDO_STATUS = 'EM PROCESSO'";
            return dal.Informacao(comandoSql);
        }

        public void consultaRecursos(ComboBox cbb, string tipo)
        {
            string comandoSql = "SELECT RECURSO_ID,RECURSO_NOME FROM G07_RECURSOS WHERE RECURSO_TIPO='"+tipo+"' AND RECURSO_STATUS='ATIVADO'";
            cbb.DataSource = dal.Consulta(comandoSql);
        }
    }
}
