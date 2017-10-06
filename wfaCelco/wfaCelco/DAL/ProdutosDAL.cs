using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaCelco.DAL;
using wfaCelco.UI; 
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace wfaCelco.DAL
{
    class ProdutosDAL
    {
        private readonly AcessoBD databaseProd = new AcessoBD();
        DataTable dt;
        SqlDataAdapter da;

        public void Consultar(DataGridView dgvProduto, string stringComand)
        {
            try
            {
                databaseProd.Conectar();
                databaseProd.com.CommandText = stringComand;
                databaseProd.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(databaseProd.com);
                da.Fill(dt);
                dgvProduto.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                databaseProd.Fechar();
            }
        }

        public void Inserir(string stringComand)
        {
            try
            {
                databaseProd.Conectar();
                databaseProd.com.CommandText = stringComand;
                databaseProd.com.ExecuteNonQuery();
                //dt = new DataTable();
                da = new SqlDataAdapter(databaseProd.com);
                //da.Fill(dt);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                databaseProd.Fechar();
            }
        }

        public void Atualizar(string stringComand)
        {
            try
            {
                databaseProd.Conectar();
                databaseProd.com.CommandText = stringComand;
                databaseProd.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(databaseProd.com);
                //da.Fill(dt);
                //dgvCliente.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                databaseProd.Fechar();
            }
        }

        public DataTable buscaProdById(string stringComand)
        {
            try
            {
                databaseProd.Conectar();
                databaseProd.com.CommandText = stringComand;
                databaseProd.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(databaseProd.com);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                databaseProd.Fechar();
            }

            return dt;
        }

    }
}
