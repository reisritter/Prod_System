using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaCelco.DTO
{
    class PedidosDTO
    {
        private int FORMULA_ID;
        private string FORMULA_DESCRICAO;
        private string pedido_data_entrega;
        private int cli_id;
        public int codigo
        {
            get
            {
                return FORMULA_ID;
            }

            set
            {
                FORMULA_ID = value;
            }
        }

        public string descricao
        {
            get
            {
                return FORMULA_DESCRICAO;
            }

            set
            {
                FORMULA_DESCRICAO = value;
            }
        }

        public string Pedido_data_entrega
        {
            get
            {
                return pedido_data_entrega;
            }

            set
            {
                pedido_data_entrega = value;
            }
        }

        public int Cli_id
        {
            get
            {
                return cli_id;
            }

            set
            {
                cli_id = value;
            }
        }
    }
}
