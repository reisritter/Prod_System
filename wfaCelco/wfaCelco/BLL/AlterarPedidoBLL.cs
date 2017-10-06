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
    class AlterarPedidoBLL
    {
        globalDAL dal = new globalDAL();

        public string Informacao(string PP, string SP, string TP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + TP + ";";
            return dal.Dados(comando);
        }

        public string InformacaoInner(string PP, string SP, string TP, string QP, string QIP)
        {
            string comando = "SELECT " + PP + " FROM dbo.G07_" + SP + " INNER JOIN dbo.G07_" + TP + " ON " + QP + QIP + ";";
            return dal.Dados(comando);
        }

        public void delete(int codigo)
        {
            string comando = "DELETE dbo.G07_ITEM_PEDIDOS FROM dbo.G07_ITEM_PEDIDOS I " +
                             " INNER JOIN " +
                             " dbo.G07_PEDIDOS P ON I.PEDIDO_ID = P.PEDIDO_ID " +
                             "WHERE I.PEDIDO_ID = " + codigo + ";";
            dal.ExecutarComandoSQL(comando);
        }
    }
}
