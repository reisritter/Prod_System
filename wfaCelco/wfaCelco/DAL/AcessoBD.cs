using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCelco.DAL
{
    class AcessoBD
    {
        //private readonly string stringConexao = "Data Source=DESKTOP-I0DV793\\SQLEXPRESS2014;Initial Catalog=IES300-T;Integrated Security=True";
        private string stringConexao = "Data Source=JONATHAN-PC\\SQLSERVER;Initial Catalog=IES300-T;Integrated Security=True";
        //private string stringConexao = "server=localhost;database=IES300-T;user id=sa;password=senha123;";
        //private string stringConexao = "Data Source=MSMANAGER\\SQLSERVER2012;Initial Catalog=IES300-T;User ID=aluno; password = aluno";
        //private string stringConexao = "Data Source=MICRO-PC;Initial Catalog=IES300-T;Integrated Security=True";
        //private string stringConexao = "Data Source=NOTE-PC\\SQLEXPRESS;Initial Catalog=IES300-T; User ID=sa; password = aluno";
        public SqlConnection con;
        public SqlCommand com;
        public DataTable dt;
        public SqlDataAdapter da;

        public void Conectar()
        {
            try
            {
                con = new SqlConnection(stringConexao);
                com = new SqlCommand();
                com.Connection = con;
                con.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Fechar()
        {
            con.Close();
            con = null;
            com = null;
        }

        public DataTable Consulta(string stringCommand)
        {
            try
            {
                Conectar();
                com.CommandText = stringCommand;
                com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(com);
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Fechar();
            }

            return dt;
        }

        public DataTable buscaById(string stringComand)
        {
            try
            {
                Conectar();
                com.CommandText = stringComand;
                com.ExecuteNonQuery();
                dt = new DataTable();
                da = new SqlDataAdapter(com);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Fechar();
            }

            return dt;
        }

        public void ExecutaComandoSQL(string comandoSql)
        {
            try
            {
                Conectar();
                com = new SqlCommand(comandoSql, con);
                com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Fechar();
            }
        }

        public string Informacao(string comandoSql)
        {
            try
            {
                Conectar();
                com.CommandType = CommandType.Text;
                com.CommandText = comandoSql;
                return Convert.ToString(com.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Fechar();
            }
        }

        public int InformacaoInteira(string comandoSql)
        {
            try
            {
                Conectar();
                com.CommandType = CommandType.Text;
                com.CommandText = comandoSql;
                return Convert.ToInt32(com.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Fechar();
            }
        }
    }
}
