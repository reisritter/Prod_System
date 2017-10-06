using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaCelco.DAL;

namespace wfaCelco.BLL
{
    class PedidoBLL
    {
        AcessoBD acesso = new AcessoBD();

        public int Consulta_Ultimo_Pedido()
        {
            string s = "SELECT TOP 1 PEDIDO_ID FROM G07_PEDIDOS ORDER BY PEDIDO_ID DESC";
            int ret = Convert.ToInt32(acesso.Consulta(s).Rows[0]["PEDIDO_ID"].ToString());
            return ret;
        }
    }
}
