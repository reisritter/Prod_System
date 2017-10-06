using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaCelco.DAL;
using System.Data;
using wfaCelco.UI;

namespace wfaCelco.BLL
{
    class ClienteBLL
    {
        ClientesDAL cliDal = new ClientesDAL();

        public void inserirCli(string razao, string cnpj, string nome, string email, string tel, string cep, string nomeLog, string tipoLog, string cidade, string bairro, string comp, string num, string uf)
        {
            string inserirSQL = String.Format("INSERT INTO G07_CLIENTES (CLI_RAZAO_SOCIAL, CLI_CNPJ,CLI_NOME_RESPONSAVEL, CLI_EMAIL, CLI_TELEFONE, CLI_CEP, CLI_NOME_LOGRADOURO, CLI_TIPO_LOGRADOURO, CLI_CIDADE, CLI_BAIRRO, CLI_COMPLEMENTO, CLI_NUMERO_LOGRADOURO, CLI_UF) VALUES('{0}',{1},'{2}','{3}',{4},{5},'{6}','{7}','{8}','{9}','{10}',{11},'{12}')", razao, cnpj, nome, email, tel, cep, nomeLog, tipoLog, cidade, bairro, comp, num, uf);
            cliDal.Inserir(inserirSQL);
        }

        public void consultarCli(DataGridView dgv)
        {
            
            string consultaSQL = "SELECT CLI_ID            as 'Código'," +
                                 "CLI_RAZAO_SOCIAL         as 'Razão Social'," +
                                 "CLI_NOME_RESPONSAVEL     as 'Nome'," +
                                 "CLI_TELEFONE             as 'Telefone'," +
                                 "CLI_UF                   as 'UF' FROM G07_CLIENTES";
            cliDal.Consultar(dgv, consultaSQL);
        }

        public void buscarCli(DataGridView dgv, string txt)
        {
            string buscarSQL =   "SELECT CLI_ID            as 'Código'," +
                                 "CLI_RAZAO_SOCIAL         as 'Razão Social'," +
                                 "CLI_NOME_RESPONSAVEL     as 'Nome'," +
                                 "CLI_TELEFONE             as 'Telefone'," +
                                 "CLI_UF                   as 'UF' FROM G07_CLIENTES WHERE CLI_RAZAO_SOCIAL = '" + txt + "'";

            cliDal.Buscar(dgv, buscarSQL); 
        }

        public frmCadastroCli.Cliente buscaCliById(int id)
        {
            string populaForm = "SELECT * FROM G07_CLIENTES WHERE CLI_ID = " + id;

            DataTable datatable = cliDal.buscaCliById(populaForm);
            return constroiClienteFromDataTable(datatable);
        }

        public void atualizarCli(int id, string razao, string cnpj, string nome, string email, string tel, string cep, string nomeLog, string tipoLog, string cidade, string bairro, string comp, string num, string uf)
        {
            string updateSQL = String.Format("UPDATE G07_CLIENTES SET " +
                                                "CLI_RAZAO_SOCIAL = '{1}'," +
                                                "CLI_CNPJ = '{2}'," +
                                                "CLI_NOME_RESPONSAVEL = '{3}'," +
                                                "CLI_EMAIL = '{4}'," +
                                                "CLI_TELEFONE = '{5}'," +
                                                "CLI_CEP = '{6}'," +
                                                "CLI_NOME_LOGRADOURO = '{7}'," +
                                                "CLI_TIPO_LOGRADOURO = '{8}'," +
                                                "CLI_CIDADE = '{9}'," +
                                                "CLI_BAIRRO = '{10}'," +
                                                "CLI_COMPLEMENTO = '{11}'," +
                                                "CLI_NUMERO_LOGRADOURO = '{12}'," +
                                                "CLI_UF = '{13}'" +
                                                " WHERE CLI_ID = {0}",
                                                id,
                                                razao,
                                                cnpj,
                                                nome,
                                                email,
                                                tel,
                                                cep,
                                                nomeLog,
                                                tipoLog,
                                                cidade,
                                                bairro,
                                                comp,
                                                num,
                                                uf);

            cliDal.Atualizar(updateSQL);
        }

        public frmCadastroCli.Cliente constroiClienteFromDataTable(DataTable dt)
        {

            frmCadastroCli.Cliente cliente = new frmCadastroCli.Cliente();

            cliente.id = (int) dt.Rows[0]["CLI_ID"];
            cliente.razao = dt.Rows[0]["CLI_RAZAO_SOCIAL"].ToString();
            cliente.cnpj = dt.Rows[0]["CLI_CNPJ"].ToString();
            cliente.nome = dt.Rows[0]["CLI_NOME_RESPONSAVEL"].ToString();
            cliente.email = dt.Rows[0]["CLI_EMAIL"].ToString();
            cliente.telefone = dt.Rows[0]["CLI_TELEFONE"].ToString();
            cliente.cep = dt.Rows[0]["CLI_CEP"].ToString();
            cliente.rua = dt.Rows[0]["CLI_NOME_LOGRADOURO"].ToString();
            cliente.tipo = dt.Rows[0]["CLI_TIPO_LOGRADOURO"].ToString();
            cliente.cidade = dt.Rows[0]["CLI_CIDADE"].ToString();
            cliente.bairro = dt.Rows[0]["CLI_BAIRRO"].ToString();
            cliente.comp = dt.Rows[0]["CLI_COMPLEMENTO"].ToString();
            cliente.numero = dt.Rows[0]["CLI_NUMERO_LOGRADOURO"].ToString();
            cliente.uf = dt.Rows[0]["CLI_UF"].ToString();

            return cliente;
        }
    }
}
