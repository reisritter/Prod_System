using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DAL
{
    class PedidoDAL
    {
        AcessoBD acesso = new AcessoBD();        

        public void Insere_Pedido(DateTime data, int cli_id, int prod_id)
        {
            try
            {
                acesso.Conectar();
                acesso.com.CommandText = "INSERT INTO G07_PEDIDOS VALUES (GETDATE(),@DATA_ENTREGA,'EM PROCESSO',@CLI_ID,@PRODUTO_ID)";
                acesso.com.Parameters.AddWithValue("@DATA_ENTREGA", data);
                acesso.com.Parameters.AddWithValue("@CLI_ID", cli_id);
                acesso.com.Parameters.AddWithValue("@PRODUTO_ID", prod_id);
                acesso.com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                acesso.Fechar();
            }
        }

        public void Insere_Item_Pedido(int qtd, int ped_id, int prod_id)
        {
            try
            {
                acesso.Conectar();
                acesso.com.CommandText = "INSERT INTO G07_ITEM_PEDIDOS VALUES (0,@QTD,@PEDIDO_ID,@PRODUTO_ID)";
                acesso.com.Parameters.AddWithValue("@QTD", qtd);
                acesso.com.Parameters.AddWithValue("@PEDIDO_ID", ped_id);
                acesso.com.Parameters.AddWithValue("@PRODUTO_ID", prod_id);
                acesso.com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                acesso.Fechar();
            }
        }

    }
}
