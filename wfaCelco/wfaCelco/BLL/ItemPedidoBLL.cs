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
    class ItemPedidoBLL
    {
        globalDAL dal = new globalDAL();

        public string Dados(string PP, string SP, string TP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + TP + ";";
            return dal.Dados(comando);
        }

        public void SalvaItens(ItemPedidoDTO dto)
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
    }
}
