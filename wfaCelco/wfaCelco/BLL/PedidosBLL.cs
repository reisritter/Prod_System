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
    class PedidosBLL
    {
        globalDAL dal = new globalDAL();
        

        public string Dados(string PP, string SP, string TP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + TP + ";";
            return dal.Dados(comando);
        }

        public string Condicao1()
        {
            string comando = "SELECT MAX(PRODUTO_ID) FROM dbo.G07_PRODUTOS ";
            return dal.Dados(comando);
        }

        public string Condicao2()
        {
            string comando = "SELECT MAX(I.PRODUTO_ID) FROM dbo.G07_ITEM_PEDIDOS I " +
                             "INNER JOIN " +
                             "dbo.G07_PRODUTOS P ON I.PRODUTO_ID = P.PRODUTO_ID ";
            return dal.Dados(comando);
        }

        public void AtualizaGridPedidos(DataGridView dgv, string P)
        {
            string comandoSQL = "SELECT	PEDIDO_ID 'Cod. Pedido', PEDIDO_DATA 'Data Pedido', " +
                                "PEDIDO_DATA_ENTREGA 'Data Entrega', PEDIDO_STATUS 'Status Pedido', " +
                                "CLI_NOME_RESPONSAVEL 'Nome Cliente' FROM G07_PEDIDOS P " +
                                "INNER JOIN G07_CLIENTES C ON C.CLI_ID = P.CLI_ID";
            dal.atualizar(dgv, comandoSQL);
        }

        public void AtualizaGridItens(DataGridView dgv, string P)
        {
            string comandoSQL = "SELECT  ITEM_ID 'Cod. Item', ITEM_QTD 'Quantidade Item', " +
                                "I.PEDIDO_ID 'Cod. Pedido', I.PRODUTO_ID 'Cod. Produto', " +
                                "R.PRODUTO_NOME 'Nome Produto' FROM G07_PEDIDOS P " +
                                "INNER JOIN dbo.G07_ITEM_PEDIDOS I ON I.PEDIDO_ID = P.PEDIDO_ID " +
                                "INNER JOIN dbo.G07_PRODUTOS R ON R.PRODUTO_ID = I.PRODUTO_ID " +
                               "WHERE I.PEDIDO_ID = " + P + ";";
            dal.atualizar(dgv, comandoSQL);
        }

        public void AtualizarProcesso(PedidosDTO dto, string P)
        {
            string comandoSQL = "UPDATE G07_PEDIDOS SET PEDIDO_STATUS = 'CANCELADO' WHERE PEDIDO_ID = " + P + ";";
            dal.ExecutarComandoSQL(comandoSQL);
        }

        public void SalvaPedido(PedidosDTO dto)
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

        public void ListaProd(ComboBox cb)
        {
            string comando = "SELECT * FROM dbo.G07_PRODUTOS P ";
            dal.selecnova(cb, comando);
        }
        public void ListaCli(ComboBox cb)
        {
            string comando = "SELECT * FROM dbo.G07_CLIENTES C ";
            dal.selecnova(cb, comando);
        }
    }
}
