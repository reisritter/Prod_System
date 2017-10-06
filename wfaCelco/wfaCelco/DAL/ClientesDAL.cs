using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using wfaCelco.DAL;
using wfaCelco.UI;
using System.Windows.Forms;

namespace wfaCelco.DAL
{
    class ClientesDAL
    {
        private readonly AcessoBD database = new AcessoBD();
        DataTable dt;
        SqlDataAdapter da;

        public void Inserir(string stringComand)
        {
            try
            {
                database.Conectar();
                database.com.CommandText = stringComand;
                database.com.ExecuteNonQuery();
                //dt = new DataTable();
                da = new SqlDataAdapter(database.com);
                //da.Fill(dt);
                //dgvCliente.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                database.Fechar();
            }
        }

        public void Consultar(DataGridView dgvCliente,  string stringComand) 
        {
            try 
            {
                database.Conectar();
                database.com.CommandText = stringComand;
                database.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(database.com);
                da.Fill(dt);
                dgvCliente.DataSource = dt; 

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                database.Fechar();
            }
        }

        public void Buscar(DataGridView dgvCliente, string stringComand)
        {
            try
            {
                database.Conectar();
                database.com.CommandText = stringComand;
                database.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(database.com);
                da.Fill(dt);
                dgvCliente.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                database.Fechar();
            }
        }

        public void Atualizar(string stringComand)
        {
            try
            {
                database.Conectar();
                database.com.CommandText = stringComand;
                database.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(database.com);
                //da.Fill(dt);
                //dgvCliente.DataSource = dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                database.Fechar();
            }
        }

        public DataTable buscaCliById(string stringComand)
        {
            try
            {
                database.Conectar();
                database.com.CommandText = stringComand;
                database.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(database.com);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                database.Fechar();
            }

            return dt;
        }
    }
}
