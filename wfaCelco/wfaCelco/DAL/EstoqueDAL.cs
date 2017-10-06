using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DAL
{
    class EstoqueDAL
    {
        AcessoBD acesso = new AcessoBD();

        public void Insere_Estoque(int qtd, int local_id, int prod_id)
        {
            try
            {
                acesso.Conectar();
                acesso.com.CommandText = "INSERT INTO G07_ESTOQUE VALUES (@QTD,@LOCAL_ID,@PROD_ID)";
                acesso.com.Parameters.AddWithValue("@QTD", qtd);
                acesso.com.Parameters.AddWithValue("@LOCAL_ID", local_id);
                acesso.com.Parameters.AddWithValue("@PROD_ID", prod_id);
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

        public void Update_Estoque(int qtd, int id)
        {
            try
            {
                acesso.Conectar();
                acesso.com.CommandText = "UPDATE G07_ESTOQUE SET ESTOQUE_QTD = @QTD WHERE PRODUTO_ID = @ID";
                acesso.com.Parameters.AddWithValue("@QTD", qtd);
                acesso.com.Parameters.AddWithValue("@ID", id);
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
