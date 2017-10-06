using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using wfaCelco.DTO;

namespace wfaCelco.DAL
{
    class globalDAL
    {
        AcessoBD bd = new AcessoBD();
        DataTable dt;
        SqlDataAdapter da;

        public void atualizar(DataGridView dgv, string stringCommand) // [SELECT]
        {
            try
            {
                bd.Conectar();
                bd.com.CommandText = stringCommand;
                bd.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(bd.com);
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public string Informacao(string comandoSql)
        {
            try
            {
                bd.Conectar();
                bd.com.CommandType = CommandType.Text;
                bd.com.CommandText = comandoSql;
                return Convert.ToString(bd.com.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public string Dados(string comandoSql)
        {
            try
            {
                bd.Conectar();
                bd.com.CommandType = CommandType.Text;
                bd.com.CommandText = comandoSql;
                return Convert.ToString(bd.com.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public void selecnova(ComboBox cb, string stringCommand) // [SELECT COMBO BOX]
        {
            try
            {
                bd.Conectar();
                bd.com.CommandText = stringCommand;
                bd.com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(bd.com);
                da.Fill(dt);
                cb.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }

        public void ExecutarComandoSQL(string comandoSql) // [INSERT/UPDATE]
        {
            try
            {
                bd.Conectar();
                bd.com.CommandText = comandoSql;
                bd.com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                bd.Fechar();
            }
        }
    }
}
