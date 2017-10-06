using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaCelco.DAL;
using System.Windows.Forms;

namespace wfaCelco.BLL
{
    class EstoqueBLL
    {
        EstoqueDAL estoqueDAL = new EstoqueDAL();
        AcessoBD acesso = new AcessoBD();

        public int Consulta_QTDE_ESTQOUE(int id)
        {
            string s = "select SUM(ESTOQUE_QTD) as Total FROM G07_ESTOQUE" +
                        " WHERE PRODUTO_ID = " + id;

            int n = Convert.ToInt32(acesso.Consulta(s).Rows[0]["Total"].ToString());
            return n;
        }

        public void Mult_Menos_Um(int qtd, TextBox txtAdd)
        {
            qtd *= -1;
            txtAdd.Text = qtd.ToString();
        }

        public int Consulta_UltimoProduto()
        {
            string s = "SELECT TOP 1 PRODUTO_ID FROM G07_PRODUTOS ORDER BY PRODUTO_ID DESC";
            int ret = Convert.ToInt32(acesso.Consulta(s).Rows[0]["PRODUTO_ID"].ToString());
            return ret;
        }
    }
}
